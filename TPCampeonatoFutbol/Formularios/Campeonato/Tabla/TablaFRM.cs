using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Modelos.Funciones;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Tabla
{
    public partial class TablaFRM : Form
    {
        List<TablaPosicionDTO> tablaPosicionDTOs = new List<TablaPosicionDTO>();
        List<CLSEquipo> equipos = new List<CLSEquipo>();
        EquiposService equiposService = new EquiposService();
        List<ClSEstadisticasCampeonato> estadisticasCampeonato = new List<ClSEstadisticasCampeonato>();
        public TablaFRM()
        {
            InitializeComponent();
            obtenerEquipos();
            obtenerEstadisticas();
            CargarTabla();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public void obtenerEquipos()
        {
            equipos.Clear();

            try
            {
                var listaEquipos = equiposService.ObtenerTodos();
                equipos.AddRange(listaEquipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        public void obtenerEstadisticas()
        {
            estadisticasCampeonato.Clear();

            try
            {
                var listaEstaditica = equiposService.ObtenerEstadisticasCampeonato();
                estadisticasCampeonato.AddRange(listaEstaditica);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        public void CargarTabla()
        {
            tablaPosicionDTOs.Clear();
            foreach (ClSEstadisticasCampeonato clSEstadisticasCampeonato in estadisticasCampeonato)
            {
                CLSEquipo equipo = equipos.FirstOrDefault(eq => eq.Id == clSEstadisticasCampeonato.Equipo);

                TablaPosicionDTO tablaPosicion = new TablaPosicionDTO
                {
                    Equipo = equipo != null ? equipo.Nombre : "Desconocido",
                    Puntos = clSEstadisticasCampeonato.Puntos,
                    CantPartidosJugados = clSEstadisticasCampeonato.CantPartidosJugados,
                    PartidosGanados = clSEstadisticasCampeonato.PartidosGanados,
                    PartidosEmpatados = clSEstadisticasCampeonato.PartidosEmpatados,
                    PartidosPerdidos = clSEstadisticasCampeonato.PartidosPerdidos,
                    Goles = clSEstadisticasCampeonato.Goles,
                    Expulsiones = clSEstadisticasCampeonato.Expulsiones
                };

                tablaPosicionDTOs.Add(tablaPosicion);
            }

            // Ordenar por puntos y goles
            var tablaVisual = tablaPosicionDTOs
                .OrderByDescending(x => x.Puntos)
                .ThenByDescending(x => x.Goles)
                .ToList();

            tablaDataGridView.DataSource = null;
            tablaDataGridView.AutoGenerateColumns = false;
            tablaDataGridView.Columns.Clear();

            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Equipo",
                HeaderText = "Equipo",
                ReadOnly = true,
                Width = 180
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Puntos",
                HeaderText = "Puntos",
                ReadOnly = true,
                Width = 60
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantPartidosJugados",
                HeaderText = "PJ",
                ReadOnly = true,
                Width = 50
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartidosGanados",
                HeaderText = "PG",
                ReadOnly = true,
                Width = 50
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartidosEmpatados",
                HeaderText = "PE",
                ReadOnly = true,
                Width = 50
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartidosPerdidos",
                HeaderText = "PP",
                ReadOnly = true,
                Width = 50
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Goles",
                HeaderText = "Goles",
                ReadOnly = true,
                Width = 60
            });
            tablaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Expulsiones",
                HeaderText = "Expulsiones",
                ReadOnly = true,
                Width = 90
            });

            tablaDataGridView.DataSource = tablaVisual;
            tablaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            tablaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaDataGridView.MultiSelect = false;
            tablaDataGridView.ReadOnly = true;
            tablaDataGridView.AllowUserToAddRows = false;
            tablaDataGridView.AllowUserToDeleteRows = false;
            tablaDataGridView.AllowUserToResizeRows = false;
            tablaDataGridView.RowHeadersVisible = false;
            tablaDataGridView.BackgroundColor = Color.White;
            tablaDataGridView.BorderStyle = BorderStyle.FixedSingle;

            tablaDataGridView.EnableHeadersVisualStyles = false;
            tablaDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            tablaDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            tablaDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            tablaDataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            tablaDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            tablaDataGridView.DefaultCellStyle.BackColor = Color.White;
            tablaDataGridView.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            Util util = new Util();
            util.ExportarGrillaAExcel(tablaDataGridView,"TablaPosiciones.xlsx");
        }
    }
}
