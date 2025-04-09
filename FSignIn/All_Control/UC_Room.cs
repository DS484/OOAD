using Hotel_Management.Add_Item;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using Hotel_Management.HandleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hotel_Management.All_Control
{
    public partial class UC_Room : UserControl
    {
        private string? username;
        private Image roomIcon = Properties.Resources.room;
        private Image editIcon = Properties.Resources.edit;
        private Image deleteIcon = Properties.Resources.remove;

        GenericCode genericCode = new GenericCode();
        ManagerDAO managerDAO = new ManagerDAO();
        RoomDAO roomDAO = new RoomDAO();

        FormatData formatData = new FormatData();

        public UC_Room()
        {
            InitializeComponent();
        }

        public void TransmitUserName(string username)
        {
            this.username = username;
        }

        public void LoadRoom()
        {
            dgvRoom.DataSource = null;
            dgvRoom.Rows.Clear();
            DataTable dtRoom = managerDAO.ManageRoom(username!);
            FillRoomData(dtRoom);
        }

        public void FillRoomData(DataTable dtRoom)
        {
            foreach (DataRow row in dtRoom.Rows)
            {
                string startDate = formatData.ConvertDate(Convert.ToDateTime(row[6]));
                string endDate = formatData.ConvertDate(Convert.ToDateTime(row[7]));
                dgvRoom.Rows.Add(roomIcon, row[0], row[1], row[2], row[3], row[4], row[5], startDate, endDate, editIcon, deleteIcon, row[8], row[9], row[10], row[11], row[12], row[13]);
            }

            dgvRoom.Columns[11].Visible = false;
            dgvRoom.Columns[12].Visible = false;
            dgvRoom.Columns[13].Visible = false;
            dgvRoom.Columns[14].Visible = false;
            dgvRoom.Columns[15].Visible = false;
            dgvRoom.Columns[16].Visible = false;

            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRoom();
            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                if (row.Cells[1].Value.ToString() != txtSearchRoom.Text)
                    row.Visible = false;
            }
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valid");
        }

        private void dgvRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                if (x == 9)
                {
                    DataGridViewRow row = dgvRoom.Rows[y];

                    int roomId = Convert.ToInt32(row.Cells[16].Value.ToString());
                    string roomNumber = row.Cells[1].Value.ToString()!;
                    int adult = Convert.ToInt32(row.Cells[2].Value);
                    int child = Convert.ToInt32(row.Cells[3].Value);
                    string prePrice = row.Cells[4].Value.ToString()!;
                    string currPrice = row.Cells[5].Value.ToString()!;
                    string description = row.Cells[6].Value.ToString()!;
                    DateTime startDay = Convert.ToDateTime(row.Cells[7].Value);
                    DateTime endDay = Convert.ToDateTime(row.Cells[8].Value);
                    string img1 = row.Cells[11].Value.ToString()!;
                    string img2 = row.Cells[12].Value.ToString()!;
                    string img3 = row.Cells[13].Value.ToString()!;
                    string img4 = row.Cells[14].Value.ToString()!;
                    string img5 = row.Cells[15].Value.ToString()!;

                    this.Hide();
                    FAddRoom fAddRoom = new FAddRoom(roomId, roomNumber, adult, child, prePrice,
                        currPrice, description, startDay, endDay, img1, img2, img3, img4, img5);
                    fAddRoom.ShowDialog();
                    this.Visible = true;
                }

                if (x == 10)
                {
                    bool deleteRoom = false;
                    DataGridViewRow row = dgvRoom.Rows[y];
                    int roomId = Convert.ToInt32(row.Cells[16].Value.ToString());
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        deleteRoom = roomDAO.DeleteRoom(roomId);
                    if (deleteRoom)
                    {
                        MessageBox.Show("Xóa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoom();
                    }
                }
            }
        }
    }
}
