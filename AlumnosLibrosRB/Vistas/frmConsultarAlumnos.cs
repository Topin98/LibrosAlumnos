using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumnosLibrosRB.Entidades;
using AlumnosLibrosRB.Modelos;

namespace AlumnosLibrosRB.Vistas
{
    public partial class frmConsultarAlumnos : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        DAOWord daoWord = new DAOWord();
        List<Alumno> lAlumnosLibros;
        List<Alumno> lAlumnosNoLibros;
        frmConsultarLibrosAlumno venConsultarLibrosAlumno;
        frmConsultarAlumnosNL venConsultarAlumnosNL;
        String anyo;
        int sumAlumnosBilingues; //si declaramos las variables aqui automaticamente se inicializan a 0
        int sumAlumnosNoBilingues;
        int sumAlumnosBecarios;
        int sumAlumnosNoBecarios;

        public frmConsultarAlumnos(String anyo)
        {
            InitializeComponent();

            this.anyo = anyo;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            //no cambiar el orden de las dos lineas porque si no da NullException en el mostrar datos ya que salta el evento y la lista aun no se inicializo
            lAlumnosLibros = new List<Alumno>();
            CBFiltrar.SelectedIndex = 2;
            CBBilingue.SelectedIndex = 0;
            CBBecario.SelectedIndex = 0;

            try
            {
                daoBaseDatos.AbrirConexion();

                lAlumnosLibros = daoBaseDatos.CargarDatosAlumnos(anyo); //carga los datos de los alumnos con libros
                lAlumnosNoLibros = daoBaseDatos.CargarDatosAlumnosNL(anyo); //carga los datos de los alumnos sin libros
                if (lAlumnosNoLibros.Count == 0) btnAlumnosNL.Enabled = false;

                this.mostrarDatos(lAlumnosLibros);

                //1 porque es la posicion de la columna del nombre y apellidos
                LVAlumnos.ListViewItemSorter = new ListViewItemComparer(1);
                LVAlumnos.Sort();

                this.mostrarTotal(lAlumnosLibros);
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

        private void mostrarDatos(List<Alumno> lAlumnos)
        {
            string IDLibros = "";

            foreach (Alumno alumno in lAlumnos)
            {
                ListViewItem item = new ListViewItem(alumno.IDAlumno.ToString());
                item.SubItems.Add(alumno.Apellidos + ", " + alumno.Nombre);
                item.SubItems.Add(alumno.Curso);
                item.SubItems.Add(alumno.FechaEntrega.Date.ToString("d"));
                if(alumno.FechaDevolucion.Date.ToString() != "01/01/0001 0:00:00") item.SubItems.Add(alumno.FechaDevolucion.Date.ToString("d"));
                else item.SubItems.Add("");

                IDLibros = "";
                foreach (int id in alumno.lNumRegistros)
                {
                    IDLibros += id + ", ";
                }
                IDLibros = IDLibros.Substring(0, IDLibros.Length - 2);
                item.SubItems.Add(IDLibros);

                item.SubItems.Add(alumno.Expediente.ToString());
                item.SubItems.Add(alumno.Bilingue ? "Sí" : "No");
                item.SubItems.Add(alumno.Becario ? "Sí" : "No");

                item.SubItems.Add(alumno.Observaciones);

                LVAlumnos.Items.Add(item);
            }
        }

        public void mostrarTotal(List<Alumno> lAlumnosMostrar)
        {
            sumAlumnosBilingues = lAlumnosMostrar.Where(x => x.Bilingue).Count();
            sumAlumnosNoBilingues = lAlumnosMostrar.Where(x => !x.Bilingue).Count();
            sumAlumnosBecarios = lAlumnosMostrar.Where(x => x.Becario).Count();
            sumAlumnosNoBecarios = lAlumnosMostrar.Where(x => !x.Becario).Count();

            labSumAlumnos.Text = "Alumnos: " + lAlumnosMostrar.Count + "    Bilingües: " + sumAlumnosBilingues + "    Becarios: " + sumAlumnosBecarios +
                "\n                 No bilingües: " + sumAlumnosNoBilingues + "    No becarios: " + sumAlumnosNoBecarios;

            //partiendo de la base de que si un alumno tiene una lista de 4 numeros de registro significa que se han realizado 4 prestamos
            //sumamos las longitudes de la listas de los libros de cada alumno
            int total = lAlumnosMostrar.Sum(x => x.lNumRegistros.Count); //uwu

            labLibrosPrestados.Text = "Libros prestados: " + total;

        }

        #region Filtros
        private void filtrar(object sender, EventArgs e)
        {
            LVAlumnos.Items.Clear();

            //lista donde se ponen 
            List<Alumno> lFiltrados = new List<Alumno>();

            if (txbFiltro.Text != "")
            {
                switch (CBFiltrar.SelectedItem.ToString())
                {
                    case "ID": this.filtrarIDAlumno(lFiltrados);
                        break;
                    case "Alumno": this.filtrarAlumno(lFiltrados);
                        break;
                    case "Curso": this.filtrarCurso(lFiltrados);
                        break;
                    case "IDLibro": this.filtrarIDLibro(lFiltrados);
                        break;
                    case "Observaciones": this.filtrarObservaciones(lFiltrados);
                        break;
                }  
            }
            else
            {
                //OJO: con cambiar el orden de los items de los ComboBox porque rip el metodo de ordenacion
                var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0));

                foreach (var item in consulta)
                {
                    lFiltrados.Add(item);
                }
            }

            this.mostrarDatos(lFiltrados);

            this.mostrarTotal(lFiltrados);
        }

