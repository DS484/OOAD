using Hotel_Management.DAO;
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
    public partial class FResetPassWord : Form
    {
        private string? username;

        private UserDAO userDAO = new UserDAO();

        public FResetPassWord(string username)
        {
            InitializeComponent();
            this.username = username;
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                    form.Hide();
            }
            this.TopMost = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Không được để trống mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (userDAO.UpdatePassWord(username!, txtConfirmPass.Text))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int role = userDAO.GetRole(username!);
                if (role == 0)
                {
                    this.Hide();
                    FHome fHome = new FHome(username!);
                    fHome.Show();
                }
                else
                {
                    this.Hide();
                    FHome fHome = new FHome();
                    fHome.Show();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHome fHome = new FHome();
            fHome.Show();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == txtPass.Text)
            {
                pbCheckPass.Image = Properties.Resources.correct;
            }
            else
                pbCheckPass.Image = Properties.Resources.remove;
        }
    }
}
