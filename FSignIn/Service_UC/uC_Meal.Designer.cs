namespace Hotel_Management.Service_UC
{
    partial class uC_Meal
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_Meal));
            pnMeal = new Guna.UI2.WinForms.Guna2Panel();
            label12 = new Label();
            label1 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            pictureBox11 = new PictureBox();
            pnMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // pnMeal
            // 
            pnMeal.BackColor = Color.White;
            pnMeal.Controls.Add(label12);
            pnMeal.Controls.Add(label1);
            pnMeal.Controls.Add(label11);
            pnMeal.Controls.Add(label10);
            pnMeal.Controls.Add(label9);
            pnMeal.Controls.Add(pictureBox11);
            pnMeal.CustomizableEdges = customizableEdges1;
            pnMeal.Location = new Point(4, 4);
            pnMeal.Margin = new Padding(4);
            pnMeal.Name = "pnMeal";
            pnMeal.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnMeal.Size = new Size(231, 256);
            pnMeal.TabIndex = 1;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(76, 21);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(139, 64);
            label12.TabIndex = 10;
            label12.Text = "Ăn uống";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(9, 200);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 9;
            label1.Text = "       Đầu bếp riêng";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(9, 169);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(218, 31);
            label11.TabIndex = 9;
            label11.Text = "       Nhà hàng";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(9, 138);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(218, 31);
            label10.TabIndex = 8;
            label10.Text = "       Quán Cafe";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(9, 106);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(218, 31);
            label9.TabIndex = 7;
            label9.Text = "       Bữa sáng tại phòng";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(9, 22);
            pictureBox11.Margin = new Padding(4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(62, 62);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            // 
            // uC_Meal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnMeal);
            Name = "uC_Meal";
            Size = new Size(239, 263);
            pnMeal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel pnMeal;
        public Label label12;
        public Label label11;
        public Label label10;
        public Label label9;
        public PictureBox pictureBox11;
        public Label label1;
    }
}
