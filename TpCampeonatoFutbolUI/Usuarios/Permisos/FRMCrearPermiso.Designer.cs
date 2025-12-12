namespace TpCampeonatoFutbolUI.Usuarios.Permisos
{
    partial class FRMCrearPermiso
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.CrearPermisoBtn = new System.Windows.Forms.Button();
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(20, 80);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(71, 24);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Código";
            // 
            // CodigoText
            // 
            this.CodigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoText.Location = new System.Drawing.Point(24, 107);
            this.CodigoText.Multiline = true;
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(250, 34);
            this.CodigoText.TabIndex = 1;
            // 
            // descripcionText
            // 
            this.descripcionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionText.Location = new System.Drawing.Point(24, 43);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(250, 34);
            this.descripcionText.TabIndex = 3;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(20, 16);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(110, 24);
            this.descripcionLabel.TabIndex = 2;
            this.descripcionLabel.Text = "Descripción";
            // 
            // CrearPermisoBtn
            // 
            this.CrearPermisoBtn.Location = new System.Drawing.Point(153, 163);
            this.CrearPermisoBtn.Name = "CrearPermisoBtn";
            this.CrearPermisoBtn.Size = new System.Drawing.Size(121, 44);
            this.CrearPermisoBtn.TabIndex = 11;
            this.CrearPermisoBtn.Text = "CREAR PERMISO";
            this.CrearPermisoBtn.UseVisualStyleBackColor = true;
            this.CrearPermisoBtn.Click += new System.EventHandler(this.CrearPermisoBtn_Click);
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(24, 163);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(121, 44);
            this.CancelarBTN.TabIndex = 12;
            this.CancelarBTN.Text = "CANCELAR";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // FRMCrearPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(308, 219);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.CrearPermisoBtn);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.codigoLabel);
            this.Name = "FRMCrearPermiso";
            this.Text = "FRMCrearPermiso";
            this.Load += new System.EventHandler(this.FRMCrearPermiso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Button CrearPermisoBtn;
        private System.Windows.Forms.Button CancelarBTN;
    }
}