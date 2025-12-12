namespace TPCampeonatoFutbol.Formularios.Usuarios
{
    partial class FRMEditarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.editarUsuarioBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "ADMIN",
            "JUGADOR",
            "DT",
            "ORGANIZADOR"});
            this.comboRol.Location = new System.Drawing.Point(50, 111);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(138, 21);
            this.comboRol.TabIndex = 2;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(50, 66);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(138, 20);
            this.nombreUsuarioTxt.TabIndex = 3;
            // 
            // editarUsuarioBtn
            // 
            this.editarUsuarioBtn.Location = new System.Drawing.Point(36, 165);
            this.editarUsuarioBtn.Name = "editarUsuarioBtn";
            this.editarUsuarioBtn.Size = new System.Drawing.Size(167, 35);
            this.editarUsuarioBtn.TabIndex = 56;
            this.editarUsuarioBtn.Text = "EDITAR USUARIO";
            this.editarUsuarioBtn.UseVisualStyleBackColor = true;
            this.editarUsuarioBtn.Click += new System.EventHandler(this.editarUsuarioBtn_Click);
            // 
            // FRMEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 236);
            this.Controls.Add(this.editarUsuarioBtn);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMEditarUsuario";
            this.Text = "FRMEditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.Button editarUsuarioBtn;
    }
}