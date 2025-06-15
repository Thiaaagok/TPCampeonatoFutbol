namespace TPCampeonatoFutbol.Formularios.jugadores
{
    partial class FRMEditarJugador
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
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.crearJugadorBtn = new System.Windows.Forms.Button();
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
            // edadNumeric
            // 
            this.edadNumeric.Location = new System.Drawing.Point(16, 153);
            this.edadNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(269, 20);
            this.edadNumeric.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Edad";
            // 
            // crearJugadorBtn
            // 
            this.crearJugadorBtn.Location = new System.Drawing.Point(56, 386);
            this.crearJugadorBtn.Name = "crearJugadorBtn";
            this.crearJugadorBtn.Size = new System.Drawing.Size(167, 35);
            this.crearJugadorBtn.TabIndex = 55;
            this.crearJugadorBtn.Text = "CREAR JUGADOR";
            this.crearJugadorBtn.UseVisualStyleBackColor = true;
            // 
            // dniNumeric
            // 
            this.dniNumeric.Location = new System.Drawing.Point(15, 209);
            this.dniNumeric.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.dniNumeric.Name = "dniNumeric";
            this.dniNumeric.Size = new System.Drawing.Size(269, 20);
            this.dniNumeric.TabIndex = 54;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(12, 267);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(272, 20);
            this.fechaNacimiento.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "DNI";
            // 
            // lugarNacimientotxt
            // 
            this.lugarNacimientotxt.Location = new System.Drawing.Point(12, 327);
            this.lugarNacimientotxt.Multiline = true;
            this.lugarNacimientotxt.Name = "lugarNacimientotxt";
            this.lugarNacimientotxt.Size = new System.Drawing.Size(273, 38);
            this.lugarNacimientotxt.TabIndex = 51;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(15, 90);
            this.apellidotxt.Multiline = true;
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(273, 35);
            this.apellidotxt.TabIndex = 50;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(15, 28);
            this.nombretxt.Multiline = true;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(273, 35);
            this.nombretxt.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Lugar de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre";
            // 
            // EditarJugadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
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
            this.Name = "EditarJugadorForm";
            this.Text = "EditarJugadorForm";
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown edadNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button crearJugadorBtn;
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