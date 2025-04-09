namespace Hotel_Management.All_Control
{
    partial class UC_Service
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Service));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnAddService = new Guna.UI2.WinForms.Guna2Button();
            txtSearchService = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            dgvService = new DataGridView();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewImageColumn();
            Column22 = new DataGridViewImageColumn();
            Column1 = new DataGridViewTextBoxColumn();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.Transparent;
            btnAddService.BorderRadius = 15;
            btnAddService.BorderThickness = 2;
            btnAddService.CustomizableEdges = customizableEdges11;
            btnAddService.DisabledState.BorderColor = Color.DarkGray;
            btnAddService.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddService.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddService.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddService.FillColor = Color.DarkOliveGreen;
            btnAddService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddService.ForeColor = Color.White;
            btnAddService.Location = new Point(568, 24);
            btnAddService.Name = "btnAddService";
            btnAddService.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAddService.Size = new Size(163, 47);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "Thêm dịch vụ";
            // 
            // txtSearchService
            // 
            txtSearchService.BorderColor = Color.DarkOliveGreen;
            txtSearchService.BorderRadius = 15;
            txtSearchService.BorderThickness = 2;
            txtSearchService.CustomizableEdges = customizableEdges13;
            txtSearchService.DefaultText = "";
            txtSearchService.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchService.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchService.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchService.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchService.FillColor = Color.FromArgb(207, 236, 236);
            txtSearchService.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchService.ForeColor = Color.DimGray;
            txtSearchService.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchService.IconLeft = (Image)resources.GetObject("txtSearchService.IconLeft");
            txtSearchService.IconLeftSize = new Size(30, 30);
            txtSearchService.Location = new Point(16, 24);
            txtSearchService.Margin = new Padding(7, 9, 7, 9);
            txtSearchService.Name = "txtSearchService";
            txtSearchService.PasswordChar = '\0';
            txtSearchService.PlaceholderForeColor = Color.DimGray;
            txtSearchService.PlaceholderText = "|Nhập mã DV cần tìm...";
            txtSearchService.SelectedText = "";
            txtSearchService.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtSearchService.Size = new Size(327, 47);
            txtSearchService.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 215, 215);
            panel1.Controls.Add(dgvService);
            panel1.Location = new Point(19, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 749);
            panel1.TabIndex = 11;
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AllowUserToResizeColumns = false;
            dgvService.AllowUserToResizeRows = false;
            dgvService.Anchor = AnchorStyles.None;
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvService.BorderStyle = BorderStyle.None;
            dgvService.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvService.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvService.ColumnHeadersHeight = 75;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvService.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column21, Column22, Column1 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvService.DefaultCellStyle = dataGridViewCellStyle5;
            dgvService.EnableHeadersVisualStyles = false;
            dgvService.GridColor = Color.White;
            dgvService.Location = new Point(10, 20);
            dgvService.Margin = new Padding(2, 3, 2, 3);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvService.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvService.RowHeadersVisible = false;
            dgvService.RowHeadersWidth = 62;
            dgvService.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvService.RowTemplate.Height = 33;
            dgvService.RowTemplate.ReadOnly = true;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.Size = new Size(1173, 725);
            dgvService.TabIndex = 36;
            dgvService.CellClick += dgvService_CellClick;
            // 
            // Column12
            // 
            Column12.FillWeight = 10F;
            Column12.HeaderText = "";
            Column12.MinimumWidth = 70;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Phòng";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Mã dịch vụ";
            Column14.MinimumWidth = 200;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Loại dịch vụ";
            Column15.MinimumWidth = 400;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column21
            // 
            Column21.FillWeight = 1F;
            Column21.HeaderText = "Sửa";
            Column21.MinimumWidth = 75;
            Column21.Name = "Column21";
            Column21.ReadOnly = true;
            // 
            // Column22
            // 
            Column22.FillWeight = 1F;
            Column22.HeaderText = "Xóa";
            Column22.MinimumWidth = 75;
            Column22.Name = "Column22";
            Column22.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = panel1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderThickness = 2;
            btnSearch.CustomizableEdges = customizableEdges9;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(400, 24);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSearch.Size = new Size(163, 47);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
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
            btnReload.Location = new Point(1155, 24);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnReload.Size = new Size(47, 47);
            btnReload.TabIndex = 40;
            // 
            // UC_Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(btnReload);
            Controls.Add(btnSearch);
            Controls.Add(btnAddService);
            Controls.Add(txtSearchService);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "UC_Service";
            Size = new Size(1233, 847);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2Button btnAddService;
        public Guna.UI2.WinForms.Guna2TextBox txtSearchService;
        public Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        public DataGridView dgvService;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewImageColumn Column21;
        private DataGridViewImageColumn Column22;
        private DataGridViewTextBoxColumn Column1;
        public Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}
