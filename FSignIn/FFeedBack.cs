using Hotel_Management.DAO;
using System.Data;

namespace Hotel_Management
{
    public partial class FFeedBack : Form
    {
        private int userId;
        private int hotelId;
        private HotelDAO hotelDAO = new HotelDAO();
        private CustomerDAO customerDAO = new CustomerDAO();
        private FeedBackDAO feedBackDAO = new FeedBackDAO();
        
        public FFeedBack(int userId, int hotelId)
        {
            InitializeComponent();
            this.userId = userId;
            this.hotelId = hotelId;
            FillInfo();
        }

        public void FillInfo()
        {
            DataTable dtHotel = hotelDAO.InfoHotel(hotelId);
            DataTable dtCustomer = customerDAO.UserInfomation(userId);

            for (int i = 0; i < dtHotel.Rows.Count; i++)
            {
                DataRow row = dtHotel.Rows[i];
                lblHotel.Text = row[1].ToString();
            }

            for (int i = 0; i < dtCustomer.Rows.Count; i++)
            {
                DataRow row = dtCustomer.Rows[i];
                lblHi.Text = "Xin chào, " + row[3].ToString() + " " + row[2].ToString();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            bool check = feedBackDAO.InsertFeecBack(Convert.ToInt32(rsStar.Value), txtFeedBack.Text, userId, hotelId);
            if (check)
            {
                MessageBox.Show("Đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi, không thể thêm dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
