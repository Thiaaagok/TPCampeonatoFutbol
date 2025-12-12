using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpCampeonatoFubolBLL;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolUI.Navegacion;

namespace TpCampeonatoFutbolUI.Usuarios.Permisos
{
    public partial class FRMPermisos : Form
    {
        BLL_Permisos BLL_Permisos = new BLL_Permisos();
        List<PermisoBE> permisosOriginal = new List<PermisoBE>();
        public FRMPermisos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FRMPermisos_Load(object sender, EventArgs e)
        {
            dataGridViewPermisos.AutoGenerateColumns = false;

            ObtenerPermisos();
            dataGridViewPermisos.DataSource = permisosOriginal;

            dataGridViewPermisos.Columns.Clear();

            // Otras columnas
            dataGridViewPermisos.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewPermisos.Columns.Add(CrearColumna("Codigo", "Código"));
            dataGridViewPermisos.Columns.Add(CrearColumna("Descripcion", "Descripción"));

            // --- CABECERA ---
            dataGridViewPermisos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewPermisos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPermisos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridViewPermisos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPermisos.ColumnHeadersHeight = 45;
            dataGridViewPermisos.EnableHeadersVisualStyles = false;

            // --- CUERPO ---
            dataGridViewPermisos.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridViewPermisos.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPermisos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewPermisos.DefaultCellStyle.Padding = new Padding(5);

            // --- ALTERNADO ---
            dataGridViewPermisos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // --- HOVER DE FILA ---
            dataGridViewPermisos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255); // DodgerBlue
            dataGridViewPermisos.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewPermisos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // --- ALTURA DE FILAS ---
            dataGridViewPermisos.RowTemplate.Height = 55;

            // --- BORDES Y RENDER ---
            dataGridViewPermisos.GridColor = Color.FromArgb(230, 230, 230);
            dataGridViewPermisos.BorderStyle = BorderStyle.None;
            dataGridViewPermisos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPermisos.RowHeadersVisible = false;

            // --- AJUSTE DE COLUMNAS ---
            dataGridViewPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- INTERACCIÓN ---
            dataGridViewPermisos.ReadOnly = true;
            dataGridViewPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPermisos.MultiSelect = false;
            dataGridViewPermisos.AllowUserToAddRows = false;
            dataGridViewPermisos.AllowUserToDeleteRows = false;
            dataGridViewPermisos.AllowUserToResizeRows = false;
            dataGridViewPermisos.Height = 600;
        }

        private void ObtenerPermisos()
        {
            permisosOriginal.Clear();

            try
            {
                var listaPermisos = BLL_Permisos.ObtenerTodos();
                permisosOriginal.AddRange(listaPermisos);
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
                if (e.RowIndex < 0)
                    return;

                var permisoSeleccionado = permisosOriginal[e.RowIndex];
                NavegacionService.Instance.Navegar(
                    RutaFormulario.EditarRolUsuario,
                    permisoSeleccionado.Id
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerPermisos();
            dataGridViewPermisos.DataSource = permisosOriginal;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string query = txtBuscar.Text.Trim().ToLower();

            // Si no hay texto → mostrar todos los jugadores originales
            if (string.IsNullOrEmpty(query))
            {
                dataGridViewPermisos.DataSource = null;
                dataGridViewPermisos.DataSource = permisosOriginal;
                return;
            }

            var filtrados = permisosOriginal
                .Where(j =>
                    (j.Codigo != null && j.Codigo.ToLower().Contains(query)) ||
                    (j.Descripcion != null && j.Descripcion.ToLower().Contains(query))
                )
                .ToList();

            dataGridViewPermisos.DataSource = null;
            dataGridViewPermisos.DataSource = filtrados;
        }
    }
}
