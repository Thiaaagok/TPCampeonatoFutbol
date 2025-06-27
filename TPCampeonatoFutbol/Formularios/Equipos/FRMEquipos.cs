using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.equipos;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol
{
    public partial class FRMEquipos : Form
    {
        List<CLSEquipo> equipos = new List<CLSEquipo>();
        ManejoArchivos manejoArchivos = new ManejoArchivos();
        public FRMEquipos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ObtenerEquipos()
        {
            equipos.Clear();
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("equipos.txt");

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    CLSEquipo equipo = new CLSEquipo(partes[0], partes[1], partes[2], partes[3], partes[4], int.Parse(partes[5]), int.Parse(partes[6]));
                    equipos.Add(equipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener equipos: " + ex.Message);
            }

        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            dataGridViewEquipos.AutoGenerateColumns = false;
            ObtenerEquipos();
            dataGridViewEquipos.DataSource = null;
            dataGridViewEquipos.DataSource = equipos;

            dataGridViewEquipos.Columns.Clear();

            dataGridViewEquipos.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewEquipos.Columns.Add(CrearColumna("Nombre", "Nombre completo"));
            dataGridViewEquipos.Columns.Add(CrearColumna("NombreCorto", "Alias"));
            dataGridViewEquipos.Columns.Add(CrearColumna("Ciudad", "Ciudad de origen"));
            dataGridViewEquipos.Columns.Add(CrearColumna("Estadio", "Nombre del estadio"));
            dataGridViewEquipos.Columns.Add(CrearColumna("CapacidadEstadio", "Capacidad (personas)"));
            dataGridViewEquipos.Columns.Add(CrearColumna("AnioFundacion", "Año de fundación"));

            // Estilos fachero v2
            dataGridViewEquipos.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGridViewEquipos.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridViewEquipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewEquipos.EnableHeadersVisualStyles = false;

            dataGridViewEquipos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridViewEquipos.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewEquipos.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEquipos.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewEquipos.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewEquipos.RowTemplate.Height = 28;
            dataGridViewEquipos.GridColor = Color.Gainsboro;
            dataGridViewEquipos.BorderStyle = BorderStyle.None;
            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEquipos.ReadOnly = true;
            dataGridViewEquipos.AllowUserToAddRows = false;
            dataGridViewEquipos.AllowUserToDeleteRows = false;
            dataGridViewEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void NuevoButton_Click(object sender, EventArgs e)
        {

            if(equipos.Count == 10)
            {
                MessageBox.Show("Limite de equipos alcanzado, elimine uno para continuar");
                return;
            }

            FRMCrearEquipo crForm = new FRMCrearEquipo();
            if (crForm.ShowDialog() == DialogResult.OK)
            {
                ObtenerEquipos();
                dataGridViewEquipos.DataSource = null;
                dataGridViewEquipos.DataSource = equipos;
            }
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var equipoSeleccionado = (CLSEquipo)dataGridViewEquipos.Rows[e.RowIndex].DataBoundItem;

                    FRMEditarEquipo editarEquipoForm = new FRMEditarEquipo(equipoSeleccionado);
                    if (editarEquipoForm.ShowDialog() == DialogResult.OK)
                    {
                        var equipoEditado = editarEquipoForm.EquipoEditado;
                        equipoEditado.editarEquipo(equipoEditado);
                        ObtenerEquipos();
                        dataGridViewEquipos.DataSource = null;
                        dataGridViewEquipos.DataSource = equipos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerEquipos();
            dataGridViewEquipos.DataSource = null;
            dataGridViewEquipos.DataSource = equipos;
        }
    }
}
