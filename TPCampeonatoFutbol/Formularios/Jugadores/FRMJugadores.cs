using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.equipos;
using TPCampeonatoFutbol.Formularios.jugadores;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Jugadores
{
    public partial class FRMJugadores : Form
    {
        List<CLSJugador> jugadores = new List<CLSJugador>();
        JugadoresService jugadoresService = new JugadoresService();
        UsuarioGlobal UsuarioGlobal = new UsuarioGlobal();
        public FRMJugadores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void ObtenerJugadores()
        {
            jugadores.Clear();

            try
            {
                var listaJugadores = jugadoresService.ObtenerTodos();
                jugadores.AddRange(listaJugadores);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private DataGridViewColumn CrearColumna(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if(UsuarioGlobal.Instancia.Rol == "ADMIN")
                    {
                        var jugadorSeleccionado = jugadores[e.RowIndex];

                        FRMEditarJugador editarJugadorForm = new FRMEditarJugador(jugadorSeleccionado);
                        if (editarJugadorForm.ShowDialog() == DialogResult.OK)
                        {
                            ObtenerJugadores();
                            dataGridViewJugadores.DataSource = null;
                            dataGridViewJugadores.DataSource = jugadores;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void FRMJugadores_Load(object sender, EventArgs e)
        {
            dataGridViewJugadores.AutoGenerateColumns = false;
            ObtenerJugadores();
            dataGridViewJugadores.DataSource = null;
            dataGridViewJugadores.DataSource = jugadores;

            dataGridViewJugadores.Columns.Clear();

            dataGridViewJugadores.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Nombre", "Nombre"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Apellido", "Apellido"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Edad", "Edad"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Dni", "DNI"));
            dataGridViewJugadores.Columns.Add(CrearColumna("FechaNacimiento", "Fecha de nacimiento"));
            dataGridViewJugadores.Columns.Add(CrearColumna("LugarNacimiento", "Lugar de nacimiento"));
            dataGridViewJugadores.Columns.Add(CrearColumna("EquipoId", "ID del equipo"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Rol.Codigo", "Rol"));

            // Estilos fachero v2
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewJugadores.EnableHeadersVisualStyles = false;

            dataGridViewJugadores.DefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridViewJugadores.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewJugadores.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewJugadores.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewJugadores.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewJugadores.RowTemplate.Height = 28;
            dataGridViewJugadores.GridColor = Color.Gainsboro;
            dataGridViewJugadores.BorderStyle = BorderStyle.None;
            dataGridViewJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewJugadores.ReadOnly = true;
            dataGridViewJugadores.AllowUserToAddRows = false;
            dataGridViewJugadores.AllowUserToDeleteRows = false;
            dataGridViewJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerJugadores();
            dataGridViewJugadores.DataSource = null;
            dataGridViewJugadores.DataSource = jugadores;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
