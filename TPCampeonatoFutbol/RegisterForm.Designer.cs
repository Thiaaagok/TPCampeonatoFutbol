namespace TPCampeonatoFutbol
{
    partial class RegisterForm
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
            this.Contrasenialbl = new System.Windows.Forms.Label();
            this.NombreUsuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.CrearCuentabtn = new System.Windows.Forms.Button();
            this.RepContraseñalbl = new System.Windows.Forms.Label();
            this.RepContraseniatxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NombreUsuariolbl
            // 
            this.NombreUsuariolbl.AutoSize = true;
            this.NombreUsuariolbl.Location = new System.Drawing.Point(297, 53);
            this.NombreUsuariolbl.Name = "NombreUsuariolbl";
            this.NombreUsuariolbl.Size = new System.Drawing.Size(98, 13);
            this.NombreUsuariolbl.TabIndex = 7;
            this.NombreUsuariolbl.Text = "Nombre de Usuario";
            // 
            // Contrasenialbl
            // 
            this.Contrasenialbl.AutoSize = true;
            this.Contrasenialbl.Location = new System.Drawing.Point(297, 97);
            this.Contrasenialbl.Name = "Contrasenialbl";
            this.Contrasenialbl.Size = new System.Drawing.Size(61, 13);
            this.Contrasenialbl.TabIndex = 8;
            this.Contrasenialbl.Text = "Contraseña";
            // 
            // NombreUsuariotxt
            // 
            this.NombreUsuariotxt.Location = new System.Drawing.Point(300, 69);
            this.NombreUsuariotxt.Name = "NombreUsuariotxt";
            this.NombreUsuariotxt.Size = new System.Drawing.Size(100, 20);
            this.NombreUsuariotxt.TabIndex = 9;
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Location = new System.Drawing.Point(300, 113);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(100, 20);
            this.Contraseñatxt.TabIndex = 10;
            // 
            // CrearCuentabtn
            // 
            this.CrearCuentabtn.Location = new System.Drawing.Point(295, 213);
            this.CrearCuentabtn.Name = "CrearCuentabtn";
            this.CrearCuentabtn.Size = new System.Drawing.Size(100, 23);
            this.CrearCuentabtn.TabIndex = 11;
            this.CrearCuentabtn.Text = "Crear Cuenta";
            this.CrearCuentabtn.UseVisualStyleBackColor = true;
            // 
            // RepContraseñalbl
            // 
            this.RepContraseñalbl.AutoSize = true;
            this.RepContraseñalbl.Location = new System.Drawing.Point(297, 145);
            this.RepContraseñalbl.Name = "RepContraseñalbl";
            this.RepContraseñalbl.Size = new System.Drawing.Size(108, 13);
            this.RepContraseñalbl.TabIndex = 12;
            this.RepContraseñalbl.Text = "Confirmar Contraseña";
            // 
            // RepContraseniatxt
            // 
            this.RepContraseniatxt.Location = new System.Drawing.Point(300, 173);
            this.RepContraseniatxt.Name = "RepContraseniatxt";
            this.RepContraseniatxt.Size = new System.Drawing.Size(100, 20);
            this.RepContraseniatxt.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RepContraseniatxt);
            this.Controls.Add(this.RepContraseñalbl);
            this.Controls.Add(this.CrearCuentabtn);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.NombreUsuariotxt);
            this.Controls.Add(this.Contrasenialbl);
            this.Controls.Add(this.NombreUsuariolbl);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreUsuariolbl;
        private System.Windows.Forms.Label Contrasenialbl;
        private System.Windows.Forms.TextBox NombreUsuariotxt;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.Button CrearCuentabtn;
        private System.Windows.Forms.Label RepContraseñalbl;
        private System.Windows.Forms.TextBox RepContraseniatxt;
    }
}