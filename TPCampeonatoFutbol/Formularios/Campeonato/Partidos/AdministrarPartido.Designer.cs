namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    partial class AdministrarPartido
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
            this.acelerar10segundosBtn = new FontAwesome.Sharp.IconButton();
            this.acelerar30segundosBtn = new FontAwesome.Sharp.IconButton();
            this.acelerar1minutoBtn = new System.Windows.Forms.Button();
            this.desacelerarBtn = new System.Windows.Forms.Button();
            this.PausarCronometroBTN = new FontAwesome.Sharp.IconButton();
            this.iniciarCronometroBtn = new FontAwesome.Sharp.IconButton();
            this.golesLocal = new System.Windows.Forms.TextBox();
            this.golesVisitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCortoLocal = new System.Windows.Forms.Label();
            this.nombreCortoVisitante = new System.Windows.Forms.Label();
            this.eventoGolBtn = new FontAwesome.Sharp.IconButton();
            this.eventoExpulsionBtn = new FontAwesome.Sharp.IconButton();
            this.EventoTitulo = new System.Windows.Forms.Label();
            this.tiempoEvento = new System.Windows.Forms.Label();
            this.jugadorEvento = new System.Windows.Forms.Label();
            this.registroEventosList = new System.Windows.Forms.ListBox();
            this.registrarPartidoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acelerar10segundosBtn
            // 
            this.acelerar10segundosBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.acelerar10segundosBtn.IconColor = System.Drawing.Color.Black;
            this.acelerar10segundosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acelerar10segundosBtn.IconSize = 30;
            this.acelerar10segundosBtn.Location = new System.Drawing.Point(436, 12);
            this.acelerar10segundosBtn.Name = "acelerar10segundosBtn";
            this.acelerar10segundosBtn.Size = new System.Drawing.Size(26, 33);
            this.acelerar10segundosBtn.TabIndex = 3;
            this.acelerar10segundosBtn.UseVisualStyleBackColor = true;
            this.acelerar10segundosBtn.Click += new System.EventHandler(this.acelerar10segundosBtn_Click);
            // 
            // acelerar30segundosBtn
            // 
            this.acelerar30segundosBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.acelerar30segundosBtn.IconColor = System.Drawing.Color.Black;
            this.acelerar30segundosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acelerar30segundosBtn.IconSize = 30;
            this.acelerar30segundosBtn.Location = new System.Drawing.Point(468, 12);
            this.acelerar30segundosBtn.Name = "acelerar30segundosBtn";
            this.acelerar30segundosBtn.Size = new System.Drawing.Size(26, 33);
            this.acelerar30segundosBtn.TabIndex = 4;
            this.acelerar30segundosBtn.UseVisualStyleBackColor = true;
            this.acelerar30segundosBtn.Click += new System.EventHandler(this.acelerar30segundosBtn_Click);
            // 
            // acelerar1minutoBtn
            // 
            this.acelerar1minutoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acelerar1minutoBtn.Location = new System.Drawing.Point(500, 12);
            this.acelerar1minutoBtn.Name = "acelerar1minutoBtn";
            this.acelerar1minutoBtn.Size = new System.Drawing.Size(52, 33);
            this.acelerar1minutoBtn.TabIndex = 5;
            this.acelerar1minutoBtn.Text = ">>>";
            this.acelerar1minutoBtn.UseVisualStyleBackColor = true;
            this.acelerar1minutoBtn.Click += new System.EventHandler(this.acelerar1minutoBtn_Click);
            // 
            // desacelerarBtn
            // 
            this.desacelerarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desacelerarBtn.Location = new System.Drawing.Point(252, 11);
            this.desacelerarBtn.Name = "desacelerarBtn";
            this.desacelerarBtn.Size = new System.Drawing.Size(52, 33);
            this.desacelerarBtn.TabIndex = 6;
            this.desacelerarBtn.Text = "<<<";
            this.desacelerarBtn.UseVisualStyleBackColor = true;
            this.desacelerarBtn.Click += new System.EventHandler(this.desacelerarBtn_Click);
            // 
            // PausarCronometroBTN
            // 
            this.PausarCronometroBTN.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.PausarCronometroBTN.IconColor = System.Drawing.Color.Black;
            this.PausarCronometroBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PausarCronometroBTN.IconSize = 23;
            this.PausarCronometroBTN.Location = new System.Drawing.Point(187, 11);
            this.PausarCronometroBTN.Name = "PausarCronometroBTN";
            this.PausarCronometroBTN.Size = new System.Drawing.Size(59, 32);
            this.PausarCronometroBTN.TabIndex = 7;
            this.PausarCronometroBTN.UseVisualStyleBackColor = true;
            this.PausarCronometroBTN.Click += new System.EventHandler(this.PausarCronometroBTN_Click_1);
            // 
            // iniciarCronometroBtn
            // 
            this.iniciarCronometroBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iniciarCronometroBtn.IconColor = System.Drawing.Color.Black;
            this.iniciarCronometroBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iniciarCronometroBtn.IconSize = 23;
            this.iniciarCronometroBtn.Location = new System.Drawing.Point(122, 12);
            this.iniciarCronometroBtn.Name = "iniciarCronometroBtn";
            this.iniciarCronometroBtn.Size = new System.Drawing.Size(59, 32);
            this.iniciarCronometroBtn.TabIndex = 8;
            this.iniciarCronometroBtn.UseVisualStyleBackColor = true;
            this.iniciarCronometroBtn.Click += new System.EventHandler(this.iniciarCronometroBtn_Click_1);
            // 
            // golesLocal
            // 
            this.golesLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golesLocal.Location = new System.Drawing.Point(614, 12);
            this.golesLocal.Multiline = true;
            this.golesLocal.Name = "golesLocal";
            this.golesLocal.ReadOnly = true;
            this.golesLocal.Size = new System.Drawing.Size(31, 29);
            this.golesLocal.TabIndex = 9;
            this.golesLocal.Text = "0";
            this.golesLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // golesVisitante
            // 
            this.golesVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golesVisitante.Location = new System.Drawing.Point(709, 11);
            this.golesVisitante.Multiline = true;
            this.golesVisitante.Name = "golesVisitante";
            this.golesVisitante.ReadOnly = true;
            this.golesVisitante.Size = new System.Drawing.Size(29, 31);
            this.golesVisitante.TabIndex = 10;
            this.golesVisitante.Text = "0";
            this.golesVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "-------";
            // 
            // nombreCortoLocal
            // 
            this.nombreCortoLocal.AutoSize = true;
            this.nombreCortoLocal.Location = new System.Drawing.Point(573, 22);
            this.nombreCortoLocal.Name = "nombreCortoLocal";
            this.nombreCortoLocal.Size = new System.Drawing.Size(35, 13);
            this.nombreCortoLocal.TabIndex = 12;
            this.nombreCortoLocal.Text = "label2";
            // 
            // nombreCortoVisitante
            // 
            this.nombreCortoVisitante.AutoSize = true;
            this.nombreCortoVisitante.Location = new System.Drawing.Point(744, 21);
            this.nombreCortoVisitante.Name = "nombreCortoVisitante";
            this.nombreCortoVisitante.Size = new System.Drawing.Size(35, 13);
            this.nombreCortoVisitante.TabIndex = 13;
            this.nombreCortoVisitante.Text = "label3";
            // 
            // eventoGolBtn
            // 
            this.eventoGolBtn.IconChar = FontAwesome.Sharp.IconChar.FutbolBall;
            this.eventoGolBtn.IconColor = System.Drawing.Color.SteelBlue;
            this.eventoGolBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventoGolBtn.Location = new System.Drawing.Point(734, 84);
            this.eventoGolBtn.Name = "eventoGolBtn";
            this.eventoGolBtn.Size = new System.Drawing.Size(54, 50);
            this.eventoGolBtn.TabIndex = 14;
            this.eventoGolBtn.UseVisualStyleBackColor = true;
            this.eventoGolBtn.Click += new System.EventHandler(this.eventoGolBtn_Click);
            // 
            // eventoExpulsionBtn
            // 
            this.eventoExpulsionBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eventoExpulsionBtn.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.eventoExpulsionBtn.IconColor = System.Drawing.Color.Red;
            this.eventoExpulsionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventoExpulsionBtn.Location = new System.Drawing.Point(734, 140);
            this.eventoExpulsionBtn.Name = "eventoExpulsionBtn";
            this.eventoExpulsionBtn.Size = new System.Drawing.Size(54, 50);
            this.eventoExpulsionBtn.TabIndex = 15;
            this.eventoExpulsionBtn.UseVisualStyleBackColor = false;
            this.eventoExpulsionBtn.Click += new System.EventHandler(this.eventoExpulsionBtn_Click);
            // 
            // EventoTitulo
            // 
            this.EventoTitulo.AutoSize = true;
            this.EventoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventoTitulo.Location = new System.Drawing.Point(220, 183);
            this.EventoTitulo.Name = "EventoTitulo";
            this.EventoTitulo.Size = new System.Drawing.Size(337, 83);
            this.EventoTitulo.TabIndex = 16;
            this.EventoTitulo.Text = "EVENTO";
            this.EventoTitulo.Visible = false;
            // 
            // tiempoEvento
            // 
            this.tiempoEvento.AutoSize = true;
            this.tiempoEvento.Location = new System.Drawing.Point(230, 277);
            this.tiempoEvento.Name = "tiempoEvento";
            this.tiempoEvento.Size = new System.Drawing.Size(72, 13);
            this.tiempoEvento.TabIndex = 17;
            this.tiempoEvento.Text = "tiempoEvento";
            this.tiempoEvento.Visible = false;
            // 
            // jugadorEvento
            // 
            this.jugadorEvento.AutoSize = true;
            this.jugadorEvento.Location = new System.Drawing.Point(562, 277);
            this.jugadorEvento.Name = "jugadorEvento";
            this.jugadorEvento.Size = new System.Drawing.Size(76, 13);
            this.jugadorEvento.TabIndex = 19;
            this.jugadorEvento.Text = "jugadorEvento";
            this.jugadorEvento.Visible = false;
            // 
            // registroEventosList
            // 
            this.registroEventosList.FormattingEnabled = true;
            this.registroEventosList.Location = new System.Drawing.Point(12, 49);
            this.registroEventosList.Name = "registroEventosList";
            this.registroEventosList.Size = new System.Drawing.Size(209, 368);
            this.registroEventosList.TabIndex = 20;
            // 
            // registrarPartidoBtn
            // 
            this.registrarPartidoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPartidoBtn.Location = new System.Drawing.Point(525, 398);
            this.registrarPartidoBtn.Name = "registrarPartidoBtn";
            this.registrarPartidoBtn.Size = new System.Drawing.Size(263, 40);
            this.registrarPartidoBtn.TabIndex = 21;
            this.registrarPartidoBtn.Text = "REGISTRAR Y FINALIZAR PARTIDO";
            this.registrarPartidoBtn.UseVisualStyleBackColor = true;
            this.registrarPartidoBtn.Click += new System.EventHandler(this.registrarPartidoBtn_Click);
            // 
            // AdministrarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarPartidoBtn);
            this.Controls.Add(this.registroEventosList);
            this.Controls.Add(this.jugadorEvento);
            this.Controls.Add(this.tiempoEvento);
            this.Controls.Add(this.EventoTitulo);
            this.Controls.Add(this.eventoExpulsionBtn);
            this.Controls.Add(this.eventoGolBtn);
            this.Controls.Add(this.nombreCortoVisitante);
            this.Controls.Add(this.nombreCortoLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.golesVisitante);
            this.Controls.Add(this.golesLocal);
            this.Controls.Add(this.iniciarCronometroBtn);
            this.Controls.Add(this.PausarCronometroBTN);
            this.Controls.Add(this.desacelerarBtn);
            this.Controls.Add(this.acelerar1minutoBtn);
            this.Controls.Add(this.acelerar30segundosBtn);
            this.Controls.Add(this.acelerar10segundosBtn);
            this.Name = "AdministrarPartido";
            this.Text = "AdministrarPartido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton acelerar10segundosBtn;
        private FontAwesome.Sharp.IconButton acelerar30segundosBtn;
        private System.Windows.Forms.Button acelerar1minutoBtn;
        private System.Windows.Forms.Button desacelerarBtn;
        private FontAwesome.Sharp.IconButton PausarCronometroBTN;
        private FontAwesome.Sharp.IconButton iniciarCronometroBtn;
        private System.Windows.Forms.TextBox golesLocal;
        private System.Windows.Forms.TextBox golesVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreCortoLocal;
        private System.Windows.Forms.Label nombreCortoVisitante;
        private FontAwesome.Sharp.IconButton eventoGolBtn;
        private FontAwesome.Sharp.IconButton eventoExpulsionBtn;
        private System.Windows.Forms.Label EventoTitulo;
        private System.Windows.Forms.Label tiempoEvento;
        private System.Windows.Forms.Label jugadorEvento;
        private System.Windows.Forms.ListBox registroEventosList;
        private System.Windows.Forms.Button registrarPartidoBtn;
    }
}