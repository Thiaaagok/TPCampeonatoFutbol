using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpCampeonatoFubolBLL;
using TPCampeonatoFutbol.Formularios.equipos;
using TPCampeonatoFutbol.Formularios.jugadores;
using TPCampeonatoFutbol.Servicios;
using TpCampeonatoFutbolBE;

namespace TPCampeonatoFutbol.Formularios.Jugadores
{
    public partial class FRMJugadores : Form
    {
        private List<JugadorBE> jugadoresOriginal = new List<JugadorBE>();
        private List<JugadorBE> jugadoresFiltro = new List<JugadorBE>();
        BLL_Jugadores BLL_Jugadores = new BLL_Jugadores();

        public FRMJugadores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void ObtenerJugadores()
        {
            jugadoresOriginal.Clear();

            try
            {
                var listaJugadores = BLL_Jugadores.ObtenerTodos();
                jugadoresOriginal.AddRange(listaJugadores);
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



        private void FRMJugadores_Load(object sender, EventArgs e)
        {
            dataGridViewJugadores.AutoGenerateColumns = false;

            ObtenerJugadores();
            dataGridViewJugadores.DataSource = jugadoresOriginal;

            dataGridViewJugadores.Columns.Clear();

            // Otras columnas
            dataGridViewJugadores.Columns.Add(CrearColumna("Nombre", "Nombre"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Apellido", "Apellido"));
            dataGridViewJugadores.Columns.Add(CrearColumna("EquipoNombre", "Equipo"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Edad", "Edad"));
            dataGridViewJugadores.Columns.Add(CrearColumna("Dni", "DNI"));

            // --- CABECERA ---
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridViewJugadores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewJugadores.ColumnHeadersHeight = 45;
            dataGridViewJugadores.EnableHeadersVisualStyles = false;

            // --- CUERPO ---
            dataGridViewJugadores.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridViewJugadores.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewJugadores.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewJugadores.DefaultCellStyle.Padding = new Padding(5);

            // --- ALTERNADO ---
            dataGridViewJugadores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // --- HOVER DE FILA ---
            dataGridViewJugadores.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255); // DodgerBlue
            dataGridViewJugadores.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewJugadores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // --- ALTURA DE FILAS ---
            dataGridViewJugadores.RowTemplate.Height = 55;

            // --- BORDES Y RENDER ---
            dataGridViewJugadores.GridColor = Color.FromArgb(230, 230, 230);
            dataGridViewJugadores.BorderStyle = BorderStyle.None;
            dataGridViewJugadores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewJugadores.RowHeadersVisible = false;

            // --- AJUSTE DE COLUMNAS ---
            dataGridViewJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- INTERACCIÓN ---
            dataGridViewJugadores.ReadOnly = true;
            dataGridViewJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJugadores.MultiSelect = false;
            dataGridViewJugadores.AllowUserToAddRows = false;
            dataGridViewJugadores.AllowUserToDeleteRows = false;
            dataGridViewJugadores.AllowUserToResizeRows = false;
            dataGridViewJugadores.Height = 600;

        }

        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                // Obtener el jugador correcto según la fila
                var jugadorSeleccionado = jugadoresOriginal[e.RowIndex];

                FRMEditarJugador editarJugadorForm = new FRMEditarJugador(jugadorSeleccionado);

                if (editarJugadorForm.ShowDialog() == DialogResult.OK)
                {
                    ObtenerJugadores(); // Recarga base de datos
                    dataGridViewJugadores.DataSource = null;
                    dataGridViewJugadores.DataSource = jugadoresOriginal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerJugadores();
            dataGridViewJugadores.DataSource = jugadoresOriginal;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string query = txtBuscar.Text.Trim().ToLower();

            // Si no hay texto → mostrar todos los jugadores originales
            if (string.IsNullOrEmpty(query))
            {
                dataGridViewJugadores.DataSource = null;
                dataGridViewJugadores.DataSource = jugadoresOriginal;
                return;
            }

            // Filtrar por nombre, apellido, equipo o dni
            var filtrados = jugadoresOriginal
                .Where(j =>
                    (j.Nombre != null && j.Nombre.ToLower().Contains(query)) ||
                    (j.Apellido != null && j.Apellido.ToLower().Contains(query)) ||
                    (j.EquipoNombre != null && j.EquipoNombre.ToLower().Contains(query)) ||
                    (j.Dni != null && j.Dni.ToLower().Contains(query))
                )
                .ToList();

            dataGridViewJugadores.DataSource = null;
            dataGridViewJugadores.DataSource = filtrados;
        }
    }
}
