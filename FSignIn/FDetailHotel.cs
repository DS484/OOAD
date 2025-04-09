using Hotel_Management.All_Control;
using Hotel_Management.DAO;
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
    public partial class FDetailHotel : Form
    {
        private int roomId;
        private int hotelId;

        private RoomDetailDAO roomDetailDAO = new RoomDetailDAO();
        private HotelDAO hotelDAO = new HotelDAO();

        public FDetailHotel()
        {
            InitializeComponent();
        }

        public FDetailHotel(int roomId, int hotelId)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.hotelId = hotelId;
            ShowDetail();

        }

        private void ShowDetail()
        {
            DataTable dt = roomDetailDAO.RoomInfo(roomId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
                string image1 = projectDirectory + @"\" + row[1].ToString();
                string image2 = projectDirectory + @"\" + row[2].ToString();
                string image3 = projectDirectory + @"\" + row[3].ToString();
                string image4 = projectDirectory + @"\" + row[4].ToString();
                string image5 = projectDirectory + @"\" + row[5].ToString();

                pb1.ImageLocation = image1;
                pb2.ImageLocation = image2;
                pb3.ImageLocation = image3;
                pb4.ImageLocation = image4;
                pb5.ImageLocation = image5;

                lblNameHotel.Text = row[6].ToString();

                lblReview.Text = row[7].ToString();
            }

            flpService.Controls.Add(new UC_Activity());
            flpService.Controls.Add(new UC_Another());
            flpService.Controls.Add(new UC_Healthy());
            flpService.Controls.Add(new uC_Meal());


            DataTable dtReview = hotelDAO.SeeReview(hotelId);
            if (dtReview == null || dtReview.Rows.Count == 0)
            {
                Label lblNoReviews = new Label();
                lblNoReviews.Text = "Hiện tại chưa có đánh giá nào cho khách sạn này!";
                lblNoReviews.AutoSize = true;
                lblNoReviews.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblNoReviews.Anchor = AnchorStyles.None;
                flpReview.Controls.Add(lblNoReviews);
            }
            else
            {
                for (int i = 0; i < dtReview.Rows.Count; i++)
                {
                    UC_Review uC_Review = new UC_Review();
                    flpReview.Controls.Add(uC_Review);

                    DataRow row = dtReview.Rows[i];
                    uC_Review.lblUserName.Text = row[0].ToString();
                    uC_Review.lblStar.Text = row[1].ToString();
                    uC_Review.lblComment.Text = row[2].ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
