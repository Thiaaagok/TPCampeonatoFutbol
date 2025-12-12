namespace TpCampeonatoFutbolUI.Usuarios.Roles
{
    partial class FRMCrearRol
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
            this.CrearRolBtn = new System.Windows.Forms.Button();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.permisosListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(14, 167);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(121, 44);
            this.CancelarBTN.TabIndex = 31;
            this.CancelarBTN.Text = "CANCELAR";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            // 
            // CrearRolBtn
            // 
            this.CrearRolBtn.Location = new System.Drawing.Point(143, 167);
            this.CrearRolBtn.Name = "CrearRolBtn";
            this.CrearRolBtn.Size = new System.Drawing.Size(121, 44);
            this.CrearRolBtn.TabIndex = 30;
            this.CrearRolBtn.Text = "CREAR ROL";
            this.CrearRolBtn.UseVisualStyleBackColor = true;
            // 
            // descripcionText
            // 
            this.descripcionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionText.Location = new System.Drawing.Point(14, 47);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(250, 34);
            this.descripcionText.TabIndex = 29;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(10, 20);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(110, 24);
            this.descripcionLabel.TabIndex = 28;
            this.descripcionLabel.Text = "Descripción";
            // 
            // CodigoText
            // 
            this.CodigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoText.Location = new System.Drawing.Point(14, 111);
            this.CodigoText.Multiline = true;
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(250, 34);
            this.CodigoText.TabIndex = 27;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(10, 84);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(71, 24);
            this.codigoLabel.TabIndex = 26;
            this.codigoLabel.Text = "Código";
            // 
            // permisosListBox
            // 
            this.permisosListBox.FormattingEnabled = true;
            this.permisosListBox.Location = new System.Drawing.Point(270, 12);
            this.permisosListBox.Name = "permisosListBox";
            this.permisosListBox.Size = new System.Drawing.Size(353, 289);
            this.permisosListBox.TabIndex = 25;
            // 
            // FRMCrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 318);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.CrearRolBtn);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.permisosListBox);
            this.Name = "FRMCrearRol";
            this.Text = "FRMCrearRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.Button CrearRolBtn;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.CheckedListBox permisosListBox;
    }
}