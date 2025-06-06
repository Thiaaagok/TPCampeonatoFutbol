﻿using System;
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
    public partial class Equipos : Form
    {
        List<Equipo> equipos = new List<Equipo>();
        ManejoArchivos manejoArchivos = new ManejoArchivos();
        public Equipos()
        {
            InitializeComponent();
            ObtenerEquipos();
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
                    Equipo equipo = new Equipo(partes[0], partes[1], partes[2], partes[3], Convert.ToInt32(partes[4]), Convert.ToInt32(partes[5]));
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
            CrearEquipoForm crForm = new CrearEquipoForm();
            crForm.ShowDialog();

            ObtenerEquipos();
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var equipoSeleccionado = (Equipo)dataGridViewEquipos.Rows[e.RowIndex].DataBoundItem;

                EditarEquipoForm editarEquipoForm = new EditarEquipoForm(equipoSeleccionado);
                if (editarEquipoForm.ShowDialog() == DialogResult.OK)
                {
                    var equipoEditado = editarEquipoForm.EquipoEditado;
                    EditarEquipo("Equipos.txt", equipoEditado);
                    ObtenerEquipos();
                    dataGridViewEquipos.DataSource = null;
                    dataGridViewEquipos.DataSource = equipos;
                }
            }
        }

        public void EditarEquipo(string ruta, Equipo equipoEditado)
        {
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<Equipo>(
                ruta,
                e => e.Nombre == equipoEditado.Nombre,
                equipoEditado,
                equipo => $"{equipo.Nombre},{equipo.NombreCorto},{equipo.Ciudad},{equipo.Estadio},{equipo.CapacidadEstadio},{equipo.AnioFundacion}",
                linea =>
                {
                    var partes = linea.Split(',');
                    return new Equipo(
                        partes[0],
                        partes[1],
                        partes[2],
                        partes[3],
                        int.Parse(partes[4]),
                        int.Parse(partes[5])
                    );
                });
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
