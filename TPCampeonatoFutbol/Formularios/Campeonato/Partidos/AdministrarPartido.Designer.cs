namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    partial class AdministrarPartido
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
            this.iniciarCronometroBtn = new System.Windows.Forms.Button();
            this.PausarCronometroBTN = new System.Windows.Forms.Button();
            this.acelerar10segundosBtn = new FontAwesome.Sharp.IconButton();
            this.acelerar30segundosBtn = new FontAwesome.Sharp.IconButton();
            this.acelerar1minutoBtn = new System.Windows.Forms.Button();
            this.desacelerarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciarCronometroBtn
            // 
            this.iniciarCronometroBtn.Location = new System.Drawing.Point(3, 55);
            this.iniciarCronometroBtn.Name = "iniciarCronometroBtn";
            this.iniciarCronometroBtn.Size = new System.Drawing.Size(116, 33);
            this.iniciarCronometroBtn.TabIndex = 0;
            this.iniciarCronometroBtn.Text = "Iniciar";
            this.iniciarCronometroBtn.UseVisualStyleBackColor = true;
            this.iniciarCronometroBtn.Click += new System.EventHandler(this.iniciarCronometroBtn_Click);
            // 
            // PausarCronometroBTN
            // 
            this.PausarCronometroBTN.Location = new System.Drawing.Point(3, 94);
            this.PausarCronometroBTN.Name = "PausarCronometroBTN";
            this.PausarCronometroBTN.Size = new System.Drawing.Size(116, 33);
            this.PausarCronometroBTN.TabIndex = 1;
            this.PausarCronometroBTN.Text = "Pausar";
            this.PausarCronometroBTN.UseVisualStyleBackColor = true;
            this.PausarCronometroBTN.Click += new System.EventHandler(this.PausarCronometroBTN_Click);
            // 
            // acelerar10segundosBtn
            // 
            this.acelerar10segundosBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.acelerar10segundosBtn.IconColor = System.Drawing.Color.Black;
            this.acelerar10segundosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acelerar10segundosBtn.IconSize = 30;
            this.acelerar10segundosBtn.Location = new System.Drawing.Point(449, 12);
            this.acelerar10segundosBtn.Name = "acelerar10segundosBtn";
            this.acelerar10segundosBtn.Size = new System.Drawing.Size(26, 33);
            this.acelerar10segundosBtn.TabIndex = 3;
            this.acelerar10segundosBtn.UseVisualStyleBackColor = true;
            this.acelerar10segundosBtn.Click += new System.EventHandler(this.acelerar10segundosBtn_Click);
            // 
            // acelerar30segundosBtn
            // 
            this.acelerar30segundosBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.acelerar30segundosBtn.IconColor = System.Drawing.Color.Black;
            this.acelerar30segundosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acelerar30segundosBtn.IconSize = 30;
            this.acelerar30segundosBtn.Location = new System.Drawing.Point(481, 12);
            this.acelerar30segundosBtn.Name = "acelerar30segundosBtn";
            this.acelerar30segundosBtn.Size = new System.Drawing.Size(26, 33);
            this.acelerar30segundosBtn.TabIndex = 4;
            this.acelerar30segundosBtn.UseVisualStyleBackColor = true;
            this.acelerar30segundosBtn.Click += new System.EventHandler(this.acelerar30segundosBtn_Click);
            // 
            // acelerar1minutoBtn
            // 
            this.acelerar1minutoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acelerar1minutoBtn.Location = new System.Drawing.Point(513, 12);
            this.acelerar1minutoBtn.Name = "acelerar1minutoBtn";
            this.acelerar1minutoBtn.Size = new System.Drawing.Size(52, 33);
            this.acelerar1minutoBtn.TabIndex = 5;
            this.acelerar1minutoBtn.Text = ">>>";
            this.acelerar1minutoBtn.UseVisualStyleBackColor = true;
            this.acelerar1minutoBtn.Click += new System.EventHandler(this.acelerar1minutoBtn_Click);
            // 
            // desacelerarBtn
            // 
            this.desacelerarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desacelerarBtn.Location = new System.Drawing.Point(231, 12);
            this.desacelerarBtn.Name = "desacelerarBtn";
            this.desacelerarBtn.Size = new System.Drawing.Size(52, 33);
            this.desacelerarBtn.TabIndex = 6;
            this.desacelerarBtn.Text = "<<<";
            this.desacelerarBtn.UseVisualStyleBackColor = true;
            this.desacelerarBtn.Click += new System.EventHandler(this.desacelerarBtn_Click);
            // 
            // AdministrarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desacelerarBtn);
            this.Controls.Add(this.acelerar1minutoBtn);
            this.Controls.Add(this.acelerar30segundosBtn);
            this.Controls.Add(this.acelerar10segundosBtn);
            this.Controls.Add(this.PausarCronometroBTN);
            this.Controls.Add(this.iniciarCronometroBtn);
            this.Name = "AdministrarPartido";
            this.Text = "AdministrarPartido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciarCronometroBtn;
        private System.Windows.Forms.Button PausarCronometroBTN;
        private FontAwesome.Sharp.IconButton acelerar10segundosBtn;
        private FontAwesome.Sharp.IconButton acelerar30segundosBtn;
        private System.Windows.Forms.Button acelerar1minutoBtn;
        private System.Windows.Forms.Button desacelerarBtn;
    }
}