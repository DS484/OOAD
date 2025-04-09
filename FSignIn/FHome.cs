using Hotel_Management.Add_Item;
using Hotel_Management.DAO;
using System.Data;

namespace Hotel_Management
{
    public partial class FHome : Form
    {
        private int userId = 0;
        private bool isMenuVisible = true;
        private FMenu? menuForm;

        private CustomerDAO customerDAO = new CustomerDAO();

        public FHome()
        {
            InitializeComponent();
        }
        public FHome(string nameLogged)
        {
            InitializeComponent();
            btnLogin.Visible = false;
            btnLogged.Text = nameLogged;
            btnLogged.BringToFront();
            userId = customerDAO.FindId(nameLogged);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int imageNumber = 1;
        private void LoadNeztImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private bool isImageVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNeztImage();
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblPanel.ForeColor = Color.FromArgb(one, two, three, four);

        }

        bool expand = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                cbbDropDownContainer.Height += 15;
                if (cbbDropDownContainer.Height >= cbbDropDownContainer.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand = true;
                }
            }
            else
            {
                cbbDropDownContainer.Height -= 15;
                if (cbbDropDownContainer.Height <= cbbDropDownContainer.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand = false;
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn fSignIn = new FSignIn();
            fSignIn.ShowDialog();
        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isImageVisible)
            {
                PicFlashingLogo.Visible = false;
            }
            else
            {
                PicFlashingLogo.Visible = true;
            }
            isImageVisible = !isImageVisible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = customerDAO.SearchHotel(txtCity.Text, Convert.ToInt32(nudAdult.Value),
                Convert.ToInt32(nudChildren.Value),
                Convert.ToDateTime(dtpCheckInDate.Value), Convert.ToDateTime(dtpCheckOutDate.Value));

            List<int> listHotel = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                listHotel.Add(Convert.ToInt32(dr[0]));
            }
            try
            {
                this.Hide();
                FFindRoom fFindRoom = new FFindRoom(listHotel, userId, txtCity.Text,
                    Convert.ToInt32(nudAdult.Value), Convert.ToInt32(nudChildren.Value), Convert.ToDateTime(dtpCheckInDate.Value),
                    Convert.ToDateTime(dtpCheckOutDate.Value));
                fFindRoom.ShowDialog();
                this.Visible = true;
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            int adults = (int)nudAdult.Value;
            int children = (int)nudChildren.Value;


            txtItem.Text = string.Format("{0} người lớn, {1} trẻ em", adults, children);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text != "Đăng nhập")
            {
                MessageBox.Show("Vui lòng đăng nhập để xem lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                FHistory fHistory = new FHistory(userId);
                fHistory.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnLogged.Text == "")
            {
                MessageBox.Show("Vui lòng đăng nhập để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (isMenuVisible)
                {

                    menuForm = new FMenu(userId);
                    menuForm.StartPosition = FormStartPosition.Manual;
                    menuForm.SetLocation(btnMenu.Location.X - 1, btnMenu.Location.Y + 180);
                    menuForm.Show();
                    isMenuVisible = false;
                }
                else
                {
                    menuForm!.Close();
                    isMenuVisible = true;
                }
            }

        }
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1);
                MessageBox.Show(this, "Ngày trả phòng phải lớn hơn ngày nhận phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckInDate.Value = dtpCheckOutDate.Value.AddDays(-1);
                MessageBox.Show(this, "Ngày nhận phòng phải nhỏ hơn ngày trả phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterHotel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fSignUp = new FSignUp();
            fSignUp.ShowDialog();
        }

        private void nudAdult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void nudChildren_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            //string filePathClient = @"D:\23-24\Lập trình Win\Final_ProJ\Client\bin\Debug\Client.exe";

            //string filePathServer = @"D:\23-24\Lập trình Win\Final_ProJ\Server\bin\Debug\Server.exe";

            string filePathClient = @"D:\Project Đại Học\LapTrinhWin\Final_ProJ\Client\bin\Debug\Client.exe";
            string filePathServer = @"D:\Project Đại Học\LapTrinhWin\Final_ProJ\Server\bin\Debug\Server.exe";
            this.Hide();
            System.Diagnostics.Process clientProcess = System.Diagnostics.Process.Start(filePathClient);
            System.Diagnostics.Process serverProcess = System.Diagnostics.Process.Start(filePathServer);

            clientProcess.WaitForExit();
            serverProcess.WaitForExit();

            this.Show();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            this.Hide();
            FChatAI fChatAI = new FChatAI();
            fChatAI.ShowDialog();
            this.Visible = true;
        }
    }
}
