namespace Hotel_Management.All_Control
{
    partial class UC_Review
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblComment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblStar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel5
            // 
            guna2Panel5.BackColor = Color.White;
            guna2Panel5.BorderColor = Color.Black;
            guna2Panel5.BorderRadius = 10;
            guna2Panel5.BorderThickness = 2;
            guna2Panel5.Controls.Add(guna2PictureBox1);
            guna2Panel5.Controls.Add(lblComment);
            guna2Panel5.Controls.Add(lblStar);
            guna2Panel5.Controls.Add(lblUserName);
            guna2Panel5.CustomizableEdges = customizableEdges3;
            guna2Panel5.Location = new Point(5, 4);
            guna2Panel5.Margin = new Padding(4);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel5.Size = new Size(380, 134);
            guna2Panel5.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = SystemColors.MenuHighlight;
            guna2PictureBox1.Image = Properties.Resources.star;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(244, 19);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(30, 27);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 23;
            guna2PictureBox1.TabStop = false;
            // 
            // lblComment
            // 
            lblComment.BackColor = Color.Transparent;
            lblComment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblComment.Location = new Point(24, 55);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(88, 30);
            lblComment.TabIndex = 2;
            lblComment.Text = "Đánh giá";
            // 
            // lblStar
            // 
            lblStar.BackColor = Color.Transparent;
            lblStar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblStar.ForeColor = Color.Gold;
            lblStar.Location = new Point(217, 16);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(36, 30);
            lblStar.TabIndex = 1;
            lblStar.Text = "Sao";
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUserName.Location = new Point(24, 19);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(36, 30);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Tên";
            // 
            // UC_Review
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel5);
            Name = "UC_Review";
            Size = new Size(390, 138);
            guna2Panel5.ResumeLayout(false);
            guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblStar;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblComment;
    }
}
