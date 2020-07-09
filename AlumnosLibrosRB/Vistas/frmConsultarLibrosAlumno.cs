using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumnosLibrosRB.Modelos;
using AlumnosLibrosRB.Entidades;

namespace AlumnosLibrosRB.Vistas
{
    public partial class frmConsultarLibrosAlumno : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        Alumno alumno;

        public frmConsultarLibrosAlumno(Alumno alumno)
        {
            InitializeComponent();

            this.alumno = alumno;
        }

        private void frmLibrosAlumno_Load(object sender, EventArgs e)
        {
            this.Text = "Libros de " + alumno.Nombre + " " + alumno.Apellidos;

            try
            {
                daoBaseDatos.AbrirConexion();

                List<Libro> lLibros = daoBaseDatos.CargarLibrosAlumno(alumno.lNumRegistros);

                this.mostrarDatos(lLibros);
            }
            catch (Exception error)
            {
                this.mostrarMensaje(error.Message);
                this.Close();
            }
            finally
            {
                daoBaseDatos.CerrarConexion();
            }
        }

        public void mostrarDatos(List<Libro> lLibros)
        {
            foreach (Libro libro in lLibros)
            {
                ListViewItem item = new ListViewItem(libro.NumRegistro.ToString());
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Volumenes.ToString());
                item.SubItems.Add(libro.FechaCompra.Date.ToString("d"));
                item.SubItems.Add(libro.Observaciones);
                item.SubItems.Add(libro.Estado);

                LVLibrosAlumno.Items.Add(item);

            }
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
