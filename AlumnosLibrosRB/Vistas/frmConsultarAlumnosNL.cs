using System;
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
    public partial class frmConsultarAlumnosNL : Form
    {
        List<Alumno> lAlumnos;
        int sumAlumnosBilingues;
        int sumAlumnosNoBilingues;
        int sumAlumnosBecarios;
        int sumAlumnosNoBecarios;

        public frmConsultarAlumnosNL(List<Alumno> lAlumnos)
        {
            InitializeComponent();

            this.lAlumnos = lAlumnos;
        }

        private void frmConsultarAlumnosNL_Load(object sender, EventArgs e)
        {
            CBFiltrar.SelectedIndex = 2; //no hace falta usar el metodo mostrar datos porque se ejecuta automaticamente debido a que se produce el evento SelectedIndexChanged del ComboBox (metodo mostrarDatos)
        }

        private void mostrarDatos(List<Alumno> lAlumnos)
        {
            foreach (Alumno alumno in lAlumnos)
            {
                ListViewItem item = new ListViewItem(alumno.IDAlumno.ToString());
                item.SubItems.Add(alumno.Apellidos + ", " + alumno.Nombre);
                item.SubItems.Add(alumno.Curso);
                item.SubItems.Add(alumno.Expediente.ToString());
                item.SubItems.Add(alumno.Bilingue ? "Sí" : "No");
                item.SubItems.Add(alumno.Becario ? "Sí" : "No");
                item.SubItems.Add(alumno.Observaciones);

                LVAlumnos.Items.Add(item);
            }

            this.mostrarTotal(lAlumnos);

            //1 porque es la posicion de la columna del nombre y apellidos
            LVAlumnos.ListViewItemSorter = new ListViewItemComparer(1);
            LVAlumnos.Sort();
        }

        private void mostrarTotal(List<Alumno> lAlumnosMostrar)
        {
            sumAlumnosBilingues = lAlumnosMostrar.Where(x => x.Bilingue).Count();
            sumAlumnosNoBilingues = lAlumnosMostrar.Where(x => !x.Bilingue).Count();
            sumAlumnosBecarios = lAlumnosMostrar.Where(x => x.Becario).Count();
            sumAlumnosNoBecarios = lAlumnosMostrar.Where(x => !x.Becario).Count();

            labSumAlumnos.Text = "Alumnos: " + lAlumnosMostrar.Count + "    Bilingües: " + sumAlumnosBilingues + "    Becarios: " + sumAlumnosBecarios +
                "\n                 No bilingües: " + sumAlumnosNoBilingues + "    No becarios: " + sumAlumnosNoBecarios;

        }

        private void filtrar(object sender, EventArgs e)
        {
            LVAlumnos.Items.Clear();

            List<Alumno> lFiltrados = new List<Alumno>();

            if (txbFiltro.Text != "")
            {
                switch (CBFiltrar.SelectedItem.ToString())
                {
                    case "IDAlumno":
                        this.filtrarIDAlumno(lFiltrados);
                        break;
                    case "Alumno":
                        this.filtrarAlumno(lFiltrados);
                        break;
                    case "Curso":
                        this.filtrarCurso(lFiltrados);
                        break;
                    case "Observaciones":
                        this.filtrarObservaciones(lFiltrados);
                        break;
                }

                this.mostrarDatos(lFiltrados);
                this.mostrarTotal(lFiltrados);
            }
            else
            {
                this.mostrarDatos(lAlumnos);
                this.mostrarTotal(lAlumnos);
            }
        }

        private void filtrarIDAlumno(List<Alumno> lFiltrados)
        {
            foreach (Alumno alumno in lAlumnos)
            {
                if (alumno.IDAlumno.ToString().Contains(txbFiltro.Text))
                {
                    lFiltrados.Add(alumno);
                }
            }
        }

        private void filtrarAlumno(List<Alumno> lFiltrados)
        {
            foreach (Alumno alumno in lAlumnos)
            {
                if (alumno.Nombre.ToUpper().Contains(txbFiltro.Text.ToUpper()) || alumno.Apellidos.ToUpper().Contains(txbFiltro.Text.ToUpper()))
                {
                    lFiltrados.Add(alumno);
                }
            }
        }

        private void filtrarCurso(List<Alumno> lFiltrados)
        {
            foreach (Alumno alumno in lAlumnos)
            {
                if (alumno.Curso.ToUpper().Contains(txbFiltro.Text.ToUpper()))
                {
                    lFiltrados.Add(alumno);
                }
            }
        }

        private void filtrarObservaciones(List<Alumno> lFiltrados)
        {
            foreach (Alumno alumno in lAlumnos)
            {
                if (alumno.Observaciones != null && alumno.Observaciones.ToUpper().Contains(txbFiltro.Text.ToUpper()))
                {
                    lFiltrados.Add(alumno);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ListViewPrinter printer = new ListViewPrinter(LVAlumnos, new Point(40, 15), false, false, "Alumnos sin libros");
            printer.print();
        }

        private void LVAlumnos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            LVAlumnos.ListViewItemSorter = new ListViewItemComparer(e.Column);
            LVAlumnos.Sort();
        }
    }
}
