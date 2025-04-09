namespace Hotel_Management.All_Control
{
    partial class UC_Bill
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bill));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnChart = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblCreateDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            dgvBill = new DataGridView();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // btnChart
            // 
            btnChart.BackColor = Color.Transparent;
            btnChart.BorderRadius = 15;
            btnChart.BorderThickness = 2;
            btnChart.CustomizableEdges = customizableEdges1;
            btnChart.DisabledState.BorderColor = Color.DarkGray;
            btnChart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChart.FillColor = Color.DarkOliveGreen;
            btnChart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChart.ForeColor = Color.White;
            btnChart.Location = new Point(567, 22);
            btnChart.Name = "btnChart";
            btnChart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnChart.Size = new Size(163, 47);
            btnChart.TabIndex = 18;
            btnChart.Text = "Biểu đồ ";
            btnChart.Click += btnChart_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // dtpStartDay
            // 
            dtpStartDay.BackColor = Color.Transparent;
            dtpStartDay.BorderColor = Color.DarkOliveGreen;
            dtpStartDay.BorderRadius = 15;
            dtpStartDay.BorderThickness = 2;
            dtpStartDay.Checked = true;
            dtpStartDay.Cursor = Cursors.Hand;
            dtpStartDay.CustomFormat = "dd/MM/yyyy";
            dtpStartDay.CustomizableEdges = customizableEdges8;
            dtpStartDay.FillColor = Color.FromArgb(207, 236, 236);
            dtpStartDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpStartDay.Format = DateTimePickerFormat.Custom;
            dtpStartDay.Location = new Point(19, 22);
            dtpStartDay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.ShadowDecoration.CustomizableEdges = customizableEdges9;
            dtpStartDay.Size = new Size(327, 47);
            dtpStartDay.TabIndex = 20;
            dtpStartDay.Tag = "";
            dtpStartDay.TextAlign = HorizontalAlignment.Center;
            dtpStartDay.Value = new DateTime(2024, 3, 3, 14, 9, 45, 140);
            // 
            // lblCreateDay
            // 
            lblCreateDay.AutoSize = false;
            lblCreateDay.BackColor = Color.Transparent;
            lblCreateDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateDay.Location = new Point(118, -23);
            lblCreateDay.Margin = new Padding(2, 3, 2, 3);
            lblCreateDay.Name = "lblCreateDay";
            lblCreateDay.Size = new Size(128, 47);
            lblCreateDay.TabIndex = 21;
            lblCreateDay.Text = "Kể từ ngày:";
            lblCreateDay.TextAlignment = ContentAlignment.BottomCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderThickness = 2;
            btnSearch.CustomizableEdges = customizableEdges6;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(399, 22);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSearch.Size = new Size(163, 47);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToResizeColumns = false;
            dgvBill.AllowUserToResizeRows = false;
            dgvBill.Anchor = AnchorStyles.None;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.ColumnHeadersHeight = 75;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column18, Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.GridColor = Color.White;
            dgvBill.Location = new Point(10, 20);
            dgvBill.Margin = new Padding(2, 3, 2, 3);
            dgvBill.MultiSelect = false;
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 62;
            dgvBill.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBill.RowTemplate.Height = 33;
            dgvBill.RowTemplate.ReadOnly = true;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(1176, 719);
            dgvBill.TabIndex = 36;
            // 
            // Column12
            // 
            Column12.FillWeight = 10F;
            Column12.HeaderText = "";
            Column12.Image = Properties.Resources.bill;
            Column12.MinimumWidth = 50;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Mã hóa đơn";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Tên khách hàng";
            Column14.MinimumWidth = 100;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Phòng";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "Tổng đơn";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column18
            // 
            Column18.FillWeight = 79.85747F;
            Column18.HeaderText = "Mã giảm giá";
            Column18.MinimumWidth = 200;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ngày nhận phòng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày trả phòng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.FromArgb(64, 64, 64);
            guna2Panel1.BorderRadius = 12;
            guna2Panel1.Controls.Add(dgvBill);
            guna2Panel1.Cursor = Cursors.IBeam;
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.FillColor = Color.FromArgb(155, 215, 215);
            guna2Panel1.Location = new Point(19, 79);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1194, 749);
            guna2Panel1.TabIndex = 37;
            // 
            // btnReload
            // 
            btnReload.BorderColor = Color.Yellow;
            btnReload.BorderThickness = 1;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.FillColor = Color.Transparent;
            btnReload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReload.ForeColor = Color.White;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageSize = new Size(35, 35);
            btnReload.Location = new Point(1158, 22);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnReload.Size = new Size(47, 47);
            btnReload.TabIndex = 38;
            // 
            // UC_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(btnReload);
            Controls.Add(guna2Panel1);
            Controls.Add(btnSearch);
            Controls.Add(dtpStartDay);
            Controls.Add(btnChart);
            Controls.Add(lblCreateDay);
            Cursor = Cursors.Hand;
            Name = "UC_Bill";
            Size = new Size(1233, 847);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btnChart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreateDay;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public DataGridView dgvBill;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        public Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}
