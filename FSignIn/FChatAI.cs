using GenerativeAI.Methods;
using GenerativeAI.Models;
using GenerativeAI.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FChatAI : Form
    {
        ChatSession? chatSession;
        public string apiKey = "AIzaSyCjhe255nXjOQwst6NM6RrXCbz03xl66HM";

        public FChatAI()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text.Trim();
            await SendMessageAsync(message);
        }

        private async Task SendMessageAsync(string message)
        {
            if (message.Length > 0)
            {
                txtMessage.Text = "";
                btnSend.Text = "Waiting...";

                txtBody.SelectionAlignment = HorizontalAlignment.Left;
                txtBody.SelectionColor = Color.Brown;
                txtBody.Font = new Font("Segoe UI", 12);
                txtBody.AppendText($"Me: {message}\n");

                txtBody.SelectionAlignment = HorizontalAlignment.Right;
                txtBody.SelectionColor = Color.SeaGreen;
                txtBody.Font = new Font("Segoe UI", 12);
                var result = await chatSession!.SendMessageAsync(message);
                txtBody.AppendText($"Gemini AI: {result}\n");

                txtBody.SelectionAlignment = HorizontalAlignment.Left;
                txtBody.SelectionColor = txtBody.ForeColor;

                btnSend.Text = "Send message";
                txtBody.ScrollToCaret();
            }
        }

        private void FChatAI_Load(object sender, EventArgs e)
        {
            txtMessage.Focus();
            var model = new GenerativeModel(apiKey);
            chatSession = model.StartChat(new StartChatParams());
        }

        private async void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var message = txtMessage.Text.Trim();
                await SendMessageAsync(message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
