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

namespace Hotel_Management.Properties
{
    public partial class FAddService : Form
    {
        private int hotelId;
        private int roomId;
        private int serviceId;

        ManagerDAO managerDAO = new ManagerDAO();
        RoomDAO roomDAO = new RoomDAO();
        ServiceDAO serviceDAO = new ServiceDAO();

        public FAddService(int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
        }

        public FAddService(string roomNumber, string service, int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            txtRoomNumber.Texts = roomNumber;
            TickSerivce(service);
            txtRoomNumber.ReadOnly = true;
        }

        private void TickSerivce(string service)
        {
            if(service != "Non") {
            string[] services = service.Split(',');

                foreach (string s in services)
                {
                    switch (s.Trim())
                    {
                        case "Activity":
                            cbActivity.Checked = true;
                            break;
                        case "Another":
                            cbAnother.Checked = true;
                            break;
                        case "Healthy":
                            cbHealthy.Checked = true;
                            break;
                        case "Meal":
                            cbMeal.Checked = true;
                            break;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetEnabledComboBoxesNames()
        {
            string service = "";
            if (cbActivity.Checked)
                service += "Activity,";
            if (cbAnother.Checked)
                service += "Another,";
            if (cbHealthy.Checked)
                service += "Healthy,";
            if (cbMeal.Checked)
                service += "Meal,";
            if (service.EndsWith(","))
            {
                service = service.Remove(service.Length - 1);
            }
            if (service == "")
                return "Non";
            return service;
        }

        private void GetInfoService()
        {
            string service = GetEnabledComboBoxesNames();
            roomId = roomDAO.FindRoomByRoomNumber(txtRoomNumber.Texts, hotelId);
            serviceId = serviceDAO.FindService(service);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoService();
                DataTable dtRoom = roomDAO.CheckRoomExist(txtRoomNumber.Texts, hotelId);
                if (dtRoom != null && dtRoom.Rows.Count > 0)
                {
                    MessageBox.Show($"Dịch vụ của phòng '{txtRoomNumber.Texts}' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool inserted = managerDAO.AddService(roomId, serviceId);
                if (inserted)
                {
                    MessageBox.Show("Thêm tiện ích thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra!" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoService();
                bool edited = serviceDAO.EditService(roomId, serviceId);
                if (edited)
                {
                    MessageBox.Show("Sửa tiện ích thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra!" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
