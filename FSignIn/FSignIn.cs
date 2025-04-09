//using Hotel_Management;

using Hotel_Management.All_Control;
using Hotel_Management.Constants;
using Hotel_Management.DAO;
using Hotel_Management.DTO;

namespace Hotel_Management
{
    public partial class FSignIn : Form
    {
        private UserDAO userDAO = new UserDAO();

        public FSignIn()
        {
            InitializeComponent();

            uC_Login1.btnForgetPass.Click += btnForgetPass!;
            uC_Login1.btnLogin.Click += btnLogin!;
            uC_Login1.btnSignUp.Click += btnSignUp!;

            uC_SignUp1.btnExitAcc.Click += btnExitAcc!;

            uC_FogetPasswork1.btnExitForget.Click += btnExitForget!;
        }

        private void BtnLoginBack_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp signup = new FSignUp();
            signup.Show();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            string[] lst = { uC_Login1.txtUsername.Text, uC_Login1.txtPassword.Text };
            foreach (string s in lst)
            {
                if (string.IsNullOrEmpty(s))
                {
                    MessageBox.Show("Hãy điền thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            User user = new User();
            bool logined = user.VerifyPassword(uC_Login1.txtUsername.Text, uC_Login1.txtPassword.Text);
            if (logined)
            {
                int role = GetRole(uC_Login1.txtUsername.Text);
                if (role == 0)
                {
                    this.Hide();
                    FHome fHome = new FHome(uC_Login1.txtUsername.Text);
                    fHome.ShowDialog();
                }
                else if (role == 2)
                {
                    this.Hide();
                    FManager fManager = new FManager(uC_Login1.txtUsername.Text);
                    fManager.ShowDialog();
                }
                else if (role == 1)
                {
                    this.Hide();
                    FAdmin fAdmin = new FAdmin(uC_Login1.txtUsername.Text);
                    fAdmin.ShowDialog();
                }

                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*uC_Login1.txtUsername.Text = "";
                uC_Login1.txtPassword.Text = "";*/
            }
        }

        private int GetRole(string username)
        {
            return userDAO.GetRole(username);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp(object sender, EventArgs e)
        {
            uC_Login1.Visible = false;
            uC_FogetPasswork1.Visible = false;
            uC_Shape1.Visible = false;
            uC_SignUp1.Visible = true;
            uC_Login1.BringToFront();
        }
        private void btnForgetPass(object sender, EventArgs e)
        {
            uC_SignUp1.Visible = false;
            uC_Login1.Visible = false;
            uC_Shape1.Visible = true;
            uC_Shape1.BringToFront();
            uC_FogetPasswork1.Visible = true;
            uC_FogetPasswork1.BringToFront();
        }
        private void btnLoginBack(object sender, EventArgs e)
        {
            uC_SignUp1.Visible = false;
            uC_FogetPasswork1.Visible = false;
            uC_Shape1.Visible = true;
            uC_Shape1.BringToFront();
            uC_Login1.Visible = true;
            uC_Login1.BringToFront();
        }

        private void FSignIn_Load(object sender, EventArgs e)
        {
            uC_Login1.lblError.Visible = false;
            uC_SignUp1.Visible = false;
            uC_FogetPasswork1.Visible = false;
            uC_Shape1.Visible = true;
            uC_Shape1.BringToFront();
            uC_Login1.Visible = true;
            uC_Login1.BringToFront();
        }

        private void btnExitAcc(object sender, EventArgs e)
        {
            uC_FogetPasswork1.Visible = false;
            uC_SignUp1.Visible = false;
            uC_Shape1.Visible = true;
            uC_Shape1.BringToFront();
            uC_Login1.Visible = true;
            uC_Login1.BringToFront();
        }
        private void btnExitForget(object sender, EventArgs e)
        {
            uC_FogetPasswork1.Visible = false;
            uC_SignUp1.Visible = false;
            uC_Shape1.Visible = true;
            uC_Shape1.BringToFront();
            uC_Login1.Visible = true;
            uC_Login1.BringToFront();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FHome f = new FHome();
            f.Show();
        }
    }
}
