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
    public partial class frmInsertarAlumnos : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        BindingList<Alumno> BLAlumnos;
        BindingList<Alumno> BLAlumnosCopia;
        Button btnBorrar;

        public frmInsertarAlumnos(BindingList<Alumno> BLAlumnos, BindingList<Alumno> BLAlumnosCopia, Button btnBorrar)
        {
            InitializeComponent();

            this.BLAlumnos = BLAlumnos;
            this.BLAlumnosCopia = BLAlumnosCopia;
            this.btnBorrar = btnBorrar;
        }

        private void frmInsertarAlumnos_Load(object sender, EventArgs e)
        {
            DTPFechaEntrega.Value = DateTime.Today;
            this.resetearFechaDevolucion();

            CBBilingue.SelectedItem = "No";
            CBBecario.SelectedItem = "Sí";

            this.GenerarID();
        }

        public void GenerarID()
        {
            try
            {
                txbIDAlumno.Text = (BLAlumnos.Select(x => x.IDAlumno).Max() + 1).ToString();
            }
            catch (Exception)
            {
                //si la lista esta vacia peta, no hacemos nada
            }
        }

        private void CheckValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void resetearFechaDevolucion()
        {
            DTPFechaDevolucion.Format = DateTimePickerFormat.Custom;
            DTPFechaDevolucion.CustomFormat = " ";
        }

        private void CBEntregado_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDevolucion.Checked)
            {
                DTPFechaDevolucion.Format = DateTimePickerFormat.Short;
                DTPFechaDevolucion.Value = DateTime.Today;
            }
            else
            {
                this.resetearFechaDevolucion();
            }
        }

        private void txbIDAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            foreach (TextBox aux in this.Controls.OfType<TextBox>())
            {
                aux.Clear();
            }
            
            DTPFechaEntrega.Value = DateTime.Today;
            CBDevolucion.Checked = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.comprobarDatos())
            {
                if (!this.comprobarRepetido())
                {
                    Alumno alumno = new Alumno();

                    if (this.crearAlumno(alumno))
                    {
                        try
                        {
                            daoBaseDatos.AbrirConexion();

                            daoBaseDatos.InsertarAlumno(alumno);

                            BLAlumnos.Add(alumno);
                            BLAlumnosCopia.Add(alumno);

                            this.mostrarMensaje("Se ha insertado correctamente el alumno en la base de datos");

                            btnResetear.PerformClick();

                            this.GenerarID();

                            btnBorrar.Enabled = true;
                        }
                        catch (Exception error)
                        {
                            this.mostrarMensaje(error.Message);
                        }
                        finally
                        {
                            daoBaseDatos.CerrarConexion();
                        }
                    }
                }
                else
                {
                    this.mostrarMensaje("El alumno ya existe. Cierre esta ventana y selecciónelo en la lista para editarlo");
                }
            }
            else
            {
                this.mostrarMensaje("Los datos obligatorios deben estar rellenados");
            }
        }

        private bool comprobarDatos()
        {
            bool exito = true;

            foreach (TextBox aux in this.Controls.OfType<TextBox>())
            {
                if (aux.Text == "" && aux.Name != "txbObservaciones")
                {
                    exito = false;
                }
            }

            return exito;
        }

        private bool comprobarRepetido()
        {
            bool repetido = false;

            foreach (Alumno alumno in BLAlumnos)
            {
                if (alumno.IDAlumno == Convert.ToInt32(txbIDAlumno.Text))
                {
                    repetido = true;
                    break;
                }
            }

            return repetido;
        }

        private bool crearAlumno(Alumno alumno)
        {
            bool exito;

            try
            {
                alumno.IDAlumno = Convert.ToInt32(txbIDAlumno.Text);
                alumno.Apellidos = txbApellidos.Text;
                alumno.Nombre = txbNombre.Text;
                alumno.Curso = txbCurso.Text;
                alumno.FechaEntrega = DTPFechaEntrega.Value;
                if (CBDevolucion.Checked) alumno.FechaDevolucion = DTPFechaDevolucion.Value;
                else alumno.FechaDevolucion = new DateTime(); //con new DateTime pone el Date.ToString() a "01/01/0001 0:00:00"
                alumno.Expediente = Convert.ToInt32(txbExpediente.Text);
                alumno.Bilingue = CBBilingue.SelectedItem.ToString() == "Sí";
                alumno.Becario = CBBecario.SelectedItem.ToString() == "Sí";
                alumno.Activo = true;
                alumno.Observaciones = txbObservaciones.Text;

                exito = true;
            }
            catch (Exception e)
            {
                this.mostrarMensaje(e.Message);
                exito = false;
            }

            return exito;
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
