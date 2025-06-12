using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCampeonatoFutbol.Funciones
{
    public class ManejoArchivos
    {
        public void CrearArchivo(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    using (var sw = File.CreateText(ruta))
                    {
                        switch (ruta)
                        {
                            case "jugadores.txt":
                                sw.WriteLine("Nombre,Apellido,Edad,Dni,FechaNacimiento,LugarNacimiento,Equipo,RolCodigo,RolDescripcion");
                                break;
                            case "equipos.txt":
                                sw.WriteLine("ID,Nombre,Fundación,Estadio");
                                break;
                            case "usuarios.txt":
                                sw.WriteLine("ID,Nombre,Fundación,Estadio");
                                break;
                            default:
                                sw.WriteLine("Encabezado");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo");
            }
        }

        public List<string> ObtenerTodos(string ruta)
        {
            try
            {
                if (!File.Exists(ruta)) return new List<string>();
                using (var sr = new StreamReader(ruta))
                {
                    var lineas = new List<string>();
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineas.Add(linea);
                    }
                    return lineas.Skip(1).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo");
                return new List<string>();
            }
        }

        public void GuardarTodos(string ruta, List<string> nuevosRegistros)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    CrearArchivo(ruta);
                }
                var lineas = File.ReadAllLines(ruta).ToList();
                if (lineas.Count == 0) return;
                var encabezado = lineas[0];
                var nuevasLineas = new List<string> { encabezado };
                nuevasLineas.AddRange(nuevosRegistros);

                using (var sw = new StreamWriter(ruta, false))
                {
                    foreach (var linea in nuevasLineas)
                    {
                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo");
            }
        }

        public void GuardarNuevo(string ruta, string nuevoRegistro)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    CrearArchivo(ruta);
                }

                var lineas = File.ReadAllLines(ruta).ToList();

                if (lineas.Count == 0)
                {
                    CrearArchivo(ruta);
                    return;
                }

                using (var sw = new StreamWriter(ruta, append: true))
                {
                    sw.WriteLine(nuevoRegistro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el nuevo registro: " + ex.Message);
            }
        }

        public void EditarRegistro<T>(string ruta, Predicate<T> coincide, T nuevoObjeto, Func<T, string> convertirALinea, Func<string, T> convertirDesdeLinea)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("El archivo no existe.");
                    return;
                }

                var lineas = File.ReadAllLines(ruta).ToList();

                if (lineas.Count == 0)
                {
                    MessageBox.Show("El archivo está vacío.");
                    return;
                }

                var encabezado = lineas[0];
                var nuevasLineas = new List<string> { encabezado };

                bool modificado = false;

                foreach (var linea in lineas.Skip(1))
                {
                    var objeto = convertirDesdeLinea(linea);
                    if (!modificado && coincide(objeto))
                    {
                        nuevasLineas.Add(convertirALinea(nuevoObjeto));
                        modificado = true;
                    }
                    else
                    {
                        nuevasLineas.Add(linea);
                    }
                }

                if (!modificado)
                {
                    MessageBox.Show("No se encontró el registro a modificar.");
                    return;
                }

                File.WriteAllLines(ruta, nuevasLineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el archivo: " + ex.Message);
            }
        }
    }    
}
