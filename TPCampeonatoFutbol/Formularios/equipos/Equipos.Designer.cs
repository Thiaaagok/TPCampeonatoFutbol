namespace TPCampeonatoFutbol
{
    partial class Equipos
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
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.cerrarAplicacionBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.NuevoButton = new FontAwesome.Sharp.IconButton();
            this.volverBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.Size = new System.Drawing.Size(1003, 409);
            this.dataGridViewEquipos.TabIndex = 0;
            this.dataGridViewEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellDoubleClick);
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
            this.cerrarAplicacionBtn.Location = new System.Drawing.Point(995, 1);
            this.cerrarAplicacionBtn.Name = "cerrarAplicacionBtn";
            this.cerrarAplicacionBtn.Size = new System.Drawing.Size(29, 32);
            this.cerrarAplicacionBtn.TabIndex = 14;
            this.cerrarAplicacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarAplicacionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarAplicacionBtn.UseVisualStyleBackColor = false;
            this.cerrarAplicacionBtn.Click += new System.EventHandler(this.cerrarAplicacionBtn_Click);
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
            this.RefreshButton.Location = new System.Drawing.Point(958, 48);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(57, 45);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.ForeColor = System.Drawing.Color.White;
            this.NuevoButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.NuevoButton.IconColor = System.Drawing.Color.White;
            this.NuevoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoButton.IconSize = 45;
            this.NuevoButton.Location = new System.Drawing.Point(885, 48);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(57, 45);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
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
            this.volverBtn.Location = new System.Drawing.Point(813, 48);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(57, 45);
            this.volverBtn.TabIndex = 15;
            this.volverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.volverBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 549);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.cerrarAplicacionBtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.dataGridViewEquipos);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private FontAwesome.Sharp.IconButton cerrarAplicacionBtn;
        private FontAwesome.Sharp.IconButton NuevoButton;
        private FontAwesome.Sharp.IconButton volverBtn;
    }
}