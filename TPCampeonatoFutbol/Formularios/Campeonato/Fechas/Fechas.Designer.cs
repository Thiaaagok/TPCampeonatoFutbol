namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    partial class Fechas
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
            this.volverBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.volverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volverBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.volverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverBtn.ForeColor = System.Drawing.Color.White;
            this.volverBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.volverBtn.IconColor = System.Drawing.Color.White;
            this.volverBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.volverBtn.IconSize = 45;
            this.volverBtn.Location = new System.Drawing.Point(884, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(57, 45);
            this.volverBtn.TabIndex = 63;
            this.volverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.volverBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 413);
            this.Controls.Add(this.volverBtn);
            this.Name = "Fechas";
            this.Text = "Fechas";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton volverBtn;
    }
}