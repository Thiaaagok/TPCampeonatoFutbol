namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    partial class RegistrarGolFRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jugadoresCombo = new System.Windows.Forms.ComboBox();
            this.equiposCombo = new System.Windows.Forms.ComboBox();
            this.registrarGolBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jugador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Equipo";
            // 
            // jugadoresCombo
            // 
            this.jugadoresCombo.FormattingEnabled = true;
            this.jugadoresCombo.Location = new System.Drawing.Point(42, 110);
            this.jugadoresCombo.Name = "jugadoresCombo";
            this.jugadoresCombo.Size = new System.Drawing.Size(225, 21);
            this.jugadoresCombo.TabIndex = 8;
            // 
            // equiposCombo
            // 
            this.equiposCombo.FormattingEnabled = true;
            this.equiposCombo.Location = new System.Drawing.Point(42, 47);
            this.equiposCombo.Name = "equiposCombo";
            this.equiposCombo.Size = new System.Drawing.Size(225, 21);
            this.equiposCombo.TabIndex = 7;
            this.equiposCombo.SelectedIndexChanged += new System.EventHandler(this.equiposCombo_SelectedIndexChanged);
            // 
            // registrarGolBtn
            // 
            this.registrarGolBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registrarGolBtn.IconColor = System.Drawing.Color.Black;
            this.registrarGolBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarGolBtn.Location = new System.Drawing.Point(95, 154);
            this.registrarGolBtn.Name = "registrarGolBtn";
            this.registrarGolBtn.Size = new System.Drawing.Size(115, 38);
            this.registrarGolBtn.TabIndex = 13;
            this.registrarGolBtn.Text = "Registrar Gol";
            this.registrarGolBtn.UseVisualStyleBackColor = true;
            this.registrarGolBtn.Click += new System.EventHandler(this.registrarGolBtn_Click);
            // 
            // RegistrarGolFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 208);
            this.Controls.Add(this.registrarGolBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jugadoresCombo);
            this.Controls.Add(this.equiposCombo);
            this.Name = "RegistrarGolFRM";
            this.Text = "RegistrarGolFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton registrarGolBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jugadoresCombo;
        private System.Windows.Forms.ComboBox equiposCombo;
    }
}