using Hotel_Management.All_Control;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using Hotel_Management.Service_UC;
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
    public partial class FSelectRoom : Form
    {
        private List<int> ?roomList;
        private int userId;
        private DateTime checkInDate;
        private DateTime checkOutDate;

        private HotelDAO hotelDAO = new HotelDAO();
        private RoomDAO roomDAO = new RoomDAO();
        private RoomDetailDAO roomDetailDAO = new RoomDetailDAO();

        public FSelectRoom()
        {
            InitializeComponent();

        }

        public FSelectRoom(List<int> roomList, int hotelId, int userId, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();
            this.roomList = roomList;
            this.userId = userId;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;

            for (int i = 0; i < roomList.Count; i++)
            {
                DataTable dt = roomDAO.FindRoom(roomList[i], hotelId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    ShowRoom(dt, hotelId, roomList[i]);
                }
            }
        }

        private void ShowRoom(DataTable dt, int hotelId, int roomId)
        {
            UC_SelectRoom uC_SelectRoom = new UC_SelectRoom();
            flpLoadingRoom.Controls.Add(uC_SelectRoom);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
                string imagePath = projectDirectory + @"\" + row[2].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    uC_SelectRoom.pbRoom.ImageLocation = imagePath;
                }
                else
                {
                    uC_SelectRoom.pbRoom.Image = null;
                }
                uC_SelectRoom.lblRoom_Number.Text = "Room " + row[1].ToString();
                uC_SelectRoom.FormatRealPrice(row[3].ToString() + " VND", 13.8f, FontStyle.Bold | FontStyle.Strikeout);
                uC_SelectRoom.FormatSalePrice(row[4].ToString() + " VND", 18f, FontStyle.Bold, Color.FromArgb(255, 128, 0));
                uC_SelectRoom.btnbookRoom.Click += (sender, e) =>
                {
                    BookRoom_Click(sender!, e, userId, Convert.ToInt32(row[0]), uC_SelectRoom.txtVoucher.Texts.Trim(), hotelId);
                };
            }
            uC_SelectRoom.flpService.WrapContents = false;

            string services = roomDetailDAO.GetRoomService(roomId);

            if (services == "")
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Text = "Phòng không có tiện ích nào";
                uC_SelectRoom.flpService.Controls.Add(label);
            }
            else
            {
                string[] service = services.Split(',');

                foreach (string s in service)
                {
                    if (s == "Activity")
                        uC_SelectRoom.flpService.Controls.Add(new UC_Activity());
                    else if (s == "Another")
                        uC_SelectRoom.flpService.Controls.Add(new UC_Another());
                    else if (s == "Healthy")
                        uC_SelectRoom.flpService.Controls.Add(new UC_Healthy());
                    else if (s == "Meal")
                        uC_SelectRoom.flpService.Controls.Add(new uC_Meal());
                }
            }
        }

        private void BookRoom_Click(object sender, EventArgs e, int userId, int roomId, string voucher, int hotelId)
        {
            int checkVoucher = 0;
            DataTable dtVoucher = hotelDAO.CheckVoucher(voucher.Trim(), hotelId);
            if (userId == 0)
            {
                DialogResult res = MessageBox.Show("Vui lòng đăng nhập để đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    FSignIn fSignIn = new FSignIn();
                    fSignIn.ShowDialog();

                }
            }
            else
            {
                if (dtVoucher != null && dtVoucher.Rows.Count > 0)
                {
                    checkVoucher = 1;
                }
                else
                {
                    checkVoucher = 0;
                }
                this.Hide();
                FGuest fGuest = new FGuest(userId, checkInDate, checkOutDate, roomId, checkVoucher);
                fGuest.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
