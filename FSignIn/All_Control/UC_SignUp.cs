using Hotel_Management.Constants;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.All_Control
{
    public partial class UC_SignUp : UserControl
    {
        private CustomerDAO cust = new CustomerDAO();
        public UC_SignUp()
        {
            InitializeComponent();

        }
        private bool CheckPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }
        private bool CheckIdentifyCard(string card)
        {
            return Regex.IsMatch(card, @"^\d{12}$");
        }
        private void btnCompleteAcc_Click(object sender, EventArgs e)
        {
            string[] input = { txtFullName.Text, txtUserName.Text, txtPassword.Text, txtPhoneNumber.Text, txtIdentifyCard.Text };
            foreach (string s in input)
            {
                if (string.IsNullOrEmpty(s))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!CheckPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckIdentifyCard(txtIdentifyCard.Text))
            {
                MessageBox.Show("Số căn cước công dân không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                return;
            }
            string[] fullName = txtFullName.Text.Split(' ');
            string firstName = fullName[fullName.Length - 1];
            string lastName = "";
            for (int i = 0; i < fullName.Length - 1; i++)
            {
                if (i == fullName.Length - 2)
                {
                    lastName += fullName[i];
                }
                else
                {
                    lastName += fullName[i] + " ";
                }
            }
            int gender;
            if (cbbGender.SelectedItem.ToString() == "Nam")
            {
                gender = (int)Gender.MALE;
            }
            else
            {
                gender = (int)Gender.FEMALE;
            }

            Customer c = new Customer(firstName, lastName,
            gender, txtUserName.Text, txtIdentifyCard.Text,
            txtPhoneNumber.Text, (int)Role.CUSTOMER, txtPassword.Text);



            bool inserted = cust.Insert(c);
            if (inserted)
            {
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtFullName.Text = "";
            txtIdentifyCard.Text = "";
            txtPhoneNumber.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

    }
}
