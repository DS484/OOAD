namespace Hotel_Management.All_Control
{
    partial class UC_FamousLocation
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
            dgvHotel = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            cbbCity = new CTCombobox();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHotel
            // 
            dgvHotel.AllowUserToAddRows = false;
            dgvHotel.AllowUserToDeleteRows = false;
            dgvHotel.AllowUserToResizeColumns = false;
            dgvHotel.AllowUserToResizeRows = false;
            dgvHotel.Anchor = AnchorStyles.None;
            dgvHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHotel.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvHotel.BorderStyle = BorderStyle.None;
            dgvHotel.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHotel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHotel.ColumnHeadersHeight = 75;
            dgvHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHotel.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHotel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHotel.EnableHeadersVisualStyles = false;
            dgvHotel.GridColor = SystemColors.ControlDark;
            dgvHotel.Location = new Point(10, 20);
            dgvHotel.Margin = new Padding(2, 3, 2, 3);
            dgvHotel.MultiSelect = false;
            dgvHotel.Name = "dgvHotel";
            dgvHotel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHotel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHotel.RowHeadersVisible = false;
            dgvHotel.RowHeadersWidth = 62;
            dgvHotel.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHotel.RowTemplate.Height = 33;
            dgvHotel.RowTemplate.ReadOnly = true;
            dgvHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHotel.Size = new Size(1173, 725);
            dgvHotel.TabIndex = 35;
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
            // Column2
            // 
            Column2.HeaderText = "Khu vực";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thành phố";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng đặt phòng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
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
            btnSearch.TabIndex = 36;
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
            panel1.Controls.Add(dgvHotel);
            panel1.Location = new Point(19, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 749);
            panel1.TabIndex = 55;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // cbbCity
            // 
            cbbCity.BackColor = Color.FromArgb(207, 236, 236);
            cbbCity.BorderColor = Color.DarkOliveGreen;
            cbbCity.BorderSize = 2;
            cbbCity.DropDownStyle = ComboBoxStyle.DropDown;
            cbbCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCity.ForeColor = Color.DimGray;
            cbbCity.IconColor = Color.DimGray;
            cbbCity.Items.AddRange(new object[] { "TP Hồ Chí Minh", "Hà Nội", "Đà Nẵng" });
            cbbCity.ListBackColor = Color.FromArgb(207, 236, 236);
            cbbCity.ListTextColor = Color.DimGray;
            cbbCity.Location = new Point(16, 24);
            cbbCity.Margin = new Padding(3, 4, 3, 4);
            cbbCity.Name = "cbbCity";
            cbbCity.Padding = new Padding(2);
            cbbCity.Size = new Size(327, 47);
            cbbCity.TabIndex = 38;
            cbbCity.Texts = "Chọn thành phố cần tìm...";
            // 
            // UC_FamousLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(panel1);
            Controls.Add(cbbCity);
            Controls.Add(btnSearch);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UC_FamousLocation";
            Size = new Size(1233, 847);
            ((System.ComponentModel.ISupportInitialize)dgvHotel).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dgvHotel;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CTCombobox cbbCity;
        private Panel panel1;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
