using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosLibrosRB.Entidades;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace AlumnosLibrosRB.Modelos
{
    public class DAOWord
    {
        //a mi yo del futuro: este metodo es mitad de joaquin mitad de un pavo de google, funciona pero probablemente pienses que que estabas haciendo con tu vida cuando lo codificaste
        public String GenerarWord(Alumno alumno, List<Libro> lLibros, string rutaPlantilla)
        {
            String mensajeRet = "";
            object docPlantilla = System.Windows.Forms.Application.StartupPath + rutaPlantilla;    // Nombre del fichero dotx - plantilla -

            if (File.Exists(docPlantilla.ToString()))
            {

                //esta linea abre un word
                Microsoft.Office.Interop.Word.Application wrdApp = new Microsoft.Office.Interop.Word.Application();

                object missing = System.Reflection.Missing.Value;
                object oFalse = false; // Objeto que se pasa por referencia y que sera true para que pare el proceso si hay problemas y false para que continue y genere un nuevo documento con los problemas
                object isVisible = true;
                wrdApp.Visible = true;

                try
                {
                    // Apertura del documento Word
                    Document wrdDoc = wrdApp.Documents.Open(ref docPlantilla, ref missing, ref missing, ref missing, ref missing, ref missing,
                                                                                            ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible,
                                                                                            ref missing, ref missing, ref missing, ref missing);

                    this.ReplaceBookmark(wrdDoc, "ID", alumno.IDAlumno.ToString());
                    this.ReplaceBookmark(wrdDoc, "APELLIDOS", alumno.Apellidos);
                    this.ReplaceBookmark(wrdDoc, "NOMBRE", alumno.Nombre);
                    this.ReplaceBookmark(wrdDoc, "CURSO", alumno.Curso.Substring(0,2));
                    this.ReplaceBookmark(wrdDoc, "GRUPO", alumno.Curso.Substring(2,1));
                    this.ReplaceBookmark(wrdDoc, "EXPEDIENTE", alumno.Expediente.ToString());
                    this.ReplaceBookmark(wrdDoc, "BILINGUE", alumno.Bilingue ? "Bilingüe" : "");
                    this.ReplaceBookmark(wrdDoc, "BILINGUEBOOL", alumno.Bilingue ? "Sí" : "No");
                    this.ReplaceBookmark(wrdDoc, "BECARIO", alumno.Becario ? "Becario" : "");
                    this.ReplaceBookmark(wrdDoc, "BECARIOBOOL", alumno.Becario ? "Sí" : "No");

                    for (int i = 0; i < 7; i++)
                    {
                        if (i < lLibros.Count)
                        {
                            this.ReplaceBookmark(wrdDoc, "LIBRO" + i, lLibros[i].Titulo);
                            this.ReplaceBookmark(wrdDoc, "REF" + i, lLibros[i].NumRegistro.ToString());
                            this.ReplaceBookmark(wrdDoc, "OBSERVACIONES" + i, lLibros[i].Observaciones);
                            this.ReplaceBookmark(wrdDoc, "VOLUMENES" + i, lLibros[i].Volumenes.ToString());
                        }
                        else
                        {
                            this.ReplaceBookmark(wrdDoc, "LIBRO" + i, "");
                            this.ReplaceBookmark(wrdDoc, "REF" + i, "");
                            this.ReplaceBookmark(wrdDoc, "OBSERVACIONES" + i, "");
                            this.ReplaceBookmark(wrdDoc, "VOLUMENES" + i, "");
                        }
                    }

                    //mensajeRet = "Proceso completado correctamente";
                    
                }
                catch (Exception msgError)
                {
                    //retornamos que el proceso no se realizo correctamente
                    mensajeRet = msgError.Message;
                }
            }
            else
            {
                mensajeRet = "El fichero word plantilla no existe";
            }

            return mensajeRet;
        }

        public void ReplaceBookmark(Document wrdDoc, String name, String value)
        {
            //si no existe peta asi que este if es necesario
            if (wrdDoc.Bookmarks.Exists(name))
            {
                Object bookmarkName = name;
                Range range = wrdDoc.Bookmarks.get_Item(ref bookmarkName).Range;
                range.Text = value;
                object newRange = range;
                wrdDoc.Bookmarks.Add(bookmarkName.ToString(), ref newRange);
            }
            
        }

        public String FormatearLibros(List<Libro> lLibros)
        {
            String cadena = "";

            foreach (Libro libro in lLibros)
            {
                cadena += "\t- " + libro.Titulo + " (" + libro.NumRegistro + ")\n"; 
            }

            return cadena;
        }
    }
}
