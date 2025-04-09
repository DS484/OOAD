using Hotel_Management.DAO;
using Hotel_Management.DTO;
using Hotel_Management.Properties;
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
    public partial class UC_Service : UserControl
    {
        private string? username;
        private Image serviceIcon = Properties.Resources.customer_service;
        private Image editIcon = Properties.Resources.edit;
        private Image deleteIcon = Properties.Resources.remove;

        ManagerDAO managerDAO = new ManagerDAO();
        ServiceDAO serviceDAO = new ServiceDAO();
        RoomDAO roomDAO = new RoomDAO();

        public UC_Service()
        {
            InitializeComponent();
        }

        public void TransmitUserName(string username)
        {
            this.username = username;
        }

        public void LoadService()
        {
            dgvService.DataSource = null;
            dgvService.Rows.Clear();
            DataTable dtService = managerDAO.ManageService(username!);
            FillServiceData(dtService);
        }

        public void FillServiceData(DataTable dtService)
        {
            foreach (DataRow row in dtService.Rows)
            {
                dgvService.Rows.Add(serviceIcon, row[0], row[1], row[2], editIcon, deleteIcon, row[3]);
            }

            foreach (DataGridViewRow row in dgvService.Rows)
            {
                row.Height = 50;
            }

            dgvService.Columns[6].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadService();
            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.Cells[2].Value.ToString() != txtSearchService.Text)
                    row.Visible = false;
            }
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                if (x == 4)
                {
                    DataGridViewRow row = dgvService.Rows[y];
                    string roomNumber = row.Cells[1].Value.ToString()!;
                    string service = row.Cells[3].Value.ToString()!;
                    int hotelId = Convert.ToInt32(row.Cells[6].Value!);
                    this.Hide();
                    FAddService fAddService = new FAddService(roomNumber, service, hotelId);
                    fAddService.ShowDialog();
                    this.Visible = true;
                }

                if (x == 5)
                {
                    bool deleteService = false;
                    DataGridViewRow row = dgvService.Rows[y];
                    int roomId = roomDAO.FindRoomByRoomNumber(row.Cells[1].Value.ToString()!, Convert.ToInt32(row.Cells[6].Value!));
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tiện ích phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        deleteService = serviceDAO.DeleteService(roomId);
                    if (deleteService)
                    {
                        MessageBox.Show("Xóa tiện ích phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadService();
                    }
                }
            }
        }
    }
}
