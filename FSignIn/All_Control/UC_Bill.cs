using Hotel_Management.DAO;
using Hotel_Management.DTO;
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
    public partial class UC_Bill : UserControl
    {
        private int hotelId;
        private Image billIcon = Properties.Resources.bill;

        ManagerDAO managerDAO = new ManagerDAO();

        public UC_Bill()
        {
            InitializeComponent();
        }

        public void TransmitHotelID(int hotelId)
        {
            this.hotelId = hotelId;
        }

        public void LoadBill()
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            DataTable dtBill = managerDAO.HotelBill(hotelId);
            FillBillData(dtBill);
        }

        public void FillBillData(DataTable dtBill)
        {
            string voucher = "";
            foreach (DataRow row in dtBill.Rows)
            {
                if (Convert.ToInt32(row[6]) == 1)
                {
                    voucher = "Có sử dụng mã giảm giá";
                }
                else
                {
                    voucher = "Không sử dụng mã giảm giá";
                }
                dgvBill.Rows.Add(billIcon, row[0], row[1], row[2], row[3], voucher, row[4], row[5]);
            }

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBill();
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (Convert.ToDateTime(row.Cells[6].Value) < dtpStartDay.Value)
                    row.Visible = false;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();

            DataGridViewTextBoxColumn monthColumn = new DataGridViewTextBoxColumn();
            monthColumn.HeaderText = "Tháng";
            dgv.Columns.Add(monthColumn);

            DataGridViewTextBoxColumn revenueColumn = new DataGridViewTextBoxColumn();
            monthColumn.HeaderText = "Doanh thu";
            dgv.Columns.Add(revenueColumn);

            long sum = 0;
            int cntMonth = 1;
            string[] months = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            int[] revenue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach(string month in months)
            {
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    if (Convert.ToDateTime(row.Cells[6].Value).Month == cntMonth)
                        sum += int.Parse(row.Cells[4].Value.ToString()!);
                }
                dgv.Rows.Add(month, sum);
                cntMonth++;
                sum = 0;
            }

            this.Hide();
            FStatistical fStatistical = new FStatistical(dgv);
            fStatistical.ShowDialog();
            this.Visible = true;
        }
    }
}
