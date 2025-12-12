namespace TpCampeonatoFutbolUI.Usuarios.Permisos
{
    partial class FRMPermisos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new FontAwesome.Sharp.IconButton();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 49);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(374, 32);
            this.txtBuscar.TabIndex = 15;
            // 
            // dataGridViewPermisos
            // 
            this.dataGridViewPermisos.AllowUserToAddRows = false;
            this.dataGridViewPermisos.AllowUserToDeleteRows = false;
            this.dataGridViewPermisos.AllowUserToResizeColumns = false;
            this.dataGridViewPermisos.AllowUserToResizeRows = false;
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            this.dataGridViewPermisos.Size = new System.Drawing.Size(374, 359);
            this.dataGridViewPermisos.TabIndex = 13;
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
            this.NuevoButton.Location = new System.Drawing.Point(469, 37);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(57, 45);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = false;
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
            this.RefreshButton.Location = new System.Drawing.Point(392, 37);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(57, 44);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // FRMPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 479);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Name = "FRMPermisos";
            this.Text = "FRMPermisos";
            this.Load += new System.EventHandler(this.FRMPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
        private FontAwesome.Sharp.IconButton NuevoButton;
    }
}