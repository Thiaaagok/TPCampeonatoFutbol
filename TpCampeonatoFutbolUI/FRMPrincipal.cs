using System;
using System.Drawing;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.Arbitros;
using TPCampeonatoFutbol.Formularios.Campeonato;
using TPCampeonatoFutbol.Formularios.Jugadores;
using TPCampeonatoFutbol.Formularios.Usuarios.NewFolder1;
using TpCampeonatoFutbolUI;
using TpCampeonatoFutbolUI.Navegacion;

namespace TPCampeonatoFutbol
{
    public partial class FRMPrincipal : Form
    {
        private ManejoFormularios manejador;

        private Panel panelContainer;
        private FlowLayoutPanel menuPanel;

        private Button btnDashboard;
        private Button btnUsuarios;
        private Button btnConfiguracion;
        private Button btnSalir;
        private Button btnToggle;

        private bool colapsado = false;

        // Animación
        private Timer animacion;
        private int anchoExpandido = 200;
        private int anchoColapsado = 35;
        private int velocidad = 10;
        private bool expandiendo = false;

        public event EventHandler<string> OnMenuClick;


        // ===============================
        //  CONSTRUCTOR
        // ===============================
        public FRMPrincipal()
        {
            InitializeComponent();
            manejador = new ManejoFormularios();

            // Suscribir el método que se ejecutará cuando cualquier form pida navegar
            NavegacionService.Instance.Navegar = CambiarFormulario;

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1280, 720);

            animacion = new Timer();
            animacion.Interval = 10;
            animacion.Tick += AnimarSidebar;

            CrearNavbar();
            CrearPanelContenido();
        }


        private Panel panelContenido;

        private void CrearPanelContenido()
        {
            panelContenido = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(50, 50, 50)
            };

            Controls.Add(panelContenido);
            Controls.SetChildIndex(panelContenido, 0); // Para que quede a la derecha de la navbar
        }


        // ===============================
        //  ANIMACIÓN DEL SIDEBAR
        // ===============================
        private void AnimarSidebar(object sender, EventArgs e)
        {
            if (expandiendo)
            {
                // EXPANDIENDO
                panelContainer.Width += velocidad;

                if (panelContainer.Width >= anchoExpandido)
                {
                    animacion.Stop();
                    panelContainer.Width = anchoExpandido;

                    MostrarBotones(true);
                    MostrarTextoMenu(true);

                    colapsado = false;
                }
            }
            else
            {
                // COLAPSANDO
                MostrarTextoMenu(false);

                panelContainer.Width -= velocidad;

                if (panelContainer.Width <= anchoColapsado)
                {
                    animacion.Stop();
                    panelContainer.Width = anchoColapsado;

                    MostrarBotones(false);

                    colapsado = true;
                }
            }
        }


        // ===============================
        //  CREAR NAVBAR
        // ===============================
        private void CrearNavbar()
        {
            // Contenedor principal
            panelContainer = new Panel()
            {
                Dock = DockStyle.Left,
                Width = anchoExpandido,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            // Botón hamburguesa
            btnToggle = new Button()
            {
                Width = 200,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11),
                BackColor = Color.FromArgb(45, 45, 45),
                FlatAppearance = { BorderSize = 0 },
                Text = "☰"
            };
            btnToggle.Click += ToggleMenu;

            // Panel del menú
            menuPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(0),
                BackColor = Color.FromArgb(30, 30, 30)
            };

            // Crear botones con RUTA ASIGNADA
            btnDashboard = CrearBoton("🏠 Jugadores", RutaFormulario.Jugadores);
            btnUsuarios = CrearBoton("👥 Usuarios", RutaFormulario.Usuarios);
            btnConfiguracion = CrearBoton("⚙️ Configuración", RutaFormulario.Configuracion);
            btnSalir = CrearBoton("🚪 Salir", RutaFormulario.Salir);

            // Evento único para todos
            btnDashboard.Click += BotonNavegacion_Click;
            btnUsuarios.Click += BotonNavegacion_Click;
            btnConfiguracion.Click += BotonNavegacion_Click;
            btnSalir.Click += BotonNavegacion_Click;

            // Construcción
            panelContainer.Controls.Add(menuPanel);
            panelContainer.Controls.Add(btnToggle);
            btnToggle.Dock = DockStyle.Top;

            menuPanel.Controls.Add(btnDashboard);
            menuPanel.Controls.Add(btnUsuarios);
            menuPanel.Controls.Add(btnConfiguracion);
            menuPanel.Controls.Add(btnSalir);

            Controls.Add(panelContainer);
        }


        // ===============================
        //  BOTONES Y TEXTOS
        // ===============================
        private Button CrearBoton(string texto, RutaFormulario ruta)
        {
            Button boton = new Button()
            {
                Text = texto,
                Tag = ruta, 
                Width = 200,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11),
                BackColor = Color.FromArgb(30, 30, 30),
                FlatAppearance = { BorderSize = 0 }
            };

            return boton;
        }

        private void BotonNavegacion_Click(object sender, EventArgs e)
        {
            Seleccionar((Button)sender);
        }

        private void Seleccionar(Button boton)
        {
            var ruta = (RutaFormulario)boton.Tag;
            NavegacionService.Instance.Navegar(ruta, null);
        }

        private void CambiarFormulario(RutaFormulario ruta, object parametro)
        {
            Form frm = FormRouter.ObtenerFormulario(ruta, parametro);
            manejador.AbrirFormulario(panelContenido, frm);
        }

        private void MostrarBotones(bool mostrar)
        {
            btnDashboard.Visible = mostrar;
            btnUsuarios.Visible = mostrar;
            btnConfiguracion.Visible = mostrar;
            btnSalir.Visible = mostrar;
        }

        private void MostrarTextoMenu(bool mostrar)
        {
            btnToggle.Text = mostrar ? "☰ Menu" : "☰";
            btnDashboard.Text = mostrar ? "🏠 Jugadores" : "🏠";
            btnUsuarios.Text = mostrar ? "👥 Usuarios" : "👥";
            btnConfiguracion.Text = mostrar ? "⚙️ Configuración" : "⚙️";
            btnSalir.Text = mostrar ? "🚪 Salir" : "🚪";
        }


        // ===============================
        //  TOGGLE SIDEBAR (con animación)
        // ===============================
        private void ToggleMenu(object sender, EventArgs e)
        {
            expandiendo = colapsado;
            animacion.Start();
        }

        private void Equipos_Click(object sender, EventArgs e)
        {
            FRMEquipos equipos = new FRMEquipos();
            equipos.Show();
        }

        private void Jugadores_Click(object sender, EventArgs e)
        {
            FRMJugadores jugadores = new FRMJugadores();
            jugadores.Show();
        }

        private void Campeonato_Click(object sender, EventArgs e)
        {
            Campeonato campeonato = new Campeonato();
            campeonato.Show();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            FRMUsuarios fRMUsuarios = new FRMUsuarios();
            fRMUsuarios.Show();
        }

        private void Arbitros_Click(object sender, EventArgs e)
        {
            FRMArbitros frmArbitros = new FRMArbitros();
            frmArbitros.Show();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            //UsuarioGlobal.CerrarSesion();
            //FRMLogin login = new FRMLogin();
            //login.Show();
            //this.Close();
        }
    }
}
