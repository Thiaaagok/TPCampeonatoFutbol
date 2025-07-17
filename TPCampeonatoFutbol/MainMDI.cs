using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public MainMDI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;


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
            usuarioLogin.Show();
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != usuarioLogin)
                {
                    form.Close();
                }
            }
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
