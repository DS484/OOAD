namespace Hotel_Management
{
    partial class FPayWithQRCode
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPayWithQRCode));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCreateQRCode = new Button();
            label1 = new Label();
            cbbBanks = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbTemplate = new Guna.UI2.WinForms.Guna2ComboBox();
            txtAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            txtInvoice = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            txtExtraInfo = new Guna.UI2.WinForms.Guna2TextBox();
            pbQRCode = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblBack = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateQRCode
            // 
            btnCreateQRCode.BackColor = Color.FromArgb(0, 0, 192);
            btnCreateQRCode.Cursor = Cursors.Hand;
            btnCreateQRCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateQRCode.ForeColor = SystemColors.ControlLight;
            btnCreateQRCode.Location = new Point(116, 371);
            btnCreateQRCode.Name = "btnCreateQRCode";
            btnCreateQRCode.Size = new Size(195, 43);
            btnCreateQRCode.TabIndex = 0;
            btnCreateQRCode.Text = "Tạo QR Code";
            btnCreateQRCode.UseVisualStyleBackColor = false;
            btnCreateQRCode.Click += btnCreateQRCode_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 128, 38);
            label1.Location = new Point(21, 82);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Ngân hàng";
            // 
            // cbbBanks
            // 
            cbbBanks.BackColor = Color.White;
            cbbBanks.BorderColor = Color.FromArgb(51, 32, 32);
            cbbBanks.BorderRadius = 10;
            cbbBanks.BorderThickness = 2;
            cbbBanks.CustomizableEdges = customizableEdges16;
            cbbBanks.DrawMode = DrawMode.OwnerDrawFixed;
            cbbBanks.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBanks.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbBanks.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbBanks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbBanks.ForeColor = Color.FromArgb(68, 88, 112);
            cbbBanks.ItemHeight = 40;
            cbbBanks.Location = new Point(21, 106);
            cbbBanks.Name = "cbbBanks";
            cbbBanks.ShadowDecoration.CustomizableEdges = customizableEdges17;
            cbbBanks.Size = new Size(196, 46);
            cbbBanks.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 128, 38);
            label2.Location = new Point(221, 82);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "Số tài khoản";
            // 
            // txtSTK
            // 
            txtSTK.BackColor = Color.White;
            txtSTK.BorderColor = Color.FromArgb(51, 32, 32);
            txtSTK.BorderRadius = 10;
            txtSTK.BorderThickness = 2;
            txtSTK.CustomizableEdges = customizableEdges18;
            txtSTK.DefaultText = "";
            txtSTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSTK.Location = new Point(222, 106);
            txtSTK.Margin = new Padding(4, 5, 4, 5);
            txtSTK.Name = "txtSTK";
            txtSTK.PasswordChar = '\0';
            txtSTK.PlaceholderText = "";
            txtSTK.SelectedText = "";
            txtSTK.ShadowDecoration.CustomizableEdges = customizableEdges19;
            txtSTK.Size = new Size(195, 34);
            txtSTK.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 128, 38);
            label3.Location = new Point(21, 190);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Template";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 128, 38);
            label4.Location = new Point(21, 293);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 2;
            label4.Text = "Số tiền";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(44, 128, 38);
            label5.Location = new Point(221, 190);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 2;
            label5.Text = "Tên tài khoản";
            // 
            // cbbTemplate
            // 
            cbbTemplate.BackColor = Color.White;
            cbbTemplate.BorderColor = Color.FromArgb(51, 32, 32);
            cbbTemplate.BorderRadius = 10;
            cbbTemplate.BorderThickness = 2;
            cbbTemplate.CustomizableEdges = customizableEdges20;
            cbbTemplate.DrawMode = DrawMode.OwnerDrawFixed;
            cbbTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTemplate.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbTemplate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTemplate.ForeColor = Color.FromArgb(68, 88, 112);
            cbbTemplate.ItemHeight = 40;
            cbbTemplate.Items.AddRange(new object[] { "compact", "compact2", "qr_only", "print" });
            cbbTemplate.Location = new Point(21, 213);
            cbbTemplate.Name = "cbbTemplate";
            cbbTemplate.ShadowDecoration.CustomizableEdges = customizableEdges21;
            cbbTemplate.Size = new Size(196, 46);
            cbbTemplate.TabIndex = 5;
            // 
            // txtAccountName
            // 
            txtAccountName.BackColor = Color.White;
            txtAccountName.BorderColor = Color.FromArgb(51, 32, 32);
            txtAccountName.BorderRadius = 10;
            txtAccountName.BorderThickness = 2;
            txtAccountName.CustomizableEdges = customizableEdges22;
            txtAccountName.DefaultText = "";
            txtAccountName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAccountName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAccountName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Location = new Point(222, 213);
            txtAccountName.Margin = new Padding(4, 5, 4, 5);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.PasswordChar = '\0';
            txtAccountName.PlaceholderText = "";
            txtAccountName.SelectedText = "";
            txtAccountName.ShadowDecoration.CustomizableEdges = customizableEdges23;
            txtAccountName.Size = new Size(195, 34);
            txtAccountName.TabIndex = 6;
            // 
            // txtInvoice
            // 
            txtInvoice.BackColor = Color.White;
            txtInvoice.BorderColor = Color.FromArgb(51, 32, 32);
            txtInvoice.BorderRadius = 10;
            txtInvoice.BorderThickness = 2;
            txtInvoice.CustomizableEdges = customizableEdges24;
            txtInvoice.DefaultText = "";
            txtInvoice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtInvoice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtInvoice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtInvoice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtInvoice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInvoice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoice.Location = new Point(21, 315);
            txtInvoice.Margin = new Padding(4, 5, 4, 5);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.PasswordChar = '\0';
            txtInvoice.PlaceholderText = "";
            txtInvoice.SelectedText = "";
            txtInvoice.ShadowDecoration.CustomizableEdges = customizableEdges25;
            txtInvoice.Size = new Size(195, 34);
            txtInvoice.TabIndex = 7;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(44, 128, 38);
            label6.Location = new Point(221, 293);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 2;
            label6.Text = "Thông tin thêm";
            // 
            // txtExtraInfo
            // 
            txtExtraInfo.BackColor = Color.White;
            txtExtraInfo.BorderColor = Color.FromArgb(51, 32, 32);
            txtExtraInfo.BorderRadius = 10;
            txtExtraInfo.BorderThickness = 2;
            txtExtraInfo.CustomizableEdges = customizableEdges26;
            txtExtraInfo.DefaultText = "";
            txtExtraInfo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtExtraInfo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtExtraInfo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtExtraInfo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtExtraInfo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExtraInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtraInfo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExtraInfo.Location = new Point(221, 315);
            txtExtraInfo.Margin = new Padding(4, 5, 4, 5);
            txtExtraInfo.Name = "txtExtraInfo";
            txtExtraInfo.PasswordChar = '\0';
            txtExtraInfo.PlaceholderText = "";
            txtExtraInfo.SelectedText = "";
            txtExtraInfo.ShadowDecoration.CustomizableEdges = customizableEdges27;
            txtExtraInfo.Size = new Size(195, 34);
            txtExtraInfo.TabIndex = 8;
            // 
            // pbQRCode
            // 
            pbQRCode.BackColor = Color.WhiteSmoke;
            pbQRCode.BorderRadius = 10;
            pbQRCode.CustomizableEdges = customizableEdges28;
            pbQRCode.Image = (Image)resources.GetObject("pbQRCode.Image");
            pbQRCode.ImageRotate = 0F;
            pbQRCode.Location = new Point(462, 106);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.ShadowDecoration.CustomizableEdges = customizableEdges29;
            pbQRCode.Size = new Size(350, 300);
            pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQRCode.TabIndex = 9;
            pbQRCode.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Dock = DockStyle.Top;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Navy;
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(837, 58);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "Thanh toán bằng QR Code";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.BottomCenter;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // lblBack
            // 
            lblBack.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblBack.Location = new Point(32, 10);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(63, 22);
            lblBack.TabIndex = 54;
            lblBack.Text = "Trở lại";
            lblBack.TextAlign = ContentAlignment.MiddleLeft;
            lblBack.Click += lblBack_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.WhiteSmoke;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageSize = new Size(30, 30);
            btnBack.Location = new Point(8, 9);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnBack.Size = new Size(26, 22);
            btnBack.TabIndex = 53;
            btnBack.Click += btnBack_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = pbQRCode;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblBack);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(btnCreateQRCode);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 463);
            panel1.TabIndex = 55;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 18;
            guna2Elipse3.TargetControl = panel1;
            // 
            // FPayWithQRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(858, 481);
            Controls.Add(pbQRCode);
            Controls.Add(txtExtraInfo);
            Controls.Add(txtInvoice);
            Controls.Add(txtAccountName);
            Controls.Add(cbbTemplate);
            Controls.Add(txtSTK);
            Controls.Add(cbbBanks);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FPayWithQRCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPayWithQRCode";
            Load += FPayWithQRCode_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateQRCode;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBanks;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTemplate;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountName;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoice;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtExtraInfo;
        private Guna.UI2.WinForms.Guna2PictureBox pbQRCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label lblBack;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}