namespace CapaPresentacion
{
    partial class Frm_Login
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
            panel1 = new Panel();
            TxtUsuario = new TextBox();
            TxtContrasenia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnIngresar = new Button();
            CmbRol = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            TxtUsuario.BorderStyle = BorderStyle.None;
            TxtUsuario.Cursor = Cursors.IBeam;
            TxtUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsuario.ForeColor = Color.FromArgb(130, 130, 130);
            TxtUsuario.Location = new Point(322, 139);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(410, 13);
            TxtUsuario.TabIndex = 1;
            TxtUsuario.Text = "USUARIO";
            // 
            // TxtContrasenia
            // 
            TxtContrasenia.BackColor = Color.FromArgb(15, 15, 15);
            TxtContrasenia.BorderStyle = BorderStyle.None;
            TxtContrasenia.Cursor = Cursors.IBeam;
            TxtContrasenia.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContrasenia.ForeColor = Color.FromArgb(130, 130, 130);
            TxtContrasenia.Location = new Point(322, 189);
            TxtContrasenia.Name = "TxtContrasenia";
            TxtContrasenia.Size = new Size(410, 13);
            TxtContrasenia.TabIndex = 2;
            TxtContrasenia.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(319, 140);
            label1.Name = "label1";
            label1.Size = new Size(397, 15);
            label1.TabIndex = 3;
            label1.Text = "______________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(319, 190);
            label2.Name = "label2";
            label2.Size = new Size(397, 15);
            label2.TabIndex = 4;
            label2.Text = "______________________________________________________________________________";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(40, 40, 40);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.Silver;
            BtnIngresar.Location = new Point(322, 240);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(394, 40);
            BtnIngresar.TabIndex = 5;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // CmbRol
            // 
            CmbRol.BackColor = Color.White;
            CmbRol.DropDownHeight = 100;
            CmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRol.ForeColor = SystemColors.InfoText;
            CmbRol.FormattingEnabled = true;
            CmbRol.IntegralHeight = false;
            CmbRol.Location = new Point(322, 91);
            CmbRol.Name = "CmbRol";
            CmbRol.Size = new Size(394, 23);
            CmbRol.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(476, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 7;
            label3.Text = "LOGIN";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(label3);
            Controls.Add(CmbRol);
            Controls.Add(BtnIngresar);
            Controls.Add(TxtContrasenia);
            Controls.Add(TxtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TxtUsuario;
        private TextBox TxtContrasenia;
        private Label label1;
        private Label label2;
        private Button BtnIngresar;
        private ComboBox CmbRol;
        private Label label3;
    }
}