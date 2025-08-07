using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.Arbitros;
using TPCampeonatoFutbol.Formularios.Campeonato;
using TPCampeonatoFutbol.Formularios.Campeonato.Partidos;
using TPCampeonatoFutbol.Formularios.Jugadores;
using TPCampeonatoFutbol.Formularios.Usuarios.NewFolder1;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol
{
    public partial class MainMDI : Form
    {
        private int childFormNumber = 0;
        readonly UsuarioGlobal UsuarioGlobal = new UsuarioGlobal();
        private Panel panelNavbar;
        public MainMDI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            CrearNavbar();
        }

        private void CrearNavbar()
        {
            panelNavbar = new Panel();
            panelNavbar.BackColor = Color.FromArgb(30, 40, 55); // Color moderno
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Height = 50;
            this.Controls.Add(panelNavbar);

            // Botones según permisos
            if (EsRol("DT", "ORGANIZADOR", "ADMIN"))
                CrearBotonNavbar("Equipos", Equipos_Click);

            CrearBotonNavbar("Jugadores", Jugadores_Click);
            CrearBotonNavbar("Arbitros", Arbitros_Click);
            CrearBotonNavbar("Campeonato", Campeonato_Click);

            if (EsRol("ADMIN"))
                CrearBotonNavbar("Usuarios", Usuarios_Click);

            CrearBotonNavbar("Cerrar Sesión", CerrarSesion_Click);
        }

        private bool EsRol(params string[] rolesPermitidos)
        {
            return rolesPermitidos.Contains(UsuarioGlobal.Instancia.Rol);
        }

        private void CrearBotonNavbar(string texto, EventHandler eventoClick)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = panelNavbar.BackColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = panelNavbar.Height;
            btn.Width = 140;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Dock = DockStyle.Left;
            btn.Cursor = Cursors.Hand;
            btn.Click += eventoClick;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(50, 60, 80);
            btn.MouseLeave += (s, e) => btn.BackColor = panelNavbar.BackColor;

            panelNavbar.Controls.Add(btn);
            panelNavbar.Controls.SetChildIndex(btn, 0);
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
            UsuarioGlobal.CerrarSesion();
            FRMLogin login = new FRMLogin();
            login.Show();
            this.Close();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
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
            if(UsuarioGlobal.Instancia.Rol == "DT" || UsuarioGlobal.Instancia.Rol == "ORGANIZADOR" || UsuarioGlobal.Instancia.Rol == "ADMIN")
            {
                FRMEquipos equipos = new FRMEquipos();
                equipos.Show();
            }
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
            UsuarioGlobal usuarioGlobal = new UsuarioGlobal();
            usuarioGlobal.CerrarSesion();
            FRMLogin usuarioLogin = new FRMLogin();
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != usuarioLogin)
                {
                    form.Close();
                }
            }
            usuarioLogin.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioGlobal.Instancia.Rol == "ADMIN")
            {
                FRMUsuarios fRMUsuarios = new FRMUsuarios();
                fRMUsuarios.Show();
            }
        }
    }
}
