namespace TPCampeonatoFutbol.Formularios.jugadores
{
    partial class FRMCrearJugador
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
            this.label6 = new System.Windows.Forms.Label();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lugarNacimientotxt = new System.Windows.Forms.TextBox();
            this.dniNumeric = new System.Windows.Forms.NumericUpDown();
            this.crearJugadorBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.cerrarAplicacionBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dniNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(9, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "DNI";
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(12, 93);
            this.apellidotxt.Multiline = true;
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(273, 35);
            this.apellidotxt.TabIndex = 34;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(12, 31);
            this.nombretxt.Multiline = true;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(273, 35);
            this.nombretxt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lugar de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(9, 270);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(272, 20);
            this.fechaNacimiento.TabIndex = 40;
            // 
            // lugarNacimientotxt
            // 
            this.lugarNacimientotxt.Location = new System.Drawing.Point(9, 330);
            this.lugarNacimientotxt.Multiline = true;
            this.lugarNacimientotxt.Name = "lugarNacimientotxt";
            this.lugarNacimientotxt.Size = new System.Drawing.Size(273, 38);
            this.lugarNacimientotxt.TabIndex = 35;
            // 
            // dniNumeric
            // 
            this.dniNumeric.Location = new System.Drawing.Point(12, 212);
            this.dniNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.dniNumeric.Name = "dniNumeric";
            this.dniNumeric.Size = new System.Drawing.Size(269, 20);
            this.dniNumeric.TabIndex = 41;
            // 
            // crearJugadorBtn
            // 
            this.crearJugadorBtn.Location = new System.Drawing.Point(53, 389);
            this.crearJugadorBtn.Name = "crearJugadorBtn";
            this.crearJugadorBtn.Size = new System.Drawing.Size(167, 35);
            this.crearJugadorBtn.TabIndex = 42;
            this.crearJugadorBtn.Text = "CREAR JUGADOR";
            this.crearJugadorBtn.UseVisualStyleBackColor = true;
            this.crearJugadorBtn.Click += new System.EventHandler(this.crearJugadorBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Edad";
            // 
            // edadNumeric
            // 
            this.edadNumeric.Location = new System.Drawing.Point(13, 156);
            this.edadNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(269, 20);
            this.edadNumeric.TabIndex = 44;
            // 
            // cerrarAplicacionBtn
            // 
            this.cerrarAplicacionBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.cerrarAplicacionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarAplicacionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cerrarAplicacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarAplicacionBtn.ForeColor = System.Drawing.Color.White;
            this.cerrarAplicacionBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.cerrarAplicacionBtn.IconColor = System.Drawing.Color.Red;
            this.cerrarAplicacionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarAplicacionBtn.IconSize = 25;
            this.cerrarAplicacionBtn.Location = new System.Drawing.Point(291, 5);
            this.cerrarAplicacionBtn.Name = "cerrarAplicacionBtn";
            this.cerrarAplicacionBtn.Size = new System.Drawing.Size(29, 32);
            this.cerrarAplicacionBtn.TabIndex = 62;
            this.cerrarAplicacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarAplicacionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarAplicacionBtn.UseVisualStyleBackColor = false;
            this.cerrarAplicacionBtn.Click += new System.EventHandler(this.cerrarAplicacionBtn_Click);
            // 
            // FRMCrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.cerrarAplicacionBtn);
            this.Controls.Add(this.edadNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crearJugadorBtn);
            this.Controls.Add(this.dniNumeric);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lugarNacimientotxt);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMCrearJugador";
            this.Text = "CrearJugadorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dniNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.TextBox lugarNacimientotxt;
        private System.Windows.Forms.NumericUpDown dniNumeric;
        private System.Windows.Forms.Button crearJugadorBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edadNumeric;
        private FontAwesome.Sharp.IconButton cerrarAplicacionBtn;
    }
}