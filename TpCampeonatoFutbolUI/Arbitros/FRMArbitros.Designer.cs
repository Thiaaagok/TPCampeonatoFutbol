namespace TPCampeonatoFutbol.Formularios.Arbitros
{
    partial class FRMArbitros
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
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.dataGridViewArbitros = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbitros)).BeginInit();
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
            this.volverBtn.Location = new System.Drawing.Point(725, 6);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(57, 45);
            this.volverBtn.TabIndex = 19;
            this.volverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.volverBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
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
            this.RefreshButton.Location = new System.Drawing.Point(898, 6);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(57, 45);
            this.RefreshButton.TabIndex = 18;
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewArbitros
            // 
            this.dataGridViewArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArbitros.Location = new System.Drawing.Point(30, 57);
            this.dataGridViewArbitros.Name = "dataGridViewArbitros";
            this.dataGridViewArbitros.Size = new System.Drawing.Size(925, 371);
            this.dataGridViewArbitros.TabIndex = 17;
            this.dataGridViewArbitros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArbitros_CellContentClick_1);
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
            this.NuevoButton.Location = new System.Drawing.Point(803, 6);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(57, 45);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // FRMArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 455);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridViewArbitros);
            this.Name = "FRMArbitros";
            this.Text = "FRMArbitros";
            this.Load += new System.EventHandler(this.FRMArbitros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbitros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton volverBtn;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private System.Windows.Forms.DataGridView dataGridViewArbitros;
        private FontAwesome.Sharp.IconButton NuevoButton;
    }
}