        private void filtrarIDAlumno(List<Alumno> lFiltrados)
        {
            var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0) && x.IDAlumno.ToString().Contains(txbFiltro.Text));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarAlumno(List<Alumno> lFiltrados)
        {
            var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0) && (x.Nombre.ToLower().Contains(txbFiltro.Text.ToLower()) || x.Apellidos.ToLower().Contains(txbFiltro.Text.ToLower())));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarCurso(List<Alumno> lFiltrados)
        {
            var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0) && x.Curso.ToLower().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }

        private void filtrarIDLibro(List<Alumno> lFiltrados)
        {
            try
            {
                var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0) && x.lNumRegistros.Contains(Convert.ToInt32(txbFiltro.Text)));

                foreach (var item in consulta)
                {
                    lFiltrados.Add(item);
                }
            }
            catch (Exception)
            {
                //excepcion que se produce si se escribe texto en el TextBox cuando esta seleccionada la opcion de IDLibro en el ComboBox, no hacemos nada
            }
        }

        private void filtrarObservaciones(List<Alumno> lFiltrados)
        {
            var consulta = lAlumnosLibros.Where(x => ((x.Bilingue == (CBBilingue.SelectedIndex == 1)) || CBBilingue.SelectedIndex == 0) && ((x.Becario == (CBBecario.SelectedIndex == 1)) || CBBecario.SelectedIndex == 0) && x.Observaciones != null && x.Observaciones.ToLower().Contains(txbFiltro.Text.ToLower()));

            foreach (var item in consulta)
            {
                lFiltrados.Add(item);
            }
        }
        #endregion

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlumnosNL_Click(object sender, EventArgs e)
        {
            venConsultarAlumnosNL = new frmConsultarAlumnosNL(lAlumnosNoLibros);
            venConsultarAlumnosNL.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            LVaux.Items.Clear();

            //pasamos la info de un ListView a otro
            foreach (ListViewItem item in LVAlumnos.Items)
            {
                ListViewItem fila = new ListViewItem(item.Text);
                fila.SubItems.Add(item.SubItems[1].Text);
                fila.SubItems.Add(item.SubItems[2].Text);
                fila.SubItems.Add(item.SubItems[5].Text);
                fila.SubItems.Add(item.SubItems[6].Text);
                fila.SubItems.Add(item.SubItems[7].Text);
                fila.SubItems.Add(item.SubItems[8].Text);

                LVaux.Items.Add(fila);
            }

            ListViewPrinter printer = new ListViewPrinter(LVaux, new Point(15,5), false, false, "Alumnos");
            printer.print();
        }

        private void CMS_Opening(object sender, CancelEventArgs e)
        {
            if (LVAlumnos.SelectedItems.Count != 1)
            {
                TSMIVerLibros.Visible = false;
            }
            else
            {
                TSMIVerLibros.Visible = true;
            }
        }

        private void TSMIVerLibros_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in lAlumnosLibros)
            {
                if (alumno.IDAlumno == Convert.ToInt32(LVAlumnos.SelectedItems[0].Text))
                {
                    try
                    {
                        venConsultarLibrosAlumno = new frmConsultarLibrosAlumno(alumno);
                        venConsultarLibrosAlumno.Show();

                    }
                    catch (Exception error)
                    {
                        this.mostrarMensaje(error.Message);
                    }
                }
            }
        }

        private void GenerarAnexo(object sender, EventArgs e)
        {
            String plantilla;

            ToolStripMenuItem aux = (ToolStripMenuItem)sender;

            plantilla = aux.Name == "TSMIGAPrestamo" ? "\\plantilla_prestamo.docx" : "\\plantilla_recogida.doc";

            daoBaseDatos.AbrirConexion();

            foreach (ListViewItem item in LVAlumnos.SelectedItems)
            {
                Alumno alumno = lAlumnosLibros.Where(x => x.IDAlumno.ToString() == item.Text).FirstOrDefault();

                try
                {
                    List<Libro> lLibros = daoBaseDatos.CargarLibrosAlumno(alumno.lNumRegistros);

                    String respuesta = daoWord.GenerarWord(alumno, lLibros, plantilla);

                    //si hubo errores
                    if (respuesta != "")
                    {
                        //mostramos el mensaje y no generamos mas word
                        this.mostrarMensaje(respuesta);
                        break;
                    }

                }
                catch (Exception error)
                {
                    this.mostrarMensaje(error.Message);
                }
            }

            daoBaseDatos.CerrarConexion();
        }

        private void LVAlumnos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            LVAlumnos.ListViewItemSorter = new ListViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            LVAlumnos.Sort();
        }
    }

    // Implements the manual sorting of items by columns.
    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            //si no es la columna del id del alumno
            if (col != 0)
            {
                //magia de internet
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
            else
            {
                //uh, funciona
                return Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) > Convert.ToInt32(((ListViewItem)y).SubItems[col].Text) ? 1 : -1;
            }
            
        }
    }
}
