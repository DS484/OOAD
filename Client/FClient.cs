using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FClient : Form
    {
        private IPEndPoint IP;
        private Socket client;

        public FClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ConnectServer();
            this.StartPosition = FormStartPosition.Manual;

            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            this.Location = new Point(300, workingArea.Height / 2 - this.Height / 2);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        public void ConnectServer()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(ReceiveMessage);
            listen.IsBackground = true;
            listen.Start();
        }

        public void CloseClient()
        {
            client.Close();
        }
        
        public void SendMessage()
        {
            if (txtMessage.Text != string.Empty)
                client.Send(SerializeData("Khách hàng: " + txtMessage.Text));
        }

        public void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)DeserializeData(data);

                    AddMessage(message);
                }
            }
            catch 
            {
                Close(); 
            }
        }

        void AddMessage(string message)
        {
            lvMessage.Items.Add(new ListViewItem() { Text = message });
            txtMessage.Clear();
        }

        byte[] SerializeData(object obj)
        {
            MemoryStream stream = new MemoryStream();  
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        object DeserializeData(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void FClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnsend_Click_1(object sender, EventArgs e)
        {
            SendMessage();
            AddMessage(txtMessage.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
