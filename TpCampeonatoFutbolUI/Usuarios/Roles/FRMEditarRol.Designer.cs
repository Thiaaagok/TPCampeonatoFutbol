namespace TpCampeonatoFutbolUI.Usuarios.Roles
{
    partial class FRMEditarRol
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
            this.EditarRolBtn = new System.Windows.Forms.Button();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.permisosListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(10, 167);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(121, 44);
            this.CancelarBTN.TabIndex = 38;
            this.CancelarBTN.Text = "CANCELAR";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            // 
            // EditarRolBtn
            // 
            this.EditarRolBtn.Location = new System.Drawing.Point(139, 167);
            this.EditarRolBtn.Name = "EditarRolBtn";
            this.EditarRolBtn.Size = new System.Drawing.Size(121, 44);
            this.EditarRolBtn.TabIndex = 37;
            this.EditarRolBtn.Text = "EDITAR ROL";
            this.EditarRolBtn.UseVisualStyleBackColor = true;
            // 
            // descripcionText
            // 
            this.descripcionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionText.Location = new System.Drawing.Point(10, 47);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(250, 34);
            this.descripcionText.TabIndex = 36;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(6, 20);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(110, 24);
            this.descripcionLabel.TabIndex = 35;
            this.descripcionLabel.Text = "Descripción";
            // 
            // CodigoText
            // 
            this.CodigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoText.Location = new System.Drawing.Point(10, 111);
            this.CodigoText.Multiline = true;
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(250, 34);
            this.CodigoText.TabIndex = 34;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(6, 84);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(71, 24);
            this.codigoLabel.TabIndex = 33;
            this.codigoLabel.Text = "Código";
            // 
            // permisosListBox
            // 
            this.permisosListBox.FormattingEnabled = true;
            this.permisosListBox.Location = new System.Drawing.Point(266, 12);
            this.permisosListBox.Name = "permisosListBox";
            this.permisosListBox.Size = new System.Drawing.Size(353, 289);
            this.permisosListBox.TabIndex = 32;
            // 
            // FRMEditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 314);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.EditarRolBtn);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.permisosListBox);
            this.Name = "FRMEditarRol";
            this.Text = "FRMEditarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.Button EditarRolBtn;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.CheckedListBox permisosListBox;
    }
}