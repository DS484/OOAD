namespace Hotel_Management
{
    partial class FSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignIn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label24 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            panel2 = new Panel();
            btnHide = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            uC_SignUp1 = new All_Control.UC_SignUp();
            uC_Login1 = new All_Control.UC_Login();
            uC_FogetPasswork1 = new All_Control.UC_FogetPasswork();
            pictureBox1 = new PictureBox();
            uC_Shape1 = new All_Control.UC_Shape();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(uC_SignUp1);
            panel1.Controls.Add(uC_Shape1);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(uC_Login1);
            panel1.Controls.Add(uC_FogetPasswork1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 657);
            panel1.TabIndex = 0;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label24.Location = new Point(41, 5);
            label24.Name = "label24";
            label24.Size = new Size(72, 29);
            label24.TabIndex = 52;
            label24.Text = "Trở lại";
            label24.TextAlign = ContentAlignment.MiddleLeft;
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
            btnBack.Location = new Point(14, 3);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 51;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHide);
            panel2.Controls.Add(guna2CircleButton3);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(1004, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 30);
            panel2.TabIndex = 39;
            // 
            // btnHide
            // 
            btnHide.DisabledState.BorderColor = Color.DarkGray;
            btnHide.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHide.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHide.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHide.FillColor = Color.Transparent;
            btnHide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHide.ForeColor = Color.White;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.ImageSize = new Size(22, 22);
            btnHide.Location = new Point(6, 2);
            btnHide.Name = "btnHide";
            btnHide.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnHide.Size = new Size(25, 25);
            btnHide.TabIndex = 39;
            // 
            // guna2CircleButton3
            // 
            guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton3.FillColor = Color.Transparent;
            guna2CircleButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton3.ForeColor = Color.White;
            guna2CircleButton3.Image = (Image)resources.GetObject("guna2CircleButton3.Image");
            guna2CircleButton3.ImageSize = new Size(25, 25);
            guna2CircleButton3.Location = new Point(37, 2);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(25, 25);
            guna2CircleButton3.TabIndex = 39;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(22, 22);
            btnExit.Location = new Point(68, 2);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 38;
            btnExit.Click += btnExit_Click_2;
            // 
            // uC_SignUp1
            // 
            uC_SignUp1.BackColor = Color.White;
            uC_SignUp1.Location = new Point(643, 30);
            uC_SignUp1.Margin = new Padding(4);
            uC_SignUp1.Name = "uC_SignUp1";
            uC_SignUp1.Size = new Size(458, 618);
            uC_SignUp1.TabIndex = 27;
            // 
            // uC_Login1
            // 
            uC_Login1.BackColor = Color.White;
            uC_Login1.Location = new Point(643, 230);
            uC_Login1.Margin = new Padding(4);
            uC_Login1.Name = "uC_Login1";
            uC_Login1.Size = new Size(426, 427);
            uC_Login1.TabIndex = 25;
            // 
            // uC_FogetPasswork1
            // 
            uC_FogetPasswork1.BackColor = Color.White;
            uC_FogetPasswork1.Location = new Point(643, 230);
            uC_FogetPasswork1.Margin = new Padding(4);
            uC_FogetPasswork1.Name = "uC_FogetPasswork1";
            uC_FogetPasswork1.Size = new Size(426, 424);
            uC_FogetPasswork1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-141, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(828, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // uC_Shape1
            // 
            uC_Shape1.BackColor = Color.White;
            uC_Shape1.Location = new Point(643, 30);
            uC_Shape1.Margin = new Padding(4);
            uC_Shape1.Name = "uC_Shape1";
            uC_Shape1.Size = new Size(426, 196);
            uC_Shape1.TabIndex = 28;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            // 
            // FSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1136, 682);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(216, 148);
            Name = "FSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FSignIn_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Panel panel1;
        private All_Control.UC_Login uC_Login1;
        private All_Control.UC_FogetPasswork uC_FogetPasswork1;
        private PictureBox pictureBox1;
        private All_Control.UC_Shape uC_Shape1;
        public All_Control.UC_SignUp uC_SignUp1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnHide;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label24;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
    }
}
