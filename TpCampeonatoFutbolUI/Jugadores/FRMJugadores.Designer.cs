namespace TPCampeonatoFutbol.Formularios.Jugadores
{
    partial class FRMJugadores
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
            this.dataGridViewJugadores = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.volverBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJugadores
            // 
            this.dataGridViewJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugadores.Location = new System.Drawing.Point(22, 83);
            this.dataGridViewJugadores.Name = "dataGridViewJugadores";
            this.dataGridViewJugadores.Size = new System.Drawing.Size(925, 371);
            this.dataGridViewJugadores.TabIndex = 1;
            this.dataGridViewJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJugadores_CellContentClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            this.RefreshButton.IconColor = System.Drawing.Color.White;
            this.RefreshButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshButton.IconSize = 45;
            this.RefreshButton.Location = new System.Drawing.Point(890, 32);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(57, 45);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.volverBtn.Location = new System.Drawing.Point(811, 32);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(57, 45);
            this.volverBtn.TabIndex = 16;
            this.volverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.volverBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // FRMJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 490);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Name = "FRMJugadores";
            this.Text = "FRMJugadores";
            this.Load += new System.EventHandler(this.FRMJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private FontAwesome.Sharp.IconButton volverBtn;
    }
}