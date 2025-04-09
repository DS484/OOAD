namespace Hotel_Management.All_Control
{
    partial class UC_Shape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Shape));
            panelShape = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox2 = new PictureBox();
            panelShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelShape
            // 
            panelShape.BackColor = Color.White;
            panelShape.BorderColor = Color.DimGray;
            panelShape.BorderRadius = 18;
            panelShape.BorderThickness = 2;
            panelShape.Controls.Add(pictureBox2);
            panelShape.CustomizableEdges = customizableEdges1;
            panelShape.Location = new Point(3, 3);
            panelShape.Name = "panelShape";
            panelShape.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelShape.Size = new Size(423, 193);
            panelShape.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 184);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // UC_Shape
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelShape);
            Name = "UC_Shape";
            Size = new Size(430, 199);
            panelShape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelShape;
        private PictureBox pictureBox2;
    }
}
