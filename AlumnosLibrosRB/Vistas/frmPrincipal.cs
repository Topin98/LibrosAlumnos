using AlumnosLibrosRB.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosLibrosRB.Vistas
{
    public partial class frmPrincipal : Form
    {
        frmConsultarAlumnos venConsultarAlumnos;
        frmConsultarLibros venConsultarLibros;
        frmPrestarLibros venPrestarLibros;
        frmActualizacionesAlumnos venActualizacionesAlumnos;
        frmActualizacionesLibros venActualizacionesLibros;
        frmEliminarPrestamos venEliminarPrestamos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icono;

            CBAnyo.SelectedIndex = 3; //anyo 20-21
        }

        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        {
            venConsultarAlumnos = new frmConsultarAlumnos(CBAnyo.SelectedItem.ToString());
            venConsultarAlumnos.ShowDialog();
        }

        private void btnConsultarLibros_Click(object sender, EventArgs e)
        {
            venConsultarLibros = new frmConsultarLibros();
            venConsultarLibros.ShowDialog();
        }

        private void btnModificarLibros_Click(object sender, EventArgs e)
        {
            venActualizacionesLibros = new frmActualizacionesLibros();
            venActualizacionesLibros.ShowDialog();
        }

        private void btnModificarAlumnos_Click(object sender, EventArgs e)
        {
            venActualizacionesAlumnos = new frmActualizacionesAlumnos();
            venActualizacionesAlumnos.ShowDialog();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            venPrestarLibros = new frmPrestarLibros(CBAnyo.SelectedItem.ToString());
            venPrestarLibros.ShowDialog();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            venEliminarPrestamos = new frmEliminarPrestamos(CBAnyo.SelectedItem.ToString());
            venEliminarPrestamos.ShowDialog();
        }
    }
}
