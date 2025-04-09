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
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_Management.All_Control
{
    public partial class UC_AvtRoom : UserControl
    {


        public UC_AvtRoom()
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

    }
}
