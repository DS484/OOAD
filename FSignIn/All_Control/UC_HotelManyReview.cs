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

namespace Hotel_Management.All_Control
{
    public partial class UC_HotelManyReview : UserControl
    {
        private Image hotelIcon = Properties.Resources._5_stars;
        private AdminDAO adminDAO = new AdminDAO();

        public UC_HotelManyReview()
        {
            InitializeComponent();
        }

        public void LoadHotelManyReview()
        {
            dgvHotel.DataSource = null;
            dgvHotel.Rows.Clear();
            DataTable dtHotelManyReview = adminDAO.HotelRevenue();
            FillHotelManyReview(dtHotelManyReview);
        }

        public void FillHotelManyReview(DataTable dtHotelManyReview)
        {
            foreach (DataRow row in dtHotelManyReview.Rows)
            {
                dgvHotel.Rows.Add(hotelIcon, row[0], row[1], row[2], row[3], row[4]);
            }

            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHotelManyReview();
            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                if (!row.Cells[2].Value.ToString()!.ToLower().Contains(txtHotelName.Text.ToString().ToLower()))
                    row.Visible = false;
            }
        }
    }
}
