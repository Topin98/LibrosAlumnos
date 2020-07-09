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
    public partial class frmActualizacionesAlumnos : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        BindingList<Alumno> BLAlumnos;
        BindingList<Alumno> BLAlumnosCopia = new BindingList<Alumno>(); //esta es obligario inicializarla porque si no en el foreach peta al ser null
        frmInsertarAlumnos venInsertarAlumnos;

        public frmActualizacionesAlumnos()
        {
            InitializeComponent();
        }

        private void frmActualizacionesAlumnos_Load(object sender, EventArgs e)
        {
            this.resetearFechaDevolucion();

            try
            {
                daoBaseDatos.AbrirConexion();

                BLAlumnos = daoBaseDatos.CargarAlumnos();

                //copia de los alumnos para luego aplicar el filtro
                foreach (Alumno alumno in BLAlumnos) BLAlumnosCopia.Add(alumno);

                LBAlumnos.DataSource = BLAlumnos;
                LBAlumnos.DisplayMember = "NombreCompleto";

                if (BLAlumnos.Count != 0)
                {
                    LBAlumnos.SetSelected(0, true);
                }
                else
                {
                    this.mostrarMensaje("La base de datos no contiene ningún alumno");
                    btnBorrar.Enabled = false;
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

        private void LBIDAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = (Alumno)LBAlumnos.SelectedItem;
                txbIDAlumno.Text = alumno.IDAlumno.ToString();
                txbApellidos.Text = alumno.Apellidos;
                txbNombre.Text = alumno.Nombre;
                txbCurso.Text = alumno.Curso;
                DTPFechaEntrega.Value = alumno.FechaEntrega;
                if (alumno.FechaDevolucion.Date.ToString() != "01/01/0001 0:00:00")
                {
                    DTPFechaDevolucion.Value = alumno.FechaDevolucion;
                    CBDevuelto.Checked = true;
                }
                else
                {
                    CBDevuelto.Checked = false;
                }
                txbExpediente.Text = alumno.Expediente.ToString();
                CBBilingue.SelectedItem = alumno.Bilingue ? "Sí" : "No";
                CBBecario.SelectedItem = alumno.Becario ? "Sí" : "No";
                CBActivo.SelectedItem = alumno.Activo ? "Sí" : "No";
                txbObservaciones.Text = alumno.Observaciones;
            }
            catch (NullReferenceException)
            {
                //excepcion que se produce al eliminar el ultimo alumno, borramos los textos de los TextBox menos el de filtrar
                foreach (TextBox aux in this.Controls.OfType<TextBox>())
                {
                    if (aux != txbFiltrar) aux.Clear();
                }
            }
        }

        private void CBEntregado_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDevuelto.Checked)
            {
                DTPFechaDevolucion.Format = DateTimePickerFormat.Short;
                DTPFechaDevolucion.Value = DateTime.Today;
            }
            else
            {
                this.resetearFechaDevolucion();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            venInsertarAlumnos = new frmInsertarAlumnos(BLAlumnos, BLAlumnosCopia, btnBorrar);
            venInsertarAlumnos.ShowDialog();

            if (btnBorrar.Enabled)
            {
                LBAlumnos.SetSelected(LBAlumnos.Items.Count - 1, true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comprobarDatos())
                {
                    Alumno alumno = (Alumno)LBAlumnos.SelectedItem;

                    if (this.crearAlumno(alumno))
                    {
                        try
                        {
                            daoBaseDatos.AbrirConexion();

                            daoBaseDatos.ActualizarAlumno(alumno);

                            this.mostrarMensaje("Se ha actualizado correctamente el alumno");
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
                    this.mostrarMensaje("Los datos obligatorios deben estar rellenados");
                }
            }
            catch (Exception error)
            {
                this.mostrarMensaje(error.Message);
            }
        }

        private bool comprobarDatos()
        {
            bool exito = true;

            foreach (TextBox aux in this.Controls.OfType<TextBox>())
            {
                if (aux.Text == "" && aux.Name != "txbObservaciones" && aux.Name != "txbFiltrar")
                {
                    exito = false;
                }
            }

            return exito;
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
                if (CBDevuelto.Checked) alumno.FechaDevolucion = DTPFechaDevolucion.Value;
                else alumno.FechaDevolucion = new DateTime();
                alumno.Expediente = Convert.ToInt32(txbExpediente.Text);
                alumno.Bilingue = CBBilingue.SelectedItem.ToString() == "Sí";
                alumno.Becario = CBBecario.SelectedItem.ToString() == "Sí";
                alumno.Activo = CBActivo.SelectedItem.ToString() == "Sí";
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

        private void btnResetear_Click(object sender, EventArgs e)
        {
            foreach (TextBox aux in this.Controls.OfType<TextBox>())
            {
                if (aux.Name != "txbIDAlumno") aux.Clear();
            }

            DTPFechaEntrega.Value = DateTime.Today;
            CBDevuelto.Checked = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que quiere borrar el alumno?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Alumno alumno = (Alumno)LBAlumnos.SelectedItem;
                int index = LBAlumnos.SelectedIndex;

                try
                {
                    daoBaseDatos.AbrirConexion();

                    daoBaseDatos.BorrarAlumno(alumno);

                    BLAlumnos.Remove(alumno);

                    this.mostrarMensaje("Se ha borrado correctamente el alumno");

                    if (BLAlumnos.Count != 0)
                    {
                        //si se borro el ultimo
                        if (index == LBAlumnos.Items.Count)
                        {
                            //marcamos el nuevo ultimo
                            LBAlumnos.SetSelected(index - 1, true);
                        }
                        else
                        {
                            LBAlumnos.SetSelected(index, true);
                        }
                    }
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

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            BLAlumnos.Clear();

            if (txbFiltrar.Text != "")
            {
                var consulta = BLAlumnosCopia.Where(x => x.NombreCompleto.ToLower().Contains(txbFiltrar.Text.ToLower()));

                foreach (var item in consulta)
                {
                    BLAlumnos.Add(item);
                }
            }
            else
            {
                foreach (Alumno alumno in BLAlumnosCopia) BLAlumnos.Add(alumno);
            }

            try
            {
                LBAlumnos.SetSelected(0, true);
            }
            catch (Exception)
            {
                //excepcion que se produce si no hay resultados
            }
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
