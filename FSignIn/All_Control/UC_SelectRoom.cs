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
    public partial class UC_SelectRoom : UserControl
    {
        public UC_SelectRoom()
        {
            InitializeComponent();
        }

        public void FormatRealPrice(string text, float fontSize, FontStyle fontStyle)
        {
            Font font = new Font("Nirmala UI", fontSize, fontStyle);
            lblRealPrice.Text = text;
            lblRealPrice.Font = font;
        }

        public void FormatSalePrice(string text, float fontSize, FontStyle fontStyle, Color fontColor)
        {
            Font font = new Font("Nirmala UI", fontSize, fontStyle);

            lblSalePrice.Text = text;
            lblSalePrice.Font = font;
            lblSalePrice.ForeColor = fontColor;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc sẽ dùng mã giảm giá này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                txtVoucher.ReadOnly = true;
            }
        }
    }
}
