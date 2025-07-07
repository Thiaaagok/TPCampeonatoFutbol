namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    partial class RegistrarExpulsionFRM
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
            this.equiposCombo = new System.Windows.Forms.ComboBox();
            this.jugadoresCombo = new System.Windows.Forms.ComboBox();
            this.causasCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarExpulsionBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // equiposCombo
            // 
            this.equiposCombo.FormattingEnabled = true;
            this.equiposCombo.Location = new System.Drawing.Point(41, 46);
            this.equiposCombo.Name = "equiposCombo";
            this.equiposCombo.Size = new System.Drawing.Size(248, 21);
            this.equiposCombo.TabIndex = 0;
            // 
            // jugadoresCombo
            // 
            this.jugadoresCombo.FormattingEnabled = true;
            this.jugadoresCombo.Location = new System.Drawing.Point(41, 109);
            this.jugadoresCombo.Name = "jugadoresCombo";
            this.jugadoresCombo.Size = new System.Drawing.Size(248, 21);
            this.jugadoresCombo.TabIndex = 1;
            // 
            // causasCombo
            // 
            this.causasCombo.FormattingEnabled = true;
            this.causasCombo.Items.AddRange(new object[] {
            "Tarjeta roja directa",
            "Doble tarjeta amarilla",
            "Juego brusco grave",
            "Conducta antideportiva",
            "Protestar decisiones arbitrales",
            "Entradas violentas",
            "Lenguaje o gestos ofensivos",
            "Evitar un gol con mano intencional",
            "Agredir a un adversario",
            "Incumplimiento reiterado de las reglas",
            "Retrasar la reanudación del juego",
            "Salir del área de juego para impedir un ataque",
            "Insultar o provocar a rivales o árbitros"});
            this.causasCombo.Location = new System.Drawing.Point(41, 172);
            this.causasCombo.Name = "causasCombo";
            this.causasCombo.Size = new System.Drawing.Size(248, 21);
            this.causasCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jugador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Causa";
            // 
            // registrarExpulsionBtn
            // 
            this.registrarExpulsionBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registrarExpulsionBtn.IconColor = System.Drawing.Color.Black;
            this.registrarExpulsionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarExpulsionBtn.Location = new System.Drawing.Point(93, 225);
            this.registrarExpulsionBtn.Name = "registrarExpulsionBtn";
            this.registrarExpulsionBtn.Size = new System.Drawing.Size(115, 38);
            this.registrarExpulsionBtn.TabIndex = 6;
            this.registrarExpulsionBtn.Text = "Registrar Expulsión";
            this.registrarExpulsionBtn.UseVisualStyleBackColor = true;
            this.registrarExpulsionBtn.Click += new System.EventHandler(this.registrarExpulsionBtn_Click);
            // 
            // RegistrarExpulsionFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 290);
            this.Controls.Add(this.registrarExpulsionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.causasCombo);
            this.Controls.Add(this.jugadoresCombo);
            this.Controls.Add(this.equiposCombo);
            this.Name = "RegistrarExpulsionFRM";
            this.Text = "RegistrarExpulsionFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equiposCombo;
        private System.Windows.Forms.ComboBox jugadoresCombo;
        private System.Windows.Forms.ComboBox causasCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton registrarExpulsionBtn;
    }
}