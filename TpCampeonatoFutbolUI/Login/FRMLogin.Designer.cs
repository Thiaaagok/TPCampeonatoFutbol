namespace TPCampeonatoFutbol
{
    partial class FRMLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMLogin));
            this.NombreUsuariolbl = new System.Windows.Forms.Label();
            this.NombreUsuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseniatxt = new System.Windows.Forms.TextBox();
            this.IniciarSesionbtn = new System.Windows.Forms.Button();
            this.crearCuentaBtn = new System.Windows.Forms.Button();
            this.labelDummy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreUsuariolbl
            // 
            this.NombreUsuariolbl.AutoSize = true;
            this.NombreUsuariolbl.Location = new System.Drawing.Point(325, 99);
            this.NombreUsuariolbl.Name = "NombreUsuariolbl";
            this.NombreUsuariolbl.Size = new System.Drawing.Size(0, 13);
            this.NombreUsuariolbl.TabIndex = 0;
            // 
            // NombreUsuariotxt
            // 
            this.NombreUsuariotxt.Location = new System.Drawing.Point(314, 154);
            this.NombreUsuariotxt.Multiline = true;
            this.NombreUsuariotxt.Name = "NombreUsuariotxt";
            this.NombreUsuariotxt.Size = new System.Drawing.Size(408, 19);
            this.NombreUsuariotxt.TabIndex = 3;
            // 
            // Contraseniatxt
            // 
            this.Contraseniatxt.AcceptsTab = true;
            this.Contraseniatxt.Location = new System.Drawing.Point(314, 230);
            this.Contraseniatxt.Name = "Contraseniatxt";
            this.Contraseniatxt.PasswordChar = '*';
            this.Contraseniatxt.Size = new System.Drawing.Size(408, 20);
            this.Contraseniatxt.TabIndex = 4;
            this.Contraseniatxt.UseSystemPasswordChar = true;
            // 
            // IniciarSesionbtn
            // 
            this.IniciarSesionbtn.Location = new System.Drawing.Point(307, 308);
            this.IniciarSesionbtn.Name = "IniciarSesionbtn";
            this.IniciarSesionbtn.Size = new System.Drawing.Size(100, 23);
            this.IniciarSesionbtn.TabIndex = 5;
            this.IniciarSesionbtn.Text = "Iniciar Sesión";
            this.IniciarSesionbtn.UseVisualStyleBackColor = true;
            this.IniciarSesionbtn.Click += new System.EventHandler(this.IniciarSesionbtn_Click);
            // 
            // crearCuentaBtn
            // 
            this.crearCuentaBtn.Location = new System.Drawing.Point(307, 351);
            this.crearCuentaBtn.Name = "crearCuentaBtn";
            this.crearCuentaBtn.Size = new System.Drawing.Size(100, 23);
            this.crearCuentaBtn.TabIndex = 6;
            this.crearCuentaBtn.Text = "Crear cuenta";
            this.crearCuentaBtn.UseVisualStyleBackColor = true;
            this.crearCuentaBtn.Click += new System.EventHandler(this.crearCuentaBtn_Click);
            // 
            // labelDummy
            // 
            this.labelDummy.AutoSize = true;
            this.labelDummy.Location = new System.Drawing.Point(5, 21);
            this.labelDummy.Name = "labelDummy";
            this.labelDummy.Size = new System.Drawing.Size(0, 13);
            this.labelDummy.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(314, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(314, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 2);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(311, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 204);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDummy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crearCuentaBtn);
            this.Controls.Add(this.IniciarSesionbtn);
            this.Controls.Add(this.Contraseniatxt);
            this.Controls.Add(this.NombreUsuariotxt);
            this.Controls.Add(this.NombreUsuariolbl);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreUsuariolbl;
        private System.Windows.Forms.TextBox NombreUsuariotxt;
        private System.Windows.Forms.TextBox Contraseniatxt;
        private System.Windows.Forms.Button IniciarSesionbtn;
        private System.Windows.Forms.Button crearCuentaBtn;
        private System.Windows.Forms.Label labelDummy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton cerrarAplicacionBtn;
    }
}