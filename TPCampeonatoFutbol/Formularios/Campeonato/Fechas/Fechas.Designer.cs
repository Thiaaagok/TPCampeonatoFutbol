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
            this.cerrarAplicacionBtn = new FontAwesome.Sharp.IconButton();
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
            this.cerrarAplicacionBtn.Location = new System.Drawing.Point(923, 23);
            this.cerrarAplicacionBtn.Name = "cerrarAplicacionBtn";
            this.cerrarAplicacionBtn.Size = new System.Drawing.Size(29, 32);
            this.cerrarAplicacionBtn.TabIndex = 62;
            this.cerrarAplicacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarAplicacionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarAplicacionBtn.UseVisualStyleBackColor = false;
            this.cerrarAplicacionBtn.Click += new System.EventHandler(this.cerrarAplicacionBtn_Click);
            // 
            // Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 413);
            this.Controls.Add(this.cerrarAplicacionBtn);
            this.Name = "Fechas";
            this.Text = "Fechas";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton cerrarAplicacionBtn;
    }
}