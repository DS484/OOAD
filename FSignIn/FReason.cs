using Hotel_Management.DAO;
using Hotel_Management.DTO;
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
    public partial class FReason : Form
    {
        private int bookingId;
        private string? username;

        private BookingDAO bookingDAO = new BookingDAO();

        public FReason(int bookingId, string username)
        {
            InitializeComponent();
            this.bookingId = bookingId;
            this.username = username;
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            try
            {
                bool deleted = bookingDAO.DeleteBooking(bookingId);
                if (deleted)
                {
                    if (deleted)
                    {
                        MessageBox.Show("Trả phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FHome fHome = new FHome(username!);
                        fHome.ShowDialog();
                        this.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
