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
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Arbitros
{
    public partial class FRMArbitros : Form
    {
        List<CLSArbitro> arbitros = new List<CLSArbitro>();
        ArbitroService arbitrosService = new ArbitroService();
        public FRMArbitros()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ObtenerArbitros()
        {
            arbitros.Clear();

            try
            {
                var listaArbitros = arbitrosService.ObtenerTodos();
                arbitros.AddRange(listaArbitros);
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerArbitros();
            dataGridViewArbitros.DataSource = null;
            dataGridViewArbitros.DataSource = arbitros;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewArbitros_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (UsuarioGlobal.Instancia.Rol == "ADMIN")
                    {
                        var arbitroSeleccionado = arbitros[e.RowIndex];

                        FRMEditarArbitro editarJugadorForm = new FRMEditarArbitro();
                        if (editarJugadorForm.ShowDialog() == DialogResult.OK)
                        {
                            ObtenerArbitros();
                            dataGridViewArbitros.DataSource = null;
                            dataGridViewArbitros.DataSource = arbitros;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void FRMArbitros_Load(object sender, EventArgs e)
        {
            dataGridViewArbitros.AutoGenerateColumns = false;
            ObtenerArbitros();
            dataGridViewArbitros.DataSource = null;
            dataGridViewArbitros.DataSource = arbitros;

            dataGridViewArbitros.Columns.Clear();

            dataGridViewArbitros.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewArbitros.Columns.Add(CrearColumna("Nombre", "Nombre"));
            dataGridViewArbitros.Columns.Add(CrearColumna("Apellido", "Apellido"));
            dataGridViewArbitros.Columns.Add(CrearColumna("Edad", "Edad"));
            dataGridViewArbitros.Columns.Add(CrearColumna("Dni", "DNI"));
            dataGridViewArbitros.Columns.Add(CrearColumna("FechaNacimiento", "Fecha de nacimiento"));
            dataGridViewArbitros.Columns.Add(CrearColumna("LugarNacimiento", "Lugar de nacimiento"));

            // Estilos fachero v2
            dataGridViewArbitros.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGridViewArbitros.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridViewArbitros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewArbitros.EnableHeadersVisualStyles = false;

            dataGridViewArbitros.DefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridViewArbitros.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewArbitros.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewArbitros.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewArbitros.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewArbitros.RowTemplate.Height = 28;
            dataGridViewArbitros.GridColor = Color.Gainsboro;
            dataGridViewArbitros.BorderStyle = BorderStyle.None;
            dataGridViewArbitros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewArbitros.ReadOnly = true;
            dataGridViewArbitros.AllowUserToAddRows = false;
            dataGridViewArbitros.AllowUserToDeleteRows = false;
            dataGridViewArbitros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FRMCrearArbitro crForm = new FRMCrearArbitro();
            if (crForm.ShowDialog() == DialogResult.OK)
            {
                ObtenerArbitros();
            }
        }
    }
}
