using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    public partial class AdministrarPartido : Form
    {
        private Label lblTiempo;
        private Timer timer;
        private TimeSpan tiempo;
        private int intervaloMin = 100;
        private TimeSpan incremento = TimeSpan.FromSeconds(1);

        public AdministrarPartido()
        {
            InitializeComponent();
            // Inicializar componentes
            lblTiempo = new Label { Text = "00:00:00", AutoSize = true, Font = new System.Drawing.Font("Arial", 24F), Location = new System.Drawing.Point(300, 20) };

            //btnIniciar = new Button { Text = "Iniciar", Location = new System.Drawing.Point(20, 80) };
            //btnPausar = new Button { Text = "Pausar", Location = new System.Drawing.Point(110, 80) };

            //btnIniciar.Click += BtnIniciar_Click;
            //btnPausar.Click += BtnPausar_Click;

            this.Controls.Add(lblTiempo);
            //this.Controls.Add(btnIniciar);
            //this.Controls.Add(btnPausar);
            //this.Controls.Add(btnReiniciar);

            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;

            tiempo = TimeSpan.Zero;

            this.Text = "Cronómetro Visual";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo.Add(incremento);
            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
        }

        private void iniciarCronometroBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void PausarCronometroBTN_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void acelerar10segundosBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(10);
        }

        private void acelerar30segundosBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(30);
        }

        private void acelerar1minutoBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromMinutes(1);
        }

        private void desacelerarBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(1);
        }

    }
}
