using Hotel_Management.DAO;
using Hotel_Management.HandleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hotel_Management.All_Control
{
    public partial class UC_HotelRevenue : UserControl
    {
        private Image payIcon = Properties.Resources.paying;
        private AdminDAO adminDAO = new AdminDAO();
        public UC_HotelRevenue()
        {
            InitializeComponent();
        }

        public void LoadHotelRevenue()
        {
            dgvHotelRevenue.DataSource = null;
            dgvHotelRevenue.Rows.Clear();
            DataTable dtHotelRevenue = adminDAO.GetHotelRevenue();
            FillHotelRevenue(dtHotelRevenue);
        }

        public void FillHotelRevenue(DataTable dtHotelRevenue)
        {
            foreach (DataRow row in dtHotelRevenue.Rows)
            {
                dgvHotelRevenue.Rows.Add(payIcon, row[0], row[1], row[2], row[3], row[4]);
            }

            foreach (DataGridViewRow row in dgvHotelRevenue.Rows)
            {
                row.Height = 50;
            }
        }

        private DataGridView dgv = new DataGridView();

        private void btnChart_Click(object sender, EventArgs e)
        {
            dgv = new DataGridView();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Name";
            dgv.Columns.Add(column2);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "Value";
            dgv.Columns.Add(column5);

            foreach (DataGridViewRow row in dgvHotelRevenue.Rows)
            {
                dgv.Rows.Add(row.Cells[2].Value.ToString(), row.Cells[5].Value.ToString());
            }

            this.Hide();
            FStatistical fStatistical = new FStatistical(dgv);
            fStatistical.ShowDialog();
            this.Visible = true;
        }

        private void RevenueFilter(int start, Int64 end)
        {
            foreach (DataGridViewRow row in dgvHotelRevenue.Rows)
            {
                if (Convert.ToInt32(row.Cells[5].Value) >= start && Convert.ToInt32(row.Cells[5].Value) <= end)
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHotelRevenue();

            if (cbbRevenue.SelectedIndex == 0)
            {
                RevenueFilter(0, 5000000);
            }
            else if (cbbRevenue.SelectedIndex == 1)
            {
                RevenueFilter(5000000, 10000000);
            }
            else if (cbbRevenue.SelectedIndex == 2)
            {
                RevenueFilter(10000000, 50000000);
            }
            else if (cbbRevenue.SelectedIndex == 3)
            {
                RevenueFilter(50000000, 100000000);
            }
            else if (cbbRevenue.SelectedIndex == 4)
            {
                RevenueFilter(100000000, Convert.ToInt64(5L * int.MaxValue));
            }
        }

        private void cbbRevenue_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
