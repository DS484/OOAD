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

namespace Hotel_Management.All_Control
{
    public partial class UC_VIPCustomer : UserControl
    {
        private Image vipIcon = Properties.Resources.vip;
        private AdminDAO adminDAO = new AdminDAO();

        public UC_VIPCustomer()
        {
            InitializeComponent();
        }

        public void LoadVIPCustomer()
        {
            dgvVIPCustomer.DataSource = null;
            dgvVIPCustomer.Rows.Clear();
            DataTable dtVIPCustomer = adminDAO.VIPCustomer();
            FillVIPCustomer(dtVIPCustomer);
        }

        public void FillVIPCustomer(DataTable dtVIPCustomer)
        {
            foreach (DataRow row in dtVIPCustomer.Rows)
            {
                string name = row[2].ToString() + " " + row[1].ToString();
                string gender = Convert.ToInt32(row[4]) == 0 ? "Nam" : "Nữ"; 
                dgvVIPCustomer.Rows.Add(vipIcon, row[0], name, row[3], gender, row[5]);
            }

            foreach (DataGridViewRow row in dgvVIPCustomer.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadVIPCustomer();
            foreach (DataGridViewRow row in dgvVIPCustomer.Rows)
            {
                if (row.Cells[1].Value.ToString() != txtUserName.Text.ToString())
                    row.Visible = false;
            }
        }
    }
}
