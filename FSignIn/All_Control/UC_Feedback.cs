using Hotel_Management.DAO;
using Hotel_Management.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.All_Control
{
    public partial class UC_Feedback : UserControl
    {
        private int hotelId;
        private Image feedBackIcon = Properties.Resources.feedback;

        ManagerDAO managerDAO = new ManagerDAO();

        public UC_Feedback()
        {
            InitializeComponent();
        }

        public void TransmitHotelID(int hotelId)
        {
            this.hotelId = hotelId;
        }

        public void LoadFeedBack()
        {
            dgvFeedBack.DataSource = null;
            dgvFeedBack.Rows.Clear();
            DataTable dtFeedBack = managerDAO.ManageFeedBack(hotelId);
            FillFeedBack(dtFeedBack);
        }

        public void FillFeedBack(DataTable dtFeedBack)
        {
            foreach (DataRow row in dtFeedBack.Rows)
            {
                dgvFeedBack.Rows.Add(feedBackIcon, row[0], row[1], row[2], row[3], row[4]);
            }
            foreach (DataGridViewRow row in dgvFeedBack.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnSearchFeedBack_Click(object sender, EventArgs e)
        {
            LoadFeedBack();
            foreach (DataGridViewRow row in dgvFeedBack.Rows)
            {
                if (row.Cells[1].Value.ToString() != txtSearchFeedBack.Text)
                    row.Visible = false;
            }
        }
    }
}
