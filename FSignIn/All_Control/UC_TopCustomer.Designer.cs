namespace Hotel_Management.All_Control
{
    partial class UC_TopCustomer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            cbbTimes = new CTCombobox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.Anchor = AnchorStyles.None;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeight = 75;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column13, Column14, Column15, Column16, Column17, Column18, Column19 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.GridColor = SystemColors.ControlDark;
            dgvCustomer.Location = new Point(10, 20);
            dgvCustomer.Margin = new Padding(2, 3, 2, 3);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCustomer.RowTemplate.Height = 33;
            dgvCustomer.RowTemplate.ReadOnly = true;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(1173, 725);
            dgvCustomer.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column13.HeaderText = "Tên tài khoản";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 200;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Tên";
            Column14.MinimumWidth = 100;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Họ";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "ID";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 125;
            // 
            // Column17
            // 
            Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column17.FillWeight = 79.85747F;
            Column17.HeaderText = "Giới tính";
            Column17.MinimumWidth = 100;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 125;
            // 
            // Column18
            // 
            Column18.FillWeight = 79.85747F;
            Column18.HeaderText = "SDT";
            Column18.MinimumWidth = 200;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column19.FillWeight = 79.85747F;
            Column19.HeaderText = "Số lần đặt phòng";
            Column19.MinimumWidth = 200;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 225;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderThickness = 2;
            btnSearch.CustomizableEdges = customizableEdges1;
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
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearch.Size = new Size(163, 47);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 215, 215);
            panel1.Controls.Add(dgvCustomer);
            panel1.Location = new Point(19, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 749);
            panel1.TabIndex = 56;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // cbbTimes
            // 
            cbbTimes.BackColor = Color.FromArgb(207, 236, 236);
            cbbTimes.BorderColor = Color.DarkOliveGreen;
            cbbTimes.BorderSize = 2;
            cbbTimes.DropDownStyle = ComboBoxStyle.DropDown;
            cbbTimes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTimes.ForeColor = Color.DimGray;
            cbbTimes.IconColor = Color.DimGray;
            cbbTimes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbbTimes.ListBackColor = Color.FromArgb(207, 236, 236);
            cbbTimes.ListTextColor = Color.DimGray;
            cbbTimes.Location = new Point(16, 24);
            cbbTimes.Margin = new Padding(3, 4, 3, 4);
            cbbTimes.Name = "cbbTimes";
            cbbTimes.Padding = new Padding(2);
            cbbTimes.Size = new Size(327, 47);
            cbbTimes.TabIndex = 39;
            cbbTimes.Texts = "Chọn số lần đặt cần tìm...";
            // 
            // UC_TopCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(cbbTimes);
            Controls.Add(btnSearch);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UC_TopCustomer";
            Size = new Size(1233, 847);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dgvCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CTCombobox cbbTimes;
        private Panel panel1;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
    }
}
