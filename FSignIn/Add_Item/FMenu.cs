using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.Add_Item
{
    public partial class FMenu : Form
    {
        private int usedId = 0;
        public Point PreviousLocation { get; set; }
        public FMenu()
        {
            InitializeComponent();
        }
        public FMenu(int usedId)
        {
            InitializeComponent();
            this.usedId = usedId;

        }

        public void SetLocation(int x, int y)
        {
            PreviousLocation = new Point(x, y);
            this.Location = PreviousLocation;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            FHistory fHistory = new FHistory(usedId);
            fHistory.ShowDialog();
        }

        private void btnRegisterHotel_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            FSignUp fSignUp = new FSignUp();
            fSignUp.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Đã đăng xuất", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FHome f = new FHome();
            f.ShowDialog();
        }
    }
}
