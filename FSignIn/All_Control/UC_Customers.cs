using Hotel_Management.DAO;
using Hotel_Management.HandleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.All_Control
{
    public partial class UC_Customers : UserControl
    {
        private int hotelId;
        private Image userIcon = Properties.Resources.user;

        ManagerDAO managerDAO = new ManagerDAO();
        FormatData formatData = new FormatData();

        public UC_Customers()
        {
            InitializeComponent();
        }

        public void TransmitHotelID(int hotelId)
        {
            this.hotelId = hotelId;
        }

        public void LoadCustomer()
        {
            dgvInfoCustomer.DataSource = null;
            dgvInfoCustomer.Rows.Clear();
            DataTable dtCustomer = managerDAO.MyCustomer(hotelId);
            FillCustomerData(dtCustomer);
        }

        public void FillCustomerData(DataTable dtCustomer)
        {
            foreach (DataRow row in dtCustomer.Rows)
            {
                string checkinDate = formatData.ConvertDate(Convert.ToDateTime(row[5]));
                string checkoutDate = formatData.ConvertDate(Convert.ToDateTime(row[6]));
                dgvInfoCustomer.Rows.Add(userIcon, row[0], row[1], row[2], row[3], row[4], checkinDate, checkoutDate);
            }

            foreach (DataGridViewRow row in dgvInfoCustomer.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomer();
            foreach (DataGridViewRow row in dgvInfoCustomer.Rows)
            {
                if (Convert.ToDateTime(row.Cells[6].Value) >= Convert.ToDateTime(dtpCheckIn.Value) && Convert.ToDateTime(row.Cells[7].Value) <= Convert.ToDateTime(dtpCheckOut.Value))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void CheckDate()
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value;
                MessageBox.Show(this, "Ngày trả phòng phải lớn hơn hoặc bằng ngày nhận phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            CheckDate();
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            CheckDate();
        }
    }
}
