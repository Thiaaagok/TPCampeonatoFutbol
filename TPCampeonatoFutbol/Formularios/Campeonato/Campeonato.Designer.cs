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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPEONATO";
            // 
            // generarCampeonatoBtn
            // 
            this.generarCampeonatoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCampeonatoBtn.Location = new System.Drawing.Point(250, 220);
            this.generarCampeonatoBtn.Name = "generarCampeonatoBtn";
            this.generarCampeonatoBtn.Size = new System.Drawing.Size(356, 125);
            this.generarCampeonatoBtn.TabIndex = 1;
            this.generarCampeonatoBtn.Text = "GENERAR CAMPEONATO";
            this.generarCampeonatoBtn.UseVisualStyleBackColor = true;
            this.generarCampeonatoBtn.Click += new System.EventHandler(this.generarCampeonatoBtn_Click);
            // 
            // Campeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 516);
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
    }
}