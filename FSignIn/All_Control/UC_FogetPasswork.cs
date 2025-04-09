using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Hotel_Management.DAO;

namespace Hotel_Management.All_Control
{
    public partial class UC_FogetPasswork : UserControl
    {
        private int? codeOTP;
        private int id = 0;

        private CustomerDAO customerDAO = new CustomerDAO();

        public UC_FogetPasswork()
        {
            InitializeComponent();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                id = customerDAO.FindId(txtUserName.Text);
            }
            catch 
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                codeOTP = new Random().Next(100000, 999999);
                string pass = "lpuoptnhrhukaetk";

                MailMessage message = new MailMessage();
                message.To.Add(txtEmail.Text);
                message.From = new MailAddress("ndsang404@gmail.com");
                message.Subject = "MÃ XÁC NHẬN LẤY LẠI TÀI KHOẢN";
                message.Body = "OTP CỦA BẠN LÀ : " + codeOTP;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("ndsang404@gmail.com", pass)
                };
                smtp.Send(message);
                MessageBox.Show("Gửi thành công, vui lòng kiểm tra gmail của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Gửi không thành công!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == codeOTP.ToString() && txtOTP.Text != "")
            {
                MessageBox.Show("Hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FResetPassWord fResetPassWord = new FResetPassWord(txtUserName.Text);
                fResetPassWord.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã OTP không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
