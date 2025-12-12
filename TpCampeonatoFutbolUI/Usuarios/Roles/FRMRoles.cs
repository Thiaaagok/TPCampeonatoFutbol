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

namespace TpCampeonatoFutbolUI.Usuarios.Roles
{
    public partial class FRMRoles : Form
    {
        BLL_Roles BLL_Roles = new BLL_Roles();
        List<RolUsuarioBE> RolesOriginal = new List<RolUsuarioBE>();
        public FRMRoles()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ObtenerRoles()
        {
            RolesOriginal.Clear();

            try
            {
                var listaRoles = BLL_Roles.ObtenerTodos();
                RolesOriginal.AddRange(listaRoles);
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

                var Roleseleccionado = RolesOriginal[e.RowIndex];
                NavegacionService.Instance.Navegar(
                    RutaFormulario.EditarRolUsuario,
                    Roleseleccionado.Id
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerRoles();
            dataGridViewRoles.DataSource = RolesOriginal;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string query = txtBuscar.Text.Trim().ToLower();

            // Si no hay texto → mostrar todos los jugadores originales
            if (string.IsNullOrEmpty(query))
            {
                dataGridViewRoles.DataSource = null;
                dataGridViewRoles.DataSource = RolesOriginal;
                return;
            }

            var filtrados = RolesOriginal
                .Where(j =>
                    (j.Codigo != null && j.Codigo.ToLower().Contains(query)) ||
                    (j.Descripcion != null && j.Descripcion.ToLower().Contains(query))
                )
                .ToList();

            dataGridViewRoles.DataSource = null;
            dataGridViewRoles.DataSource = filtrados;
        }

        private void FRMRoles_Load(object sender, EventArgs e)
        {
            dataGridViewRoles.AutoGenerateColumns = false;

            ObtenerRoles();
            dataGridViewRoles.DataSource = RolesOriginal;

            dataGridViewRoles.Columns.Clear();

            // Otras columnas
            dataGridViewRoles.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewRoles.Columns.Add(CrearColumna("Codigo", "Código"));
            dataGridViewRoles.Columns.Add(CrearColumna("Descripcion", "Descripción"));

            // --- CABECERA ---
            dataGridViewRoles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewRoles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewRoles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridViewRoles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewRoles.ColumnHeadersHeight = 45;
            dataGridViewRoles.EnableHeadersVisualStyles = false;

            // --- CUERPO ---
            dataGridViewRoles.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridViewRoles.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewRoles.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewRoles.DefaultCellStyle.Padding = new Padding(5);

            // --- ALTERNADO ---
            dataGridViewRoles.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // --- HOVER DE FILA ---
            dataGridViewRoles.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255); // DodgerBlue
            dataGridViewRoles.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // --- ALTURA DE FILAS ---
            dataGridViewRoles.RowTemplate.Height = 55;

            // --- BORDES Y RENDER ---
            dataGridViewRoles.GridColor = Color.FromArgb(230, 230, 230);
            dataGridViewRoles.BorderStyle = BorderStyle.None;
            dataGridViewRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRoles.RowHeadersVisible = false;

            // --- AJUSTE DE COLUMNAS ---
            dataGridViewRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- INTERACCIÓN ---
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoles.MultiSelect = false;
            dataGridViewRoles.AllowUserToAddRows = false;
            dataGridViewRoles.AllowUserToDeleteRows = false;
            dataGridViewRoles.AllowUserToResizeRows = false;
            dataGridViewRoles.Height = 600;
        }
    }
}
