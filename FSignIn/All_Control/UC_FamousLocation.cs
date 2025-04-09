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
    public partial class UC_FamousLocation : UserControl
    {
        private Image icon = Properties.Resources.map;
        private AdminDAO adminDAO = new AdminDAO();
        public UC_FamousLocation()
        {
            InitializeComponent();
        }

        public void LoadFamousLocation()
        {
            dgvHotel.DataSource = null;
            dgvHotel.Rows.Clear();
            DataTable dtLocation = adminDAO.GetFamousLocation();
            FillFamousLocation(dtLocation);
        }

        public void FillFamousLocation(DataTable dtLocation)
        {
            foreach (DataRow row in dtLocation.Rows)
            {
                dgvHotel.Rows.Add(icon, row[0], row[1], row[2]);
            }

            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFamousLocation();
            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                if (row.Cells[2].Value.ToString() != cbbCity.SelectedItem.ToString())
                    row.Visible = false;
            }

        }
    }
}
