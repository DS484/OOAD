namespace Hotel_Management.Properties
{
    partial class FAddService
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddService));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            btnAddService = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panel2 = new Panel();
            txtRoomNumber = new All_Control.CTTextbox();
            cbMeal = new Guna.UI2.WinForms.Guna2CheckBox();
            cbHealthy = new Guna.UI2.WinForms.Guna2CheckBox();
            cbAnother = new Guna.UI2.WinForms.Guna2CheckBox();
            cbActivity = new Guna.UI2.WinForms.Guna2CheckBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox13 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnEditService = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BorderRadius = 18;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(329, 449);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(106, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // btnAddService
            // 
            btnAddService.BorderRadius = 18;
            btnAddService.CustomizableEdges = customizableEdges3;
            btnAddService.DisabledState.BorderColor = Color.DarkGray;
            btnAddService.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddService.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddService.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddService.FillColor = Color.FromArgb(0, 192, 0);
            btnAddService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddService.ForeColor = Color.White;
            btnAddService.Location = new Point(65, 449);
            btnAddService.Name = "btnAddService";
            btnAddService.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddService.Size = new Size(106, 45);
            btnAddService.TabIndex = 6;
            btnAddService.Text = "Thêm";
            btnAddService.Click += btnAddRoom_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(511, 60);
            label1.TabIndex = 5;
            label1.Text = "Thông tin dịch vụ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnEditService);
            panel2.Controls.Add(txtRoomNumber);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnAddService);
            panel2.Controls.Add(cbMeal);
            panel2.Controls.Add(cbHealthy);
            panel2.Controls.Add(cbAnother);
            panel2.Controls.Add(cbActivity);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 548);
            panel2.TabIndex = 4;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BackColor = Color.WhiteSmoke;
            txtRoomNumber.BorderColor = Color.FromArgb(82, 145, 175);
            txtRoomNumber.BorderFocusColor = Color.Black;
            txtRoomNumber.BorderRadius = 20;
            txtRoomNumber.BorderSize = 1;
            txtRoomNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNumber.ForeColor = Color.DimGray;
            txtRoomNumber.IsFocused = false;
            txtRoomNumber.Location = new Point(151, 75);
            txtRoomNumber.Margin = new Padding(2, 2, 2, 2);
            txtRoomNumber.Multiline = false;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Padding = new Padding(6, 6, 6, 6);
            txtRoomNumber.PasswordChar = false;
            txtRoomNumber.PlaceholderColor = Color.DarkGray;
            txtRoomNumber.PlaceholderText = "";
            txtRoomNumber.ReadOnly = false;
            txtRoomNumber.Size = new Size(242, 41);
            txtRoomNumber.TabIndex = 29;
            txtRoomNumber.Texts = "Mã phòng";
            txtRoomNumber.UnderlineedStyle = true;
            // 
            // cbMeal
            // 
            cbMeal.AutoSize = true;
            cbMeal.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbMeal.CheckedState.BorderRadius = 0;
            cbMeal.CheckedState.BorderThickness = 0;
            cbMeal.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbMeal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbMeal.Location = new Point(151, 378);
            cbMeal.Margin = new Padding(2, 2, 2, 2);
            cbMeal.Name = "cbMeal";
            cbMeal.Size = new Size(113, 32);
            cbMeal.TabIndex = 28;
            cbMeal.Text = "Ăn uống";
            cbMeal.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbMeal.UncheckedState.BorderRadius = 0;
            cbMeal.UncheckedState.BorderThickness = 0;
            cbMeal.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbHealthy
            // 
            cbHealthy.AutoSize = true;
            cbHealthy.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbHealthy.CheckedState.BorderRadius = 0;
            cbHealthy.CheckedState.BorderThickness = 0;
            cbHealthy.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbHealthy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbHealthy.Location = new Point(151, 314);
            cbHealthy.Margin = new Padding(2, 2, 2, 2);
            cbHealthy.Name = "cbHealthy";
            cbHealthy.Size = new Size(118, 32);
            cbHealthy.TabIndex = 28;
            cbHealthy.Text = "Sức khỏe";
            cbHealthy.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbHealthy.UncheckedState.BorderRadius = 0;
            cbHealthy.UncheckedState.BorderThickness = 0;
            cbHealthy.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbAnother
            // 
            cbAnother.AutoSize = true;
            cbAnother.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbAnother.CheckedState.BorderRadius = 0;
            cbAnother.CheckedState.BorderThickness = 0;
            cbAnother.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbAnother.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbAnother.Location = new Point(151, 249);
            cbAnother.Margin = new Padding(2, 2, 2, 2);
            cbAnother.Name = "cbAnother";
            cbAnother.Size = new Size(77, 32);
            cbAnother.TabIndex = 28;
            cbAnother.Text = "Khác";
            cbAnother.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbAnother.UncheckedState.BorderRadius = 0;
            cbAnother.UncheckedState.BorderThickness = 0;
            cbAnother.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbActivity
            // 
            cbActivity.AutoSize = true;
            cbActivity.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbActivity.CheckedState.BorderRadius = 0;
            cbActivity.CheckedState.BorderThickness = 0;
            cbActivity.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbActivity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbActivity.Location = new Point(151, 183);
            cbActivity.Margin = new Padding(2, 2, 2, 2);
            cbActivity.Name = "cbActivity";
            cbActivity.Size = new Size(132, 32);
            cbActivity.TabIndex = 28;
            cbActivity.Text = "Hoạt động";
            cbActivity.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbActivity.UncheckedState.BorderRadius = 0;
            cbActivity.UncheckedState.BorderThickness = 0;
            cbActivity.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(86, 378);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 23;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(86, 314);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(50, 50);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(86, 183);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(50, 50);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 20;
            pictureBox13.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 137);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 19;
            label2.Text = "Tiện ích";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panel2;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = this;
            // 
            // btnEditService
            // 
            btnEditService.BorderRadius = 18;
            btnEditService.CustomizableEdges = customizableEdges5;
            btnEditService.DisabledState.BorderColor = Color.DarkGray;
            btnEditService.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditService.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditService.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditService.ForeColor = Color.White;
            btnEditService.Location = new Point(197, 448);
            btnEditService.Margin = new Padding(2, 2, 2, 2);
            btnEditService.Name = "btnEditService";
            btnEditService.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditService.Size = new Size(106, 45);
            btnEditService.TabIndex = 8;
            btnEditService.Text = "Sửa";
            btnEditService.Click += btnEditService_Click;
            // 
            // FAddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(535, 572);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FAddService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAddService";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox13;
        private PictureBox pictureBox1;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private Guna.UI2.WinForms.Guna2CheckBox cbMeal;
        private Guna.UI2.WinForms.Guna2CheckBox cbHealthy;
        private Guna.UI2.WinForms.Guna2CheckBox cbAnother;
        private Guna.UI2.WinForms.Guna2CheckBox cbActivity;
        private All_Control.CTTextbox txtRoomNumber;
        private Guna.UI2.WinForms.Guna2Button btnEditService;
    }
}