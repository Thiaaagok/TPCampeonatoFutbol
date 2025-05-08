namespace TPCampeonatoFutbol
{
    partial class LoginForm
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
            this.NombreUsuariolbl = new System.Windows.Forms.Label();
            this.Contraseñalbl = new System.Windows.Forms.Label();
            this.NombreUsuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseniatxt = new System.Windows.Forms.TextBox();
            this.IniciarSesionbtn = new System.Windows.Forms.Button();
            this.crearCuentaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreUsuariolbl
            // 
            this.NombreUsuariolbl.AutoSize = true;
            this.NombreUsuariolbl.Location = new System.Drawing.Point(325, 99);
            this.NombreUsuariolbl.Name = "NombreUsuariolbl";
            this.NombreUsuariolbl.Size = new System.Drawing.Size(98, 13);
            this.NombreUsuariolbl.TabIndex = 0;
            this.NombreUsuariolbl.Text = "Nombre de Usuario";
            this.NombreUsuariolbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contraseñalbl
            // 
            this.Contraseñalbl.AutoSize = true;
            this.Contraseñalbl.Location = new System.Drawing.Point(325, 143);
            this.Contraseñalbl.Name = "Contraseñalbl";
            this.Contraseñalbl.Size = new System.Drawing.Size(61, 13);
            this.Contraseñalbl.TabIndex = 2;
            this.Contraseñalbl.Text = "Contraseña";
            this.Contraseñalbl.Click += new System.EventHandler(this.Contraseñalbl_Click);
            // 
            // NombreUsuariotxt
            // 
            this.NombreUsuariotxt.Location = new System.Drawing.Point(328, 115);
            this.NombreUsuariotxt.Name = "NombreUsuariotxt";
            this.NombreUsuariotxt.Size = new System.Drawing.Size(100, 20);
            this.NombreUsuariotxt.TabIndex = 3;
            this.NombreUsuariotxt.TextChanged += new System.EventHandler(this.NombreUsuariotxt_TextChanged);
            // 
            // Contraseniatxt
            // 
            this.Contraseniatxt.Location = new System.Drawing.Point(328, 159);
            this.Contraseniatxt.Name = "Contraseniatxt";
            this.Contraseniatxt.Size = new System.Drawing.Size(100, 20);
            this.Contraseniatxt.TabIndex = 4;
            this.Contraseniatxt.TextChanged += new System.EventHandler(this.Contraseñatxt_TextChanged);
            // 
            // IniciarSesionbtn
            // 
            this.IniciarSesionbtn.Location = new System.Drawing.Point(328, 194);
            this.IniciarSesionbtn.Name = "IniciarSesionbtn";
            this.IniciarSesionbtn.Size = new System.Drawing.Size(100, 23);
            this.IniciarSesionbtn.TabIndex = 5;
            this.IniciarSesionbtn.Text = "Iniciar Sesión";
            this.IniciarSesionbtn.UseVisualStyleBackColor = true;
            this.IniciarSesionbtn.Click += new System.EventHandler(this.IniciarSesionbtn_Click);
            // 
            // crearCuentaBtn
            // 
            this.crearCuentaBtn.Location = new System.Drawing.Point(208, 194);
            this.crearCuentaBtn.Name = "crearCuentaBtn";
            this.crearCuentaBtn.Size = new System.Drawing.Size(114, 23);
            this.crearCuentaBtn.TabIndex = 6;
            this.crearCuentaBtn.Text = "Crear cuenta";
            this.crearCuentaBtn.UseVisualStyleBackColor = true;
            this.crearCuentaBtn.Click += new System.EventHandler(this.crearCuentaBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crearCuentaBtn);
            this.Controls.Add(this.IniciarSesionbtn);
            this.Controls.Add(this.Contraseniatxt);
            this.Controls.Add(this.NombreUsuariotxt);
            this.Controls.Add(this.Contraseñalbl);
            this.Controls.Add(this.NombreUsuariolbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreUsuariolbl;
        private System.Windows.Forms.Label Contraseñalbl;
        private System.Windows.Forms.TextBox NombreUsuariotxt;
        private System.Windows.Forms.TextBox Contraseniatxt;
        private System.Windows.Forms.Button IniciarSesionbtn;
        private System.Windows.Forms.Button crearCuentaBtn;
    }
}