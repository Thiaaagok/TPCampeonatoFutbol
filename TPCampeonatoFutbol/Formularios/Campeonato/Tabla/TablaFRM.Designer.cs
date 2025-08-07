namespace TPCampeonatoFutbol.Formularios.Campeonato.Tabla
{
    partial class TablaFRM
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
            this.tablaDataGridView = new System.Windows.Forms.DataGridView();
            this.volverBtn = new FontAwesome.Sharp.IconButton();
            this.exportarExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDataGridView
            // 
            this.tablaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDataGridView.Location = new System.Drawing.Point(88, 61);
            this.tablaDataGridView.Name = "tablaDataGridView";
            this.tablaDataGridView.Size = new System.Drawing.Size(608, 377);
            this.tablaDataGridView.TabIndex = 0;
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
            this.volverBtn.Location = new System.Drawing.Point(656, 10);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(57, 45);
            this.volverBtn.TabIndex = 20;
            this.volverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.volverBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.exportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportarExcel.ForeColor = System.Drawing.Color.White;
            this.exportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.exportarExcel.IconColor = System.Drawing.Color.White;
            this.exportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportarExcel.IconSize = 45;
            this.exportarExcel.Location = new System.Drawing.Point(731, 10);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(57, 45);
            this.exportarExcel.TabIndex = 21;
            this.exportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // TablaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.tablaDataGridView);
            this.Name = "TablaFRM";
            this.Text = "TablaFRM";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDataGridView;
        private FontAwesome.Sharp.IconButton volverBtn;
        private FontAwesome.Sharp.IconButton exportarExcel;
    }
}