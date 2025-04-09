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
    public partial class FGuest : Form
    {
        private int userId;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int voucher;
        private string? username;
        private string? roomNumber;
        private int? hotelId;
        private long? totalBill;

        private AdminDAO adminDAO = new AdminDAO();
        private CustomerDAO customerDAO = new CustomerDAO();
        private BookingDAO bookingDAO = new BookingDAO();
        private RoomDAO roomDAO = new RoomDAO();

        private int roomId;

        public FGuest()
        {
            InitializeComponent();
        }

        public FGuest(int userId, DateTime checkInDate, DateTime checkOutDate, int roomId, int voucher)
        {
            InitializeComponent();
            this.userId = userId;
            this.roomId = roomId;
            this.voucher = voucher;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.dtpCheckInDate.Value = checkInDate;
            this.dtpCheckOutDate.Value = checkOutDate;
            FillUserInfomation(userId, roomId);
        }

        public void FillUserInfomation(int userId, int roomId)
        {
            DataTable dtUser = customerDAO.UserInfomation(userId);
            DataTable dtRoom = roomDAO.InfoRoom(roomId);
            if (dtUser != null)
            {
                DataRow row = dtUser.Rows[0];
                username = row[5].ToString();
                txtFullName.PlaceholderText = row[3].ToString() + " " + row[2].ToString();
                txtIdentifyCard.PlaceholderText = row[6].ToString()!;
                txtPhoneNumber.PlaceholderText = row[7].ToString()!;
                cbbGender.Texts = (Convert.ToUInt32(row[4]) == 0) ? "Nam" : "Nữ";
            }

            TimeSpan rentalDay = checkOutDate - checkInDate;
            int numberOfDays = rentalDay.Days;

            if (dtRoom != null)
            {
                DataRow row = dtRoom.Rows[0];
                roomNumber = row[1].ToString();
                int ta = int.Parse(row[4].ToString()!);
                lblRoomDescription.Text = row[5].ToString();
                if (voucher == 1)
                    ta = int.Parse(row[4].ToString()!) - 99999;
                hotelId = Convert.ToInt32(row[6]);
                totalBill = ta * numberOfDays;
                lblRoomPrice.Text = "Tổng số tiền phải thanh toán: " + (ta * numberOfDays).ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            object[] objects = { username!, txtFullName.PlaceholderText, txtIdentifyCard.PlaceholderText, txtPhoneNumber.PlaceholderText, cbbGender.Texts,
            roomNumber!, checkInDate, checkOutDate, hotelId!, totalBill!, voucher};
            bookingDAO.CreateBooking(checkInDate, checkOutDate, roomId, userId, voucher);
            adminDAO.Insert(objects);

            MessageBox.Show("Đặt phòng thành công.");

            this.Hide();
            FHome fHome = new FHome(username!);
            fHome.ShowDialog();
            this.Visible = true;
        }

        private void btnPayWithQR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPayWithQRCode fPayWithQRCode = new FPayWithQRCode(totalBill, roomNumber!);
            fPayWithQRCode.ShowDialog();
            this.Visible = true;
        }
    }
}
