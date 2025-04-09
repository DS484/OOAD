namespace Hotel_Management.All_Control
{
    partial class UC_HotelRevenue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnChart = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            dgvHotelRevenue = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            cbbRevenue = new CTCombobox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotelRevenue).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // btnChart
            // 
            btnChart.BackColor = Color.Transparent;
            btnChart.BorderRadius = 15;
            btnChart.BorderThickness = 2;
            btnChart.Cursor = Cursors.Hand;
            btnChart.CustomizableEdges = customizableEdges1;
            btnChart.DisabledState.BorderColor = Color.DarkGray;
            btnChart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChart.FillColor = Color.DarkOliveGreen;
            btnChart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChart.ForeColor = Color.White;
            btnChart.Location = new Point(567, 24);
            btnChart.Name = "btnChart";
            btnChart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnChart.Size = new Size(163, 47);
            btnChart.TabIndex = 50;
            btnChart.Text = "Biểu đồ";
            btnChart.Click += btnChart_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 215, 215);
            panel1.Controls.Add(dgvHotelRevenue);
            panel1.Location = new Point(19, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 749);
            panel1.TabIndex = 54;
            // 
            // dgvHotelRevenue
            // 
            dgvHotelRevenue.AllowUserToAddRows = false;
            dgvHotelRevenue.AllowUserToDeleteRows = false;
            dgvHotelRevenue.AllowUserToResizeColumns = false;
            dgvHotelRevenue.AllowUserToResizeRows = false;
            dgvHotelRevenue.Anchor = AnchorStyles.None;
            dgvHotelRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHotelRevenue.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvHotelRevenue.BorderStyle = BorderStyle.None;
            dgvHotelRevenue.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHotelRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHotelRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHotelRevenue.ColumnHeadersHeight = 75;
            dgvHotelRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHotelRevenue.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHotelRevenue.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHotelRevenue.EnableHeadersVisualStyles = false;
            dgvHotelRevenue.GridColor = SystemColors.ControlDark;
            dgvHotelRevenue.Location = new Point(10, 20);
            dgvHotelRevenue.Margin = new Padding(2, 3, 2, 3);
            dgvHotelRevenue.MultiSelect = false;
            dgvHotelRevenue.Name = "dgvHotelRevenue";
            dgvHotelRevenue.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHotelRevenue.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHotelRevenue.RowHeadersVisible = false;
            dgvHotelRevenue.RowHeadersWidth = 62;
            dgvHotelRevenue.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHotelRevenue.RowTemplate.Height = 33;
            dgvHotelRevenue.RowTemplate.ReadOnly = true;
            dgvHotelRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHotelRevenue.Size = new Size(1173, 725);
            dgvHotelRevenue.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Id";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên khách sạn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Khu vực";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Thành phố";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tổng doanh thu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderThickness = 2;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(400, 24);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(163, 47);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // cbbRevenue
            // 
            cbbRevenue.BackColor = Color.FromArgb(207, 236, 236);
            cbbRevenue.BorderColor = Color.DimGray;
            cbbRevenue.BorderSize = 2;
            cbbRevenue.DropDownStyle = ComboBoxStyle.DropDown;
            cbbRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbRevenue.ForeColor = Color.DimGray;
            cbbRevenue.IconColor = Color.DimGray;
            cbbRevenue.Items.AddRange(new object[] { "0 - 5000000", "5000000 - 10000000", "10000000 - 50000000", "50000000 - 100000000", "Trên 100000000" });
            cbbRevenue.ListBackColor = Color.FromArgb(207, 236, 236);
            cbbRevenue.ListTextColor = Color.DimGray;
            cbbRevenue.Location = new Point(16, 24);
            cbbRevenue.Margin = new Padding(3, 4, 3, 4);
            cbbRevenue.Name = "cbbRevenue";
            cbbRevenue.Padding = new Padding(2);
            cbbRevenue.Size = new Size(327, 47);
            cbbRevenue.TabIndex = 53;
            cbbRevenue.Texts = "Chọn mức doanh thu";
            cbbRevenue.OnSelectedIndexChanged += cbbRevenue_OnSelectedIndexChanged;
            // 
            // UC_HotelRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(panel1);
            Controls.Add(cbbRevenue);
            Controls.Add(btnChart);
            Controls.Add(btnSearch);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UC_HotelRevenue";
            Size = new Size(1233, 847);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHotelRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Button btnChart;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private CTCombobox cbbRevenue;
        private Panel panel1;
        public DataGridView dgvHotelRevenue;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
