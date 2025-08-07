namespace TPCampeonatoFutbol.Formularios.Arbitros
{
    partial class FRMCrearArbitro
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
            this.cerrarAplicacionBtn = new FontAwesome.Sharp.IconButton();
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.crearArbitroBtn = new System.Windows.Forms.Button();
            this.dniNumeric = new System.Windows.Forms.NumericUpDown();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lugarNacimientotxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniNumeric)).BeginInit();
            this.SuspendLayout();
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
            this.cerrarAplicacionBtn.Location = new System.Drawing.Point(291, 3);
            this.cerrarAplicacionBtn.Name = "cerrarAplicacionBtn";
            this.cerrarAplicacionBtn.Size = new System.Drawing.Size(29, 32);
            this.cerrarAplicacionBtn.TabIndex = 76;
            this.cerrarAplicacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarAplicacionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarAplicacionBtn.UseVisualStyleBackColor = false;
            // 
            // edadNumeric
            // 
            this.edadNumeric.Location = new System.Drawing.Point(13, 154);
            this.edadNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(269, 20);
            this.edadNumeric.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Edad";
            // 
            // crearArbitroBtn
            // 
            this.crearArbitroBtn.Location = new System.Drawing.Point(53, 387);
            this.crearArbitroBtn.Name = "crearArbitroBtn";
            this.crearArbitroBtn.Size = new System.Drawing.Size(167, 35);
            this.crearArbitroBtn.TabIndex = 73;
            this.crearArbitroBtn.Text = "CREAR ARBITRO";
            this.crearArbitroBtn.UseVisualStyleBackColor = true;
            this.crearArbitroBtn.Click += new System.EventHandler(this.crearArbitroBtn_Click);
            // 
            // dniNumeric
            // 
            this.dniNumeric.Location = new System.Drawing.Point(12, 210);
            this.dniNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.dniNumeric.Name = "dniNumeric";
            this.dniNumeric.Size = new System.Drawing.Size(269, 20);
            this.dniNumeric.TabIndex = 72;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(9, 268);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(272, 20);
            this.fechaNacimiento.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "DNI";
            // 
            // lugarNacimientotxt
            // 
            this.lugarNacimientotxt.Location = new System.Drawing.Point(9, 328);
            this.lugarNacimientotxt.Multiline = true;
            this.lugarNacimientotxt.Name = "lugarNacimientotxt";
            this.lugarNacimientotxt.Size = new System.Drawing.Size(273, 38);
            this.lugarNacimientotxt.TabIndex = 69;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(12, 91);
            this.apellidotxt.Multiline = true;
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(273, 35);
            this.apellidotxt.TabIndex = 68;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(12, 29);
            this.nombretxt.Multiline = true;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(273, 35);
            this.nombretxt.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Lugar de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nombre";
            // 
            // FRMCrearArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 427);
            this.Controls.Add(this.cerrarAplicacionBtn);
            this.Controls.Add(this.edadNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crearArbitroBtn);
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
            this.Name = "FRMCrearArbitro";
            this.Text = "FRMCrearArbitro";
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton cerrarAplicacionBtn;
        private System.Windows.Forms.NumericUpDown edadNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button crearArbitroBtn;
        private System.Windows.Forms.NumericUpDown dniNumeric;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lugarNacimientotxt;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}