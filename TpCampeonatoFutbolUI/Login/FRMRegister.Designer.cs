namespace TPCampeonatoFutbol
{
    partial class FRMRegister
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
            this.CrearCuentaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contraseniatxt = new System.Windows.Forms.TextBox();
            this.NombreUsuariotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.repetirContraseniatxt = new System.Windows.Forms.TextBox();
            this.iniciarSesionBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearCuentaBtn
            // 
            this.CrearCuentaBtn.Location = new System.Drawing.Point(431, 301);
            this.CrearCuentaBtn.Name = "CrearCuentaBtn";
            this.CrearCuentaBtn.Size = new System.Drawing.Size(100, 23);
            this.CrearCuentaBtn.TabIndex = 11;
            this.CrearCuentaBtn.Text = "Crear Cuenta";
            this.CrearCuentaBtn.UseVisualStyleBackColor = true;
            this.CrearCuentaBtn.Click += new System.EventHandler(this.CrearCuentaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(333, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(333, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(336, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(336, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 2);
            this.panel1.TabIndex = 15;
            // 
            // Contraseniatxt
            // 
            this.Contraseniatxt.Location = new System.Drawing.Point(336, 167);
            this.Contraseniatxt.Name = "Contraseniatxt";
            this.Contraseniatxt.PasswordChar = '*';
            this.Contraseniatxt.Size = new System.Drawing.Size(408, 20);
            this.Contraseniatxt.TabIndex = 14;
            this.Contraseniatxt.UseSystemPasswordChar = true;
            // 
            // NombreUsuariotxt
            // 
            this.NombreUsuariotxt.Location = new System.Drawing.Point(336, 101);
            this.NombreUsuariotxt.Name = "NombreUsuariotxt";
            this.NombreUsuariotxt.Size = new System.Drawing.Size(408, 20);
            this.NombreUsuariotxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(333, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Repetir Contraseña";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(336, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 2);
            this.panel3.TabIndex = 20;
            // 
            // repetirContraseniatxt
            // 
            this.repetirContraseniatxt.Location = new System.Drawing.Point(336, 245);
            this.repetirContraseniatxt.Name = "repetirContraseniatxt";
            this.repetirContraseniatxt.PasswordChar = '*';
            this.repetirContraseniatxt.Size = new System.Drawing.Size(408, 20);
            this.repetirContraseniatxt.TabIndex = 19;
            this.repetirContraseniatxt.UseSystemPasswordChar = true;
            // 
            // iniciarSesionBtn
            // 
            this.iniciarSesionBtn.Location = new System.Drawing.Point(431, 346);
            this.iniciarSesionBtn.Name = "iniciarSesionBtn";
            this.iniciarSesionBtn.Size = new System.Drawing.Size(118, 27);
            this.iniciarSesionBtn.TabIndex = 22;
            this.iniciarSesionBtn.Text = "Volver a iniciar sesión";
            this.iniciarSesionBtn.UseVisualStyleBackColor = true;
            this.iniciarSesionBtn.Click += new System.EventHandler(this.iniciarSesionBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpCampeonatoFutbolUI.Properties.Resources.logo_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(42, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 205);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(768, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 32);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iniciarSesionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.repetirContraseniatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Contraseniatxt);
            this.Controls.Add(this.NombreUsuariotxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CrearCuentaBtn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CrearCuentaBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Contraseniatxt;
        private System.Windows.Forms.TextBox NombreUsuariotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox repetirContraseniatxt;
        private System.Windows.Forms.Button iniciarSesionBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}