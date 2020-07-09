using AlumnosLibrosRB.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosLibrosRB.Modelos
{
    class DAOBaseDatos
    {
        static string cadenaConexion = ConfigurationManager.AppSettings.Get("cadenaConexion");
        MySqlConnection conexion = null;

        public void AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido establecer la conexión con la base de datos");
            }
        }

        //public List<int> CargarIDAlumnos()
        //{
        //    List<int> lIDAlumnos = new List<int>();

        //    MySqlCommand comando = new MySqlCommand();
        //    MySqlDataReader lector = null;

        //    try
        //    {
        //        comando.Connection = conexion;

        //        comando.CommandText = "SELECT IDAlumno FROM Alumnos";

        //        lector = comando.ExecuteReader();

        //        if (lector.HasRows)
        //        {
        //            while (lector.Read())
        //            {
        //                lIDAlumnos.Add(lector.GetInt32(0));
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Se ha producido un error leyendo los IDs de los alumnos");
        //    }
        //    finally
        //    {
        //        lector.Close();
        //    }

        //    return lIDAlumnos;
        //}

        public List<Alumno> CargarDatosAlumnos(String anyo)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando = new MySqlCommand();

                comando.Connection = conexion;

                comando.CommandText = "SELECT Alumnos.IDAlumno, Nombre, Apellidos, Curso, FechaEntrega, FechaDevolucion, Alumnos.Observaciones, Bilingue, Becario, Expediente, GROUP_CONCAT(Libros.NumRegistro) " +
                                      "FROM Alumnos, Libros, LinAlumnosLibros " +
                                      "WHERE Alumnos.IDAlumno = LinAlumnosLibros.IDAlumno AND Libros.NumRegistro = LinAlumnosLibros.NumRegistro AND LinAlumnosLibros.Anyo LIKE @Anyo AND Activo = true " +
                                      "GROUP BY Alumnos.IDAlumno";
                
                comando.Parameters.AddWithValue("@Anyo", anyo);

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Alumno alumno = new Alumno();
                        alumno.IDAlumno = lector.GetInt32(0);
                        alumno.Nombre = lector.GetString(1);
                        alumno.Apellidos = lector.GetString(2);
                        alumno.Curso = lector.GetString(3);
                        alumno.FechaEntrega = lector.GetDateTime(4);

                        try
                        {
                            alumno.FechaDevolucion = lector.GetDateTime(5);
                        }
                        catch (Exception)
                        {
                            //no hacemos nada ya que no admite null, luego miramos a ver si esta la fecha por defecto
                        }

                        try
                        {
                            alumno.Observaciones = lector.GetString(6);
                        }
                        catch (Exception)
                        {
                            alumno.Observaciones = null;
                        }

                        alumno.Bilingue = lector.GetBoolean(7);
                        alumno.Becario = lector.GetBoolean(8);
                        alumno.Expediente = lector.GetInt32(9);

                        alumno.lNumRegistros = lector.GetString(10).Split(',').Select(int.Parse).ToList();

                        lAlumnos.Add(alumno);
                    }
                }

                lector.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los alumnos");
            }
            finally
            {
                lector.Close();
            }

            return lAlumnos;
        }

        public List<Alumno> CargarDatosAlumnosNL(String anyo)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "SELECT Alumnos.IDAlumno, Nombre, Apellidos, Curso, Observaciones, Bilingue, Becario, Expediente " +
                                       "FROM Alumnos WHERE Alumnos.IDAlumno NOT IN (SELECT IDAlumno FROM LinAlumnosLibros WHERE anyo LIKE @Anyo) AND Activo = true";

                comando.Parameters.AddWithValue("@Anyo", anyo);

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Alumno alumno = new Alumno();
                        alumno.IDAlumno = lector.GetInt32(0);
                        alumno.Nombre = lector.GetString(1);
                        alumno.Apellidos = lector.GetString(2);
                        alumno.Curso = lector.GetString(3);

                        try
                        {
                            alumno.Observaciones = lector.GetString(4);
                        }
                        catch (Exception)
                        {
                            alumno.Observaciones = null;
                        }

                        alumno.Bilingue = lector.GetBoolean(5);
                        alumno.Becario = lector.GetBoolean(6);
                        alumno.Expediente = lector.GetInt32(7);

                        lAlumnos.Add(alumno);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los alumnos sin libros");
            }
            finally
            {
                lector.Close();
            }

            return lAlumnos;
        }

        public List<Libro> CargarLibrosAlumno(List<int> lNumRegistros)
        {
            List<Libro> lLibros = new List<Libro>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                foreach (int i in lNumRegistros)
                {
                    comando = new MySqlCommand();

                    comando.Connection = conexion;

                    comando.CommandText = "SELECT NumRegistro, ISBN, Titulo, Volumenes, FechaCompra, Observaciones, Estado " +
                                          "FROM Libros " +
                                          "WHERE NumRegistro = @NumRegistro";
                    comando.Parameters.AddWithValue("@NumRegistro", i);

                    lector = comando.ExecuteReader();

                    lector.Read();

                    Libro libro = new Libro();
                    libro.NumRegistro = lector.GetInt32(0);
                    libro.ISBN = lector.GetString(1);
                    libro.Titulo = lector.GetString(2);
                    libro.Volumenes = lector.GetInt32(3);
                    libro.FechaCompra = lector.GetDateTime(4);

                    try
                    {
                        libro.Observaciones = lector.GetString(5);
                    }
                    catch (Exception)
                    {
                        libro.Observaciones = null;
                    }

                    libro.Estado = lector.GetString(6);

                    lLibros.Add(libro);

                    lector.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los alumnos");
            }
            finally
            {
                lector.Close();
            }

            return lLibros;
        }

        public List<Libro> CargarLibros(ref int sumLibrosAlta, ref int sumLibrosBaja)
        {
            List<Libro> lLibros = new List<Libro>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "SELECT NumRegistro, ISBN, Titulo, Volumenes, FechaCompra, Observaciones, Estado " +
                                      "FROM Libros";

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Libro libro = new Libro();
                        libro.NumRegistro = lector.GetInt32(0);
                        libro.ISBN = lector.GetString(1);
                        libro.Titulo = lector.GetString(2);
                        libro.Volumenes = lector.GetInt32(3);
                        libro.FechaCompra = lector.GetDateTime(4);

                        try
                        {
                            libro.Observaciones = lector.GetString(5);
                        }
                        catch (Exception)
                        {
                            libro.Observaciones = null;
                        }

                        libro.Estado = lector.GetString(6);

                        lLibros.Add(libro);
                    }

                    lector.Close();

                    comando.CommandText = "SELECT COUNT(*) FROM Libros WHERE Estado = 'Alta'";

                    lector = comando.ExecuteReader();

                    lector.Read();

                    sumLibrosAlta = lector.GetInt32(0);

                    lector.Close();

                    comando.CommandText = "SELECT COUNT(*) FROM Libros WHERE Estado = 'Baja'";

                    lector = comando.ExecuteReader();

                    lector.Read();

                    sumLibrosBaja = lector.GetInt32(0);
                }
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los libros");
            }
            finally
            {
                lector.Close();
            }

            return lLibros;
        }

        public void InsertarLibro(Libro libro)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO Libros(NumRegistro, ISBN, Titulo, Volumenes, FechaCompra, Observaciones, Estado) " +
                                      "VALUES(@NumRegistro, @ISBN, @Titulo, @Volumenes, @FechaCompra, @Observaciones, @Estado)";
                comando.Parameters.AddWithValue("@NumRegistro", libro.NumRegistro);
                comando.Parameters.AddWithValue("@ISBN", libro.ISBN);
                comando.Parameters.AddWithValue("@Titulo", libro.Titulo);
                comando.Parameters.AddWithValue("@Volumenes", libro.Volumenes);
                comando.Parameters.AddWithValue("@FechaCompra", libro.FechaCompra);
                if (libro.Observaciones == "")
                {
                    comando.Parameters.AddWithValue("@Observaciones", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Observaciones", libro.Observaciones);
                }
                comando.Parameters.AddWithValue("@Estado", libro.Estado);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas != 1) throw new Exception("Se ha producido un error insertando el libro");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ActualizarLibro(Libro libro)
        {
            bool exito;
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "UPDATE Libros " +
                                      "SET ISBN = @ISBN, Titulo = @Titulo, Volumenes = @Volumenes, FechaCompra = @FechaCompra, Observaciones = @Observaciones, Estado = @Estado " +
                                      "WHERE NumRegistro = @NumRegistro";
                comando.Parameters.AddWithValue("@ISBN", libro.ISBN);
                comando.Parameters.AddWithValue("@Titulo", libro.Titulo);
                comando.Parameters.AddWithValue("@Volumenes", libro.Volumenes);
                comando.Parameters.AddWithValue("@FechaCompra", libro.FechaCompra);
                if (libro.Observaciones == "")
                {
                    comando.Parameters.AddWithValue("@Observaciones", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Observaciones", libro.Observaciones);
                }
                comando.Parameters.AddWithValue("@Estado", libro.Estado);
                if (libro.Estado == "Baja")
                {
                    this.ComprobarPrestamos(libro.NumRegistro);
                }
                comando.Parameters.AddWithValue("@NumRegistro", libro.NumRegistro);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas != 1) throw new Exception("Se ha producido un error actualizando el libro");

                exito = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return exito;
        }

        public void ComprobarPrestamos(int numRegistro)
        {
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "SELECT NumRegistro FROM LinAlumnosLibros WHERE NumRegistro = @NumRegistro";
                comando.Parameters.AddWithValue("@NumRegistro", numRegistro);

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    throw new Exception("No se puede dar de baja el libro ya que aún lo posee un alumno");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                lector.Close();
            }
        }

        public void InsertarAlumno(Alumno alumno)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO Alumnos(IDAlumno, Apellidos, Nombre, Curso, FechaEntrega, FechaDevolucion, Observaciones, Bilingue, Becario, Expediente) " +
                                      "VALUES(@IDAlumno, @Apellidos, @Nombre, @Curso, @FechaEntrega, @FechaDevolucion, @Observaciones, @Bilingue, @Becario, @Expediente)";
                comando.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);
                comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
                comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@Curso", alumno.Curso);
                comando.Parameters.AddWithValue("@FechaEntrega", alumno.FechaEntrega);
                comando.Parameters.AddWithValue("@Bilingue", alumno.Bilingue);
                comando.Parameters.AddWithValue("@Becario", alumno.Becario);
                comando.Parameters.AddWithValue("@Expediente", alumno.Expediente);

                if (alumno.FechaDevolucion.Date.ToString() == "01/01/0001 0:00:00")
                {
                    comando.Parameters.AddWithValue("@FechaDevolucion", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@FechaDevolucion", alumno.FechaDevolucion);
                }

                if (alumno.Observaciones == "")
                {
                    comando.Parameters.AddWithValue("@Observaciones", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Observaciones", alumno.Observaciones);
                }

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas != 1) throw new Exception("Se ha producido un error insertando el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ActualizarAlumno(Alumno alumno/*, ref string mensajeExito*/)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "UPDATE Alumnos " +
                                      "SET Apellidos = @Apellidos, Nombre = @Nombre, Curso = @Curso, FechaEntrega = @FechaEntrega, FechaDevolucion = @FechaDevolucion, Observaciones = @Observaciones, Bilingue = @Bilingue, Becario = @Becario, Expediente = @Expediente, Activo = @Activo " +
                                      "WHERE IDAlumno = @IDAlumno";
                comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
                comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@Curso", alumno.Curso);
                comando.Parameters.AddWithValue("@FechaEntrega", alumno.FechaEntrega);
                comando.Parameters.AddWithValue("@Bilingue", alumno.Bilingue);
                comando.Parameters.AddWithValue("@Becario", alumno.Becario);
                comando.Parameters.AddWithValue("@Activo", alumno.Activo);
                comando.Parameters.AddWithValue("@Expediente", alumno.Expediente);

                if (alumno.FechaDevolucion.Date.ToString() == "01/01/0001 0:00:00")
                {
                    comando.Parameters.AddWithValue("@FechaDevolucion", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@FechaDevolucion", alumno.FechaDevolucion);
                    /*if (this.EliminarPrestamos(alumno.IDAlumno)) mensajeExito += "\nSe han eliminado los prestamos asociados al alumno";
                    else mensajeExito += "\nNo se han podido eliminar los prestamos asociados al alumno";*/
                }

                if (alumno.Observaciones == "")
                {
                    comando.Parameters.AddWithValue("@Observaciones", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Observaciones", alumno.Observaciones);
                }

                comando.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas != 1) throw new Exception("Se ha producido un error actualizando el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /*public bool EliminarPrestamos(int IDAlumno)
        {
            bool exito;

            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM LinAlumnosLibros " +
                                      "WHERE IDAlumno = @IDAlumno";
                comando.Parameters.AddWithValue("@IDAlumno", IDAlumno);

                int filasAfectadas = comando.ExecuteNonQuery();

                exito = true;
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }*/

        public void RealizarPrestamo(String iDAlumno, String numRegistro, String anyo)
        {
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando.Connection = conexion;

                //aunque sea una funcion en MySql hay que poner esto
                comando.CommandType = CommandType.StoredProcedure;

                //indicamos el nombre del procedimiento
                comando.CommandText = "fnRealizarPrestamo";

                comando.Parameters.AddWithValue("@p_IDAlumno", iDAlumno);
                comando.Parameters.AddWithValue("@p_NumRegistro", numRegistro);
                comando.Parameters.AddWithValue("@p_Anyo", anyo);

                //parametro que guardara el return de la funcion
                MySqlParameter resultado = new MySqlParameter();
                resultado.Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add(resultado);

                lector = comando.ExecuteReader();
                lector.Read(); //sabemos que va devolver un valor siempre
                if (lector.GetInt32(0) != 0) throw new Exception("Se ha producido un error realizando el préstamo.\nCompruebe que tanto el alumno como el libro existen actualmente en la base de datos, que el alumno no tiene rellenado el campo \"Fecha Devolucion\" y que el libro no esté dado de baja.\n");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                lector.Close();
            }
        }

        public BindingList<Alumno> CargarAlumnos()
        {
            BindingList<Alumno> BLAlumno = new BindingList<Alumno>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando = new MySqlCommand();

                comando.Connection = conexion;

                comando.CommandText = "SELECT IDAlumno, Nombre, Apellidos, Curso, FechaEntrega, FechaDevolucion, Observaciones, Bilingue, Becario, Expediente, Activo " +
                                        "FROM Alumnos";

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Alumno alumno = new Alumno();
                        alumno.IDAlumno = lector.GetInt32(0);
                        alumno.Nombre = lector.GetString(1);
                        alumno.Apellidos = lector.GetString(2);
                        alumno.Curso = lector.GetString(3);
                        alumno.FechaEntrega = lector.GetDateTime(4);

                        try
                        {
                            alumno.FechaDevolucion = lector.GetDateTime(5);
                        }
                        catch (Exception)
                        {
                            //no hacemos nada ya que no admite null, luego miramos a ver si esta la fecha por defecto
                        }

                        try
                        {
                            alumno.Observaciones = lector.GetString(6);
                        }
                        catch (Exception)
                        {
                            alumno.Observaciones = null;
                        }

                        alumno.Bilingue = lector.GetBoolean(7);
                        alumno.Becario = lector.GetBoolean(8);
                        alumno.Expediente = lector.GetInt32(9);
                        alumno.Activo = lector.GetBoolean(10);

                        BLAlumno.Add(alumno);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los alumnos");
            }
            finally
            {
                lector.Close();
            }

            return BLAlumno;
        }

        public BindingList<Libro> CargarLibrosBL()
        {
            BindingList<Libro> BLLibros = new BindingList<Libro>();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader lector = null;

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "SELECT NumRegistro, ISBN, Titulo, Volumenes, FechaCompra, Observaciones, Estado " +
                                      "FROM Libros";

                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Libro libro = new Libro();
                        libro.NumRegistro = lector.GetInt32(0);
                        libro.ISBN = lector.GetString(1);
                        libro.Titulo = lector.GetString(2);
                        libro.Volumenes = lector.GetInt32(3);
                        libro.FechaCompra = lector.GetDateTime(4);

                        try
                        {
                            libro.Observaciones = lector.GetString(5);
                        }
                        catch (Exception)
                        {
                            libro.Observaciones = null;
                        }

                        libro.Estado = lector.GetString(6);

                        BLLibros.Add(libro);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error leyendo los datos de los libros");
            }
            finally
            {
                lector.Close();
            }

            return BLLibros;
        }

        public void EliminarPrestamo(String iDAlumno, String numRegistro, String anyo)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                //indicamos el nombre del procedimiento
                comando.CommandText = "DELETE FROM LinAlumnosLibros " +
                                      "WHERE IDAlumno = @IDAlumno AND NumRegistro = @NumRegistro AND Anyo = @Anyo";

                comando.Parameters.AddWithValue("@IDAlumno", iDAlumno);
                comando.Parameters.AddWithValue("@NumRegistro", numRegistro);
                comando.Parameters.AddWithValue("@Anyo", anyo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas != 1) throw new Exception("Ese préstamo no existe en la base de datos");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void BorrarAlumno(Alumno alumno)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM Alumnos WHERE IDAlumno = @IDAlumno";
                comando.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);

                //no hace guardar las filas ya que el alumno va existir fijo y si da error por FK da excepcion directamente
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error borrando el alumno.\nCompruebe que el alumno no posea ningún libro en este momento. Si tiene elimine los préstamos y luego vuelva a intentarlo.");
            }
        }

        public void BorrarLibro(Libro libro)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM Libros WHERE NumRegistro = @NumRegistro";
                comando.Parameters.AddWithValue("@NumRegistro", libro.NumRegistro);

                //no hace guardar las filas ya que el libro va existir fijo y si da error por FK da excepcion directamente
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error borrando el libro.\nCompruebe que ningún alumno posea el libro en este momento. Si es así elimine el préstamo y luego vuelva a intentarlo.");
            }
        }

        public void CerrarConexion()
        {
            try { conexion.Close(); }
            catch (Exception) { }
        }
    }
}
