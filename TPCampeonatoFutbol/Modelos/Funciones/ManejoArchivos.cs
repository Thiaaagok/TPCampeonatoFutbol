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
                                sw.WriteLine("NombreApellido;Edad;Dni;FechaNacimiento;LugarNacimiento;Equipo;RolCodigo;RolDescripcion");
                                break;
                            case "equipos.txt":
                                sw.WriteLine("ID;Nombre;Fundación;Estadio;Capacidad;AnioNacimiento");
                                break;
                            case "usuarios.txt":
                                sw.WriteLine("ID;Nombre;Contrasenia");
                                break;
                            case "partidos.txt":
                                sw.WriteLine("ID;Nombre;Contrasenia");
                                break;
                            case "partidosEstadisticas.txt":
                                sw.WriteLine("PartidoId;GolesLocal;GolesVisitante;ExpLocal;ExpVisitante");
                                break;
                            case "partidosGoles.txt":
                                sw.WriteLine("Id;PartidoId;EquipoId;AutorId;Autor;Minutos");
                                break;
                            case "partidosExpulsiones.txt":
                                sw.WriteLine("Id;PartidoId;EquipoId;AutorId;Autor;Minutos");
                                break;
                            case "equiposEstadisticas.txt":
                                sw.WriteLine("Id;PartidoId;EquipoId;AutorId;Autor;Minutos");
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
                if (!File.Exists(ruta)) CrearArchivo(ruta);
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
                else
                {
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.ReadWrite))
                    {
                        if (fs.Length > 0)
                        {
                            fs.Seek(-1, SeekOrigin.End);
                            int lastByte = fs.ReadByte();
                            if (lastByte != '\n' && lastByte != '\r')
                            {
                                // Si no termina con salto, agregar uno
                                fs.Seek(0, SeekOrigin.End);
                                byte[] newline = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine);
                                fs.Write(newline, 0, newline.Length);
                            }
                        }
                    }
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
                    CrearArchivo(ruta);
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
                        MessageBox.Show("Registro editado correctamente.");
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

        public T ObtenerRegistroPorId<T>(string ruta, Predicate<T> coincide, Func<string, T> convertirDesdeLinea)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    CrearArchivo(ruta);
                }

                using (var sr = new StreamReader(ruta))
                {
                    string linea;
                    bool primeraLinea = true;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (primeraLinea)
                        {
                            primeraLinea = false;
                            continue;
                        }

                        var objeto = convertirDesdeLinea(linea);
                        if (coincide(objeto))
                        {
                            return objeto;
                        }
                    }
                }

                return default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el registro: " + ex.Message);
                return default;
            }
        }
    }    
}
