namespace TpCampeonatoFutbolUI.Usuarios.Permisos
{
    partial class FRMEditarPermiso
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
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.EditarPermisoBtn = new System.Windows.Forms.Button();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(25, 161);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(121, 44);
            this.CancelarBTN.TabIndex = 18;
            this.CancelarBTN.Text = "CANCELAR";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // EditarPermisoBtn
            // 
            this.EditarPermisoBtn.Location = new System.Drawing.Point(154, 161);
            this.EditarPermisoBtn.Name = "EditarPermisoBtn";
            this.EditarPermisoBtn.Size = new System.Drawing.Size(121, 44);
            this.EditarPermisoBtn.TabIndex = 17;
            this.EditarPermisoBtn.Text = "EDITAR PERMISO";
            this.EditarPermisoBtn.UseVisualStyleBackColor = true;
            this.EditarPermisoBtn.Click += new System.EventHandler(this.EditarPermisoBtn_Click);
            // 
            // descripcionText
            // 
            this.descripcionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionText.Location = new System.Drawing.Point(25, 41);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(250, 34);
            this.descripcionText.TabIndex = 16;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(21, 14);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(110, 24);
            this.descripcionLabel.TabIndex = 15;
            this.descripcionLabel.Text = "Descripción";
            // 
            // CodigoText
            // 
            this.CodigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoText.Location = new System.Drawing.Point(25, 105);
            this.CodigoText.Multiline = true;
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(250, 34);
            this.CodigoText.TabIndex = 14;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(21, 78);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(71, 24);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "Código";
            // 
            // FRMEditarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 217);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.EditarPermisoBtn);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.codigoLabel);
            this.Name = "FRMEditarPermiso";
            this.Text = "FRMEditarPermiso";
            this.Load += new System.EventHandler(this.FRMEditarPermiso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.Button EditarPermisoBtn;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.Label codigoLabel;
    }
}