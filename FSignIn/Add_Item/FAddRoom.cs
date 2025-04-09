using Hotel_Management.DAO;
using Hotel_Management.DTO;
using System.Data;

namespace Hotel_Management.Add_Item
{
    public partial class FAddRoom : Form
    {
        private int hotelId;
        private int roomId;
        private string? roomNumber;
        private int adult;
        private int child;
        private string? prePrice;
        private string? currPrice;
        private string? description;
        private DateTime startDay;
        private DateTime endDay;
        private string? img1;
        private string? img2;
        private string? img3;
        private string? img4;
        private string? img5;

        RoomDAO roomDAO = new RoomDAO();
        RoomDetailDAO roomDetailDAO = new RoomDetailDAO();
        ServiceDAO serviceDAO = new ServiceDAO();

        public FAddRoom(int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
        }

        public FAddRoom(int roomId, string roomNumber, int adult, int child, string prePrice,
            string currPrice, string description, DateTime startDay, DateTime endDay, string img1,
            string img2, string img3, string img4, string img5)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomNumber = txtRoomNumber.Texts = roomNumber;
            txtRoomNumber.ReadOnly = true;
            this.adult = adult;
            cbbAdult.SelectedItem = adult.ToString();
            this.child = child;
            cbbChild.SelectedItem = child.ToString();
            this.prePrice = txtOldPrice.Texts = prePrice;
            this.currPrice = txtNewPrice.Texts = currPrice;
            this.description = txtDescription.Texts = description;
            this.startDay = dtpStart_Date.Value = startDay;
            this.endDay = dtpEnd_Date.Value = endDay;
            this.img1 = txtImg1.PlaceholderText = img1;
            this.img2 = txtImg2.PlaceholderText = img2;
            this.img3 = txtImg3.PlaceholderText = img3;
            this.img4 = txtImg4.PlaceholderText = img4;
            this.img5 = txtImg5.PlaceholderText = img5;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

        }

        public string getLinkImage()
        {
            string imageLocation = "";
            string linkImage = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    string imageName = Path.GetFileName(imageLocation);
                    linkImage = Path.Combine("Image", imageName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return linkImage;
        }

        private void btnPic1_Click(object sender, EventArgs e)
        {

        }

        private void btnPic2_Click(object sender, EventArgs e)
        {

        }

        private void btnPic3_Click(object sender, EventArgs e)
        {

        }

        private void btnPic4_Click(object sender, EventArgs e)
        {

        }

        private void btnPic5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPic1_Click_1(object sender, EventArgs e)
        {
            txtImg1.PlaceholderText = getLinkImage();
        }

        private void btnPic2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPic3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPic4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPic5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditRoom_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPic2_Click_2(object sender, EventArgs e)
        {
            txtImg2.PlaceholderText = getLinkImage();
        }

        private void btnPic3_Click_2(object sender, EventArgs e)
        {
            txtImg3.PlaceholderText = getLinkImage();
        }

        private void btnPic4_Click_2(object sender, EventArgs e)
        {
            txtImg4.PlaceholderText = getLinkImage();
        }

        private void btnPic5_Click_2(object sender, EventArgs e)
        {
            txtImg5.PlaceholderText = getLinkImage();
        }

        private void btnAddRoom_Click_2(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room(txtRoomNumber.Texts, txtImg2.PlaceholderText,
                Convert.ToInt32(txtOldPrice.Texts), Convert.ToInt32(txtNewPrice.Texts),
                txtDescription.Texts, hotelId);

                RoomDetail roomDetail = new RoomDetail(txtImg1.PlaceholderText,
                txtImg2.PlaceholderText, txtImg3.PlaceholderText, txtImg4.PlaceholderText,
                txtImg5.PlaceholderText, Convert.ToInt32(cbbAdult.SelectedItem), Convert.ToInt32(cbbChild.SelectedItem),
                Convert.ToDateTime(dtpStart_Date.Value), Convert.ToDateTime(dtpEnd_Date.Value));

                DataTable dtRoom = roomDAO.CheckRoomExist(txtRoomNumber.Texts, hotelId);
                if (dtRoom != null && dtRoom.Rows.Count > 0)
                {
                    MessageBox.Show($"Phòng '{txtRoomNumber.Texts}' đã tồn tại trong khách sạn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                roomDAO.InsertRoom(room);
                roomDetailDAO.InsertRoomDetail(roomDetail);
                room.Id = roomDAO.FindRoomByRoomNumber(txtRoomNumber.Texts, hotelId);
                serviceDAO.AddService(room.Id, 17);
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Thêm phòng thất bại!!!" + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditRoom_Click_2(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room(roomId, txtRoomNumber.Texts, img1!, Convert.ToInt32(txtOldPrice.Texts), Convert.ToInt32(txtNewPrice.Texts), txtDescription.Texts);
                RoomDetail roomDetail = new RoomDetail(roomId, txtImg1.PlaceholderText, txtImg2.PlaceholderText, txtImg3.PlaceholderText, txtImg4.PlaceholderText, txtImg5.PlaceholderText, Convert.ToInt32(cbbAdult.SelectedItem), Convert.ToInt32(cbbChild.SelectedItem), dtpStart_Date.Value, dtpEnd_Date.Value);
                bool editedRoom = roomDAO.EditRoom(room);
                bool editedRoomDetail = roomDetailDAO.EditRoomDetail(roomDetail);
                if (editedRoom && editedRoomDetail)
                {
                    MessageBox.Show("Sửa thông tin hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa phòng thất bại!" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
