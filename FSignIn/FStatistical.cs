using Guna.Charts.WinForms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;

using System;
using System.Linq;
using System.Windows;
using Guna.Charts.Interfaces;
using System.Security.Cryptography;

namespace Hotel_Management
{
    public partial class FStatistical : Form
    {
        private string selected = "";
        private DataGridView dgv;

        public FStatistical(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;

        }

        private DataTable AssignData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Value", typeof(int));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    dataTable.Rows.Add(row.Cells[0].Value.ToString(),
                                       Convert.ToInt32(row.Cells[1].Value));
                }
            }
            return dataTable;
        }

        private void DoughnutChart()
        {
            DataTable dataTable = AssignData();
            int total = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                total += Convert.ToInt32(row["Value"]);
            }

            var dataset = new GunaDoughnutDataset();

            foreach (DataRow row in dataTable.Rows)
            {
                var datasetColor = new GunaDoughnutDataset();
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                int value = Convert.ToInt32(row["Value"]);
                if (value == 0)
                    continue;
                double percentage = ((double)value * 100 / total);
                string format = percentage.ToString("0.00");
                double percent = double.Parse(format);

                datasetColor.Label = row["Name"].ToString();
                datasetColor.LegendBoxFillColor = color;

                dataset.Label = "";
                dataset.LegendBoxFillColor = Color.White;

                dataset.FillColors.Add(color);

                chartInfo.Datasets.Add(datasetColor);
                chartInfo.Datasets.Add(dataset);



                dataset.DataPoints.Add(new LPoint()
                {
                    Label = "",
                    Y = Convert.ToInt32(percent),
                });

                Thread.Sleep(100);
            }
        }

        public void BarChart()
        {
            DataTable dataTable = AssignData();

            foreach (DataRow row in dataTable.Rows)
            {
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                int value = Convert.ToInt32(row["Value"]);
                if (value == 0)
                    continue;
                var dataset = new GunaBarDataset();
                dataset.Label = row["Name"].ToString();
                dataset.LegendBoxFillColor = color;
                dataset.FillColors.Add(color);

                chartInfo.Datasets.Add(dataset);

                dataset.DataPoints.Add(new LPoint()
                {
                    Label = "",
                    Y = Convert.ToInt32(value),
                });

                Thread.Sleep(100);
            }
        }

        private void FStatistical_Load(object sender, EventArgs e)
        {
            string[] typeChart = { "Cột", "Tròn" };
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);


            for (int i = typeChart.Length - 1; i >= 0; i--)
            {
                var button = new System.Windows.Forms.Button()
                {
                    BackColor = Color.Empty,
                    Text = typeChart[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Height = 50,
                    FlatStyle = FlatStyle.Flat,
                    Padding = new Padding(10, 0, 0, 0),
                    FlatAppearance =
                    {
                         BorderSize = 0,
                         MouseOverBackColor = Color.DodgerBlue
                    }
                };
                button.Click += (s, evnt) =>
                {
                    selected = button.Text;
                    SelectBasicExamples(selected);
                    panel2.Size = new Size(5, button.Height);
                    panel2.Location = new Point(panel1.Width - 5, button.Top);
                    panel2.BringToFront();
                };
                panel1.Controls.Add(button);
            }
        }

        private void SelectBasicExamples(string name)
        {
            chartInfo.Datasets.Clear();

            if (name == "Cột")
            {
                BarChart();
            }
            else if (name == "Tròn")
            {
                DoughnutChart();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chartInfo_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
