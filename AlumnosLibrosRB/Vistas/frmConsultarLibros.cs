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
    public partial class frmConsultarLibros : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        List<Libro> lLibros;
        int sumLibrosAlta; //si declaramos las variables aqui automaticamente se inicializan a 0
        int sumLibrosBaja;

        public frmConsultarLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            //no cambiar el orden de las dos lineas porque si no da NullException en el mostrar datos ya que salta el evento y la lista aun no se inicializo
            lLibros = new List<Libro>();
            CBFiltrar.SelectedIndex = 0;

            try
            {
                daoBaseDatos.AbrirConexion();

                lLibros = daoBaseDatos.CargarLibros(ref sumLibrosAlta, ref sumLibrosBaja);

                if (lLibros.Count != 0)
                {
                    this.mostrarDatos(lLibros);

                    this.mostrarTotal();
                }
                else
                {
                    this.mostrarMensaje("No se han encontrado libros en la base de datos");
                    this.Close();
                }
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

        public void mostrarTotal()
        {
            labSumLibros.Text = "Alta: " + this.sumLibrosAlta + "    Baja: " + this.sumLibrosBaja;
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ListViewPrinter printer = new ListViewPrinter(LVLibrosAlumno, new Point(5, 5), false, false, "Libros");
            printer.print();
        }

        #region Filtros
        private void filtrar(object sender, EventArgs e)
        {
            LVLibrosAlumno.Items.Clear();

            List<Libro> lFiltrados = new List<Libro>();

            if (txbFiltro.Text != "")
            {
                switch (CBFiltrar.SelectedItem.ToString())
                {
                    case "NumRegistro":
                        this.filtrarNumRegion(lFiltrados);
                        break;
                    case "ISBN":
                        this.filtrarISBN(lFiltrados);
                        break;
                    case "Título":
                        this.filtrarTitulo(lFiltrados);
                        break;
                    case "Estado":
                        this.filtrarEstado(lFiltrados);
                        break;
                }

                this.mostrarDatos(lFiltrados);

                this.CalcularTotal(lFiltrados);
            }
            else
            {
                this.mostrarDatos(lLibros);

                this.CalcularTotal(lLibros);
            }
        }

        private void filtrarNumRegion(List<Libro> lFiltrados)
        {
            var consulta = lLibros.Where(x => x.NumRegistro.ToString().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarISBN(List<Libro> lFiltrados)
        {
            var consulta = lLibros.Where(x => x.ISBN.ToLower().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarTitulo(List<Libro> lFiltrados)
        {
            var consulta = lLibros.Where(x => x.Titulo.ToLower().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarEstado(List<Libro> lFiltrados)
        {
            var consulta = lLibros.Where(x => x.Estado.ToLower().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        public void CalcularTotal(List<Libro> lFiltrados)
        {
            this.sumLibrosAlta = lFiltrados.Where(x => x.Estado == "Alta").Count();
            this.sumLibrosBaja = lFiltrados.Where(x => x.Estado == "Baja").Count();

            this.mostrarTotal();
        }
        #endregion
    }
}
