using ClosedXML.Excel;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class Util
    {
        public void RemoverEventosClick(Control control)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            if (f1 != null)
            {
                object obj = f1.GetValue(control);
                PropertyInfo pi = control.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
                EventHandlerList list = (EventHandlerList)pi.GetValue(control, null);
                list.RemoveHandler(obj, list[obj]);
            }
        }

        public delegate void AvisoEvento<T>(T datos);

        public event AvisoEvento<string> AvisoUsuario;

        public void ExportarGrillaAExcel(DataGridView dataGridView, string nombreArchivo)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = nombreArchivo;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Tabla de Posiciones");

                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                            worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                        }

                        for (int row = 0; row < dataGridView.Rows.Count; row++)
                        {
                            for (int col = 0; col < dataGridView.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                            }
                        }
                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Exportación a Excel completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
}
