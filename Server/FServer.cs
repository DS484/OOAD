using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FServer : Form
    {
        private IPEndPoint IP;
        private Socket server;
        private List<Socket> clientList;

        public FServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ConnectClient();
            // Thiết lập StartPosition là Manual để có thể tự đặt vị trí form
            this.StartPosition = FormStartPosition.Manual;

            // Lấy kích thước của màn hình chính
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Đặt tọa độ của form ở bên phải màn hình với một khoảng cách nào đó (ví dụ: 50 pixel)
            this.Location = new Point(workingArea.Width - this.Width - 300, workingArea.Height / 2 - this.Height / 2);
        }

        private void FServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseServer();
        }

        public void ConnectClient()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();

                        clientList.Add(client);

                        Thread receive = new Thread(ReceiveMessage);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        public void CloseServer()
        {
            server.Close();
        }

        public void SendMessage(Socket client)
        {
            if (client != null && txtMessage.Text != string.Empty)
                client.Send(SerializeData("Nhân viên hỗ trợ:" + txtMessage.Text));
        }

        public void ReceiveMessage(object obj)
        {
            Socket client = obj as Socket;
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
                clientList.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string message)
        {
            lvMessage.Items.Add(new ListViewItem() { Text = message });
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


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsend_Click_2(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                SendMessage(item);
            }
            AddMessage(txtMessage.Text);
            txtMessage.Clear();
        }

        private void FServer_Load(object sender, EventArgs e)
        {

        }
    }
}
