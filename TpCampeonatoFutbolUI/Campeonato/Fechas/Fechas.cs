using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.Campeonato.Partidos;
using TPCampeonatoFutbol.Servicios;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;
using TpCampeonatoFutbolBE;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    public partial class Fechas : Form
    {
        
        private System.Windows.Forms.TabControl tabControl1 = new System.Windows.Forms.TabControl();
        public Fechas()
        {
            InitializeComponent();

            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Name = "tabControl1";
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Controls.Add(tabControl1);

            MostrarFechasEnTabs();
        }

        public void MostrarFechasEnTabs()
        {
            //List<FechaBE> fechas = fechasBLL.CargarFechasDesdeArchivos();
            //EquiposBLL equiposService = new EquiposBLL();

            //tabControl1.TabPages.Clear();

            //int numeroFecha = 1;

            //foreach (var fecha in fechas)
            //{
            //    var tab = new TabPage($"Fecha {numeroFecha++}");
                   
            //    tab.BackColor = Color.FromArgb(39, 57, 80);

            //    var flowPanel = new FlowLayoutPanel
            //    {
            //        Dock = DockStyle.Fill,
            //        FlowDirection = FlowDirection.TopDown,
            //        WrapContents = false,
            //        AutoScroll = true,
            //        Padding = new Padding(0, 10, 0, 10),
            //        AutoSize = false
              
            //    };

            //    flowPanel.HorizontalScroll.Maximum = 0;
            //    flowPanel.HorizontalScroll.Visible = false;
            //    flowPanel.AutoScroll = true;

            //    // Centrar horizontalmente los items
            //    flowPanel.ControlAdded += (s, e) =>
            //    {
            //        e.Control.Margin = new Padding((flowPanel.Width - e.Control.Width) / 2, 5, 0, 5);
            //        e.Control.Anchor = AnchorStyles.None;
            //    };


            //    foreach (var partido in fecha.Partidos)
            //    {
            //        string local = equiposService.ObtenerNombrePorId(partido.Local);
            //        string visitante = equiposService.ObtenerNombrePorId(partido.Visitante);

            //        PartidosBLL partidosBLL = new PartidosBLL();
            //        PartidoBE partidoResultado = partidosBLL.ObtenerPartidoJugado(partido.Id);

            //        Panel partidoPanel = new Panel
            //        {
            //            Width = 600,
            //            Height = 35,
            //            BackColor = Color.White,
            //            Margin = new Padding(5),
            //            BorderStyle = BorderStyle.None
            //        };

            //        // Label local
            //        string textLocal;
            //        textLocal = local;
            //        if (partidoResultado != null)
            //        {
            //            textLocal = $"{local} {partidoResultado.GolesLocal}";
            //        }
            //        Label lblLocal = new Label
            //        {
            //            Text = textLocal,
            //            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            //            AutoSize = false,
            //            Width = 200,
            //            Height = 30,
            //            Location = new Point(10, 5),
            //            TextAlign = ContentAlignment.MiddleLeft
            //        };

            //        // Label "c."
            //        Label lblVs = new Label
            //        {
            //            Text = "c.",
            //            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            //            AutoSize = false,
            //            Width = 30,
            //            Height = 30,
            //            Location = new Point((partidoPanel.Width - 30) / 2, 5),
            //            TextAlign = ContentAlignment.MiddleCenter
            //        };

            //        // Label visitante
            //        string textVisitante = visitante;
            //        if (partidoResultado != null)
            //        {
            //            textVisitante = $"{partidoResultado.GolesVisitante} {visitante}";
            //        }
            //        Label lblVisitante = new Label
            //        {
            //            Text = textVisitante,
            //            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            //            AutoSize = false,
            //            Width = 200,
            //            Height = 30,
            //            Location = new Point(partidoPanel.Width - 210, 5),
            //            TextAlign = ContentAlignment.MiddleRight
            //        };

            //        if(partidoResultado == null)
            //        {
            //            partidoPanel.Click += (s, e) => AbrirAdministrarPartido(partido.Local, partido.Visitante, partido.Id);
            //            lblLocal.Click += (s, e) => AbrirAdministrarPartido(partido.Local, partido.Visitante, partido.Id);
            //            lblVs.Click += (s, e) => AbrirAdministrarPartido(partido.Local, partido.Visitante, partido.Id);
            //            lblVisitante.Click += (s, e) => AbrirAdministrarPartido(partido.Local, partido.Visitante, partido.Id);
            //        }


            //        partidoPanel.Controls.Add(lblLocal);
            //        partidoPanel.Controls.Add(lblVs);
            //        partidoPanel.Controls.Add(lblVisitante);

            //        flowPanel.Controls.Add(partidoPanel);
            //    }

            //    tab.Controls.Add(flowPanel);
            //    tabControl1.TabPages.Add(tab);
            //}
        }

        void AbrirAdministrarPartido(Guid idLocal, Guid idVisitante,Guid partidoId)
        {
            AdministrarPartido administrarPartido = new AdministrarPartido(idLocal, idVisitante, partidoId);
            administrarPartido.Show();
        }
        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
