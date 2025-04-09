namespace Hotel_Management.All_Control
{
    partial class UC_Customers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            dgvInfoCustomer = new DataGridView();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dtpCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSearchCustomer = new Guna.UI2.WinForms.Guna2Button();
            btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoCustomer).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 18;
            guna2Elipse3.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 215, 215);
            panel1.Controls.Add(dgvInfoCustomer);
            panel1.Location = new Point(19, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 749);
            panel1.TabIndex = 19;
            // 
            // dgvInfoCustomer
            // 
            dgvInfoCustomer.AllowUserToAddRows = false;
            dgvInfoCustomer.AllowUserToDeleteRows = false;
            dgvInfoCustomer.AllowUserToResizeColumns = false;
            dgvInfoCustomer.AllowUserToResizeRows = false;
            dgvInfoCustomer.Anchor = AnchorStyles.None;
            dgvInfoCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfoCustomer.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvInfoCustomer.BorderStyle = BorderStyle.None;
            dgvInfoCustomer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInfoCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInfoCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInfoCustomer.ColumnHeadersHeight = 75;
            dgvInfoCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInfoCustomer.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInfoCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInfoCustomer.EnableHeadersVisualStyles = false;
            dgvInfoCustomer.GridColor = Color.White;
            dgvInfoCustomer.Location = new Point(10, 20);
            dgvInfoCustomer.Margin = new Padding(2, 3, 2, 3);
            dgvInfoCustomer.MultiSelect = false;
            dgvInfoCustomer.Name = "dgvInfoCustomer";
            dgvInfoCustomer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInfoCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInfoCustomer.RowHeadersVisible = false;
            dgvInfoCustomer.RowHeadersWidth = 62;
            dgvInfoCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInfoCustomer.RowTemplate.Height = 33;
            dgvInfoCustomer.RowTemplate.ReadOnly = true;
            dgvInfoCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoCustomer.Size = new Size(1173, 725);
            dgvInfoCustomer.TabIndex = 36;
            // 
            // Column12
            // 
            Column12.FillWeight = 10F;
            Column12.HeaderText = "";
            Column12.MinimumWidth = 80;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Tài khoản";
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
            Column15.HeaderText = "Số phòng";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "SDT";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column17
            // 
            Column17.FillWeight = 79.85747F;
            Column17.HeaderText = "CCCD";
            Column17.MinimumWidth = 125;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            // 
            // Column18
            // 
            Column18.FillWeight = 79.85747F;
            Column18.HeaderText = "Ngày nhận phòng";
            Column18.MinimumWidth = 200;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.FillWeight = 79.85747F;
            Column19.HeaderText = "Ngày trả phòng";
            Column19.MinimumWidth = 200;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.BackColor = Color.Transparent;
            dtpCheckIn.BorderRadius = 18;
            dtpCheckIn.BorderThickness = 2;
            dtpCheckIn.Checked = true;
            dtpCheckIn.Cursor = Cursors.Hand;
            dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            dtpCheckIn.CustomizableEdges = customizableEdges6;
            dtpCheckIn.FillColor = Color.FromArgb(207, 236, 236);
            dtpCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(16, 24);
            dtpCheckIn.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpCheckIn.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            dtpCheckIn.Size = new Size(179, 47);
            dtpCheckIn.TabIndex = 21;
            dtpCheckIn.Tag = "";
            dtpCheckIn.TextAlign = HorizontalAlignment.Center;
            dtpCheckIn.Value = new DateTime(2024, 3, 3, 14, 9, 45, 140);
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.BackColor = Color.Transparent;
            dtpCheckOut.BorderRadius = 18;
            dtpCheckOut.BorderThickness = 2;
            dtpCheckOut.Checked = true;
            dtpCheckOut.Cursor = Cursors.Hand;
            dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            dtpCheckOut.CustomizableEdges = customizableEdges4;
            dtpCheckOut.FillColor = Color.FromArgb(207, 236, 236);
            dtpCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(257, 24);
            dtpCheckOut.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpCheckOut.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges5;
            dtpCheckOut.Size = new Size(179, 47);
            dtpCheckOut.TabIndex = 22;
            dtpCheckOut.Tag = "";
            dtpCheckOut.TextAlign = HorizontalAlignment.Center;
            dtpCheckOut.Value = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(214, 21);
            guna2HtmlLabel1.Margin = new Padding(2, 3, 2, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(18, 52);
            guna2HtmlLabel1.TabIndex = 23;
            guna2HtmlLabel1.Text = "-";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(66, -3);
            guna2HtmlLabel2.Margin = new Padding(2, 3, 2, 3);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(94, 34);
            guna2HtmlLabel2.TabIndex = 24;
            guna2HtmlLabel2.Text = "Từ ngày";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(299, -1);
            guna2HtmlLabel3.Margin = new Padding(2, 3, 2, 3);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(94, 34);
            guna2HtmlLabel3.TabIndex = 25;
            guna2HtmlLabel3.Text = "Đến ngày";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.TopCenter;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.Transparent;
            btnSearchCustomer.BorderRadius = 18;
            btnSearchCustomer.BorderThickness = 2;
            btnSearchCustomer.CustomizableEdges = customizableEdges2;
            btnSearchCustomer.DisabledState.BorderColor = Color.DarkGray;
            btnSearchCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchCustomer.FillColor = Color.DarkOliveGreen;
            btnSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Location = new Point(500, 24);
            btnSearchCustomer.Margin = new Padding(2, 3, 2, 3);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnSearchCustomer.Size = new Size(163, 47);
            btnSearchCustomer.TabIndex = 26;
            btnSearchCustomer.Text = "Tìm kiếm";
            btnSearchCustomer.Click += btnSearchCustomer_Click;
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
            btnReload.Location = new Point(1155, 26);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnReload.Size = new Size(47, 47);
            btnReload.TabIndex = 39;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(btnReload);
            Controls.Add(btnSearchCustomer);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(panel1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel3);
            Cursor = Cursors.Hand;
            Name = "UC_Customers";
            Size = new Size(1233, 847);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInfoCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnSearchCustomer;
        public DataGridView dgvInfoCustomer;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        public Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}
