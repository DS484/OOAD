using Hotel_Management.All_Control;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FHistory : Form
    {
        private int usedId;
        private string ?username;

        private CustomerDAO customerDAO = new CustomerDAO();
        private BookingDAO bookingDAO = new BookingDAO();
        private UC_History ?uC_History;

        public FHistory(int userId)
        {
            InitializeComponent();
            this.usedId = userId;

            username = customerDAO.GetUserName(userId);

            UserHistory();
        }

        public void UserHistory()
        {
            DataTable dt = customerDAO.CheckHistory(usedId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                uC_History = new UC_History();
                flpHistory.Controls.Add(uC_History);

                DataRow row = dt.Rows[i];
                username = row[8].ToString()!;
                uC_History.lblHotel.Text = row[5].ToString();
                uC_History.lblRoomName.Text = row[2].ToString();
                uC_History.lblCheckInDate.Text = Convert.ToDateTime(row[3]).ToString("dd/MM/yyyy");
                uC_History.lblCheckOutDate.Text = Convert.ToDateTime(row[4]).ToString("dd/MM/yyyy");
                lblUserName.Text = "Xin chào, " + row[7].ToString() + " " + row[6].ToString();

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
                string hotelImage = projectDirectory + @"\" + row[9].ToString();
                uC_History.pbHotel.ImageLocation = hotelImage;

                int bookingId = Convert.ToInt32(row[10].ToString());
                uC_History.btnCheckOut.Click += (sender, e) =>
                {
                    CheckOut_Click(sender!, e, bookingId, usedId, Convert.ToInt32(row[1]));
                };

                uC_History.btnCancelRoom.Click += (sender, e) =>
                {
                    CancelRoom_Click(sender!, e, bookingId);
                };
            }
        }

        private void CancelRoom_Click(object sender, EventArgs e, int bookingId)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                this.Hide();
                FReason fReason = new FReason(bookingId, username!);
                fReason.ShowDialog();
            }
        }

        private void CheckOut_Click(object sender, EventArgs e, int bookingId, int userId, int hotelId)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn trả phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                bool deleted = bookingDAO.DeleteBooking(bookingId);
                if(deleted)
                {
                    MessageBox.Show("Trả phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FFeedBack fFeedBack = new FFeedBack(userId, hotelId);
                    fFeedBack.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Trả phòng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FHome fHome = new FHome(username!);
            fHome.ShowDialog();
            this.Visible = true;
        }
    }
}
