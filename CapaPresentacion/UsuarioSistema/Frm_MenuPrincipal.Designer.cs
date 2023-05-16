namespace CapaPresentacion
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            PbxProductos = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbxProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(PbxProductos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 450);
            panel2.TabIndex = 1;
            // 
            // PbxProductos
            // 
            PbxProductos.BackColor = Color.Transparent;
            PbxProductos.BackgroundImageLayout = ImageLayout.Center;
            PbxProductos.BorderStyle = BorderStyle.FixedSingle;
            PbxProductos.Cursor = Cursors.Hand;
            PbxProductos.Image = (Image)resources.GetObject("PbxProductos.Image");
            PbxProductos.InitialImage = (Image)resources.GetObject("PbxProductos.InitialImage");
            PbxProductos.Location = new Point(39, 62);
            PbxProductos.Name = "PbxProductos";
            PbxProductos.Size = new Size(125, 58);
            PbxProductos.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxProductos.TabIndex = 0;
            PbxProductos.TabStop = false;
            // 
            // Frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(916, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_MenuPrincipal";
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbxProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox PbxProductos;
    }
}