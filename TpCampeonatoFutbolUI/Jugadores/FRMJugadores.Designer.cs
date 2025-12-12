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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJugadores
            // 
            this.dataGridViewJugadores.AllowUserToAddRows = false;
            this.dataGridViewJugadores.AllowUserToDeleteRows = false;
            this.dataGridViewJugadores.AllowUserToResizeColumns = false;
            this.dataGridViewJugadores.AllowUserToResizeRows = false;
            this.dataGridViewJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugadores.Location = new System.Drawing.Point(22, 83);
            this.dataGridViewJugadores.Name = "dataGridViewJugadores";
            this.dataGridViewJugadores.Size = new System.Drawing.Size(925, 371);
            this.dataGridViewJugadores.TabIndex = 1;
            this.dataGridViewJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJugadores_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(22, 45);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(772, 32);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
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
            this.RefreshButton.Location = new System.Drawing.Point(800, 33);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(57, 44);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FRMJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 490);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Name = "FRMJugadores";
            this.Text = "FRMJugadores";
            this.Load += new System.EventHandler(this.FRMJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}