namespace Hotel_Management
{
    partial class FChatAI
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChatAI));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtBody = new RichTextBox();
            txtMessage = new RichTextBox();
            btnSend = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            label2 = new Label();
            PicFlashingLogo = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            btnHide = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicFlashingLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBody
            // 
            txtBody.Location = new Point(14, 132);
            txtBody.Margin = new Padding(3, 4, 3, 4);
            txtBody.Name = "txtBody";
            txtBody.ReadOnly = true;
            txtBody.Size = new Size(886, 420);
            txtBody.TabIndex = 0;
            txtBody.Text = "";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(14, 561);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(799, 68);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "";
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.CustomizableEdges = customizableEdges1;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.FillColor = Color.Transparent;
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.Location = new Point(821, 561);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSend.Size = new Size(80, 69);
            btnSend.TabIndex = 2;
            btnSend.Click += btnSend_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(27, 44);
            guna2PictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(45, 53);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 3;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(57, 145, 217);
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 4;
            label1.Text = "API From Gemini ";
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(799, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 13);
            label2.TabIndex = 29;
            // 
            // PicFlashingLogo
            // 
            PicFlashingLogo.BackColor = Color.WhiteSmoke;
            PicFlashingLogo.Image = (Image)resources.GetObject("PicFlashingLogo.Image");
            PicFlashingLogo.Location = new Point(741, 53);
            PicFlashingLogo.Name = "PicFlashingLogo";
            PicFlashingLogo.Size = new Size(35, 20);
            PicFlashingLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PicFlashingLogo.TabIndex = 28;
            PicFlashingLogo.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(3, 122, 139);
            label3.Location = new Point(754, 53);
            label3.Name = "label3";
            label3.Size = new Size(151, 56);
            label3.TabIndex = 27;
            label3.Text = "travelstrip";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHide);
            panel2.Controls.Add(guna2CircleButton3);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(810, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 31);
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
            btnHide.Location = new Point(7, 1);
            btnHide.Name = "btnHide";
            btnHide.ShadowDecoration.CustomizableEdges = customizableEdges5;
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
            guna2CircleButton3.Location = new Point(37, 1);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            btnExit.Location = new Point(69, 1);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 38;
            btnExit.Click += btnExit_Click;
            // 
            // FChatAI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 647);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(PicFlashingLogo);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtBody);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FChatAI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FChatAI";
            Load += FChatAI_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicFlashingLogo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtBody;
        private RichTextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox PicFlashingLogo;
        private Label label3;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnHide;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}