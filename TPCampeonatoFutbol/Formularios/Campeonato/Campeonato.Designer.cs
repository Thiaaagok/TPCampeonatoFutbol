namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    partial class Campeonato
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
            this.generarCampeonatoBtn = new System.Windows.Forms.Button();
            this.fechasBtn = new FontAwesome.Sharp.IconButton();
            this.tablaBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPEONATO";
            // 
            // generarCampeonatoBtn
            // 
            this.generarCampeonatoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCampeonatoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generarCampeonatoBtn.Location = new System.Drawing.Point(229, 167);
            this.generarCampeonatoBtn.Name = "generarCampeonatoBtn";
            this.generarCampeonatoBtn.Size = new System.Drawing.Size(356, 125);
            this.generarCampeonatoBtn.TabIndex = 1;
            this.generarCampeonatoBtn.Text = "GENERAR CAMPEONATO";
            this.generarCampeonatoBtn.UseVisualStyleBackColor = true;
            this.generarCampeonatoBtn.Visible = false;
            this.generarCampeonatoBtn.Click += new System.EventHandler(this.generarCampeonatoBtn_Click);
            // 
            // fechasBtn
            // 
            this.fechasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechasBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.fechasBtn.IconColor = System.Drawing.Color.Black;
            this.fechasBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fechasBtn.Location = new System.Drawing.Point(497, 167);
            this.fechasBtn.Name = "fechasBtn";
            this.fechasBtn.Size = new System.Drawing.Size(295, 110);
            this.fechasBtn.TabIndex = 2;
            this.fechasBtn.Text = "FECHAS";
            this.fechasBtn.UseVisualStyleBackColor = true;
            this.fechasBtn.Visible = false;
            this.fechasBtn.Click += new System.EventHandler(this.fechasBtn_Click);
            // 
            // tablaBtn
            // 
            this.tablaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tablaBtn.IconColor = System.Drawing.Color.Black;
            this.tablaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tablaBtn.Location = new System.Drawing.Point(12, 167);
            this.tablaBtn.Name = "tablaBtn";
            this.tablaBtn.Size = new System.Drawing.Size(295, 110);
            this.tablaBtn.TabIndex = 3;
            this.tablaBtn.Text = "TABLA";
            this.tablaBtn.UseVisualStyleBackColor = true;
            this.tablaBtn.Visible = false;
            this.tablaBtn.Click += new System.EventHandler(this.tablaBtn_Click);
            // 
            // Campeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 325);
            this.Controls.Add(this.tablaBtn);
            this.Controls.Add(this.fechasBtn);
            this.Controls.Add(this.generarCampeonatoBtn);
            this.Controls.Add(this.label1);
            this.Name = "Campeonato";
            this.Text = "Campeonato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarCampeonatoBtn;
        private FontAwesome.Sharp.IconButton fechasBtn;
        private FontAwesome.Sharp.IconButton tablaBtn;
    }
}