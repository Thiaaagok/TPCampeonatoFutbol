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

namespace TPCampeonatoFutbol.Formularios.Usuarios.NewFolder1
{
    public partial class FRMUsuarios : Form
    {
        List<CLSUsuario> usuarios = new List<CLSUsuario>();
        UsuarioService usuariosService = new UsuarioService();
        UsuarioGlobal UsuarioGlobal = new UsuarioGlobal();
        public FRMUsuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ObtenerUsuarios();
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ObtenerUsuarios()
        {
            usuarios.Clear();

            try
            {
                var listaUsuarios = usuariosService.ObtenerTodos();
                usuarios.AddRange(listaUsuarios);
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

        private void FRMUsuarios_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.AutoGenerateColumns = false;
            ObtenerUsuarios();
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = usuarios;

            dataGridViewUsuarios.Columns.Clear();

            dataGridViewUsuarios.Columns.Add(CrearColumna("Id", "Id"));
            dataGridViewUsuarios.Columns.Add(CrearColumna("Usuario", "Nombre de usuario"));
            dataGridViewUsuarios.Columns.Add(CrearColumna("Rol", "Rol"));

            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;

            dataGridViewUsuarios.DefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridViewUsuarios.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsuarios.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewUsuarios.RowTemplate.Height = 28;
            dataGridViewUsuarios.GridColor = Color.Gainsboro;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
