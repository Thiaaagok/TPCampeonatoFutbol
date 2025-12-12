using System;
using System.Drawing;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.Arbitros;
using TPCampeonatoFutbol.Formularios.Campeonato;
using TPCampeonatoFutbol.Formularios.Jugadores;
using TPCampeonatoFutbol.Formularios.Usuarios.NewFolder1;

namespace TPCampeonatoFutbol
{
    public partial class MainMDI : Form
    {
        // ===============================
        //  VARIABLES
        // ===============================
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
        public MainMDI()
        {
            InitializeComponent();
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

        private Form formularioActual = null;

        private void AbrirFormulario(Form frm)
        {
            if (formularioActual != null)
                formularioActual.Close();

            formularioActual = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frm);

            frm.Show();
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

            // Botones del menú
            btnDashboard = CrearBoton("🏠 Jugadores");
            btnUsuarios = CrearBoton("👥 Usuarios");
            btnConfiguracion = CrearBoton("⚙️ Configuración");
            btnSalir = CrearBoton("🚪 Salir");

            btnDashboard.Click += (s, e) => Seleccionar(btnDashboard);
            btnUsuarios.Click += (s, e) => Seleccionar(btnUsuarios);
            btnConfiguracion.Click += (s, e) => Seleccionar(btnConfiguracion);
            btnSalir.Click += (s, e) => Seleccionar(btnSalir);

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
        private Button CrearBoton(string texto)
        {
            return new Button()
            {
                Text = texto,
                Width = 200,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11),
                BackColor = Color.FromArgb(30, 30, 30),
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private void Seleccionar(Button boton)
        {

            string destino = boton.Text.Replace("🏠 ", "")
                                       .Replace("👥 ", "")
                                       .Replace("⚙️ ", "")
                                       .Replace("🚪 ", "");

            Navegar(destino);
        }

        private void Navegar(string destino)
        {
            switch (destino)
            {
                case "Jugadores":
                    AbrirFormulario(new FRMJugadores());
                    break;

                case "Usuarios":
                    //AbrirFormulario(new FrmUsuarios());
                    break;

                case "Configuración":
                    //AbrirFormulario(new FrmConfiguracion());
                    break;

                case "Salir":
                    Application.Exit();
                    break;
            }
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

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if(UsuarioGlobal.Instancia.Rol == "DT" || UsuarioGlobal.Instancia.Rol == "ORGANIZADOR" || UsuarioGlobal.Instancia.Rol == "ADMIN")
            //{
            //    FRMEquipos equipos = new FRMEquipos();
            //    equipos.Show();
            //}
        }

        private void campeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campeonato campeonato = new Campeonato();
            campeonato.Show();
        }

        private void jugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           FRMJugadores jugadores = new FRMJugadores();
           jugadores.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioGlobal usuarioGlobal = new UsuarioGlobal();
            //usuarioGlobal.CerrarSesion();
            //FRMLogin usuarioLogin = new FRMLogin();
            //foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            //{
            //    if (form != usuarioLogin)
            //    {
            //        form.Close();
            //    }
            //}
            //usuarioLogin.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (UsuarioGlobal.Instancia.Rol == "ADMIN")
            //{
            //    FRMUsuarios fRMUsuarios = new FRMUsuarios();
            //    fRMUsuarios.Show();
            //}
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
