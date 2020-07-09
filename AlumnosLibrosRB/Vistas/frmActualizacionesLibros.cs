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
    public partial class frmActualizacionesLibros : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        BindingList<Libro> BLLibros;
        frmInsertarLibros venInsertarLibros;

        public frmActualizacionesLibros()
        {
            InitializeComponent();
        }

        private void frmActualizacionesLibros_Load(object sender, EventArgs e)
        {
            try
            {
                daoBaseDatos.AbrirConexion();

                BLLibros = daoBaseDatos.CargarLibrosBL();

                LBNumRegistros.DataSource = BLLibros;
                LBNumRegistros.DisplayMember = "NumRegistro";

                if (BLLibros.Count != 0)
                {
                    LBNumRegistros.SetSelected(0, true);
                }
                else
                {
                    this.mostrarMensaje("La base de datos no contiene ningún libro");
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

        private void LBNumRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Libro libro = (Libro)LBNumRegistros.SelectedItem;
                txbNumRegistro.Text = libro.NumRegistro.ToString();
                txbISBN.Text = libro.ISBN;
                txbTitulo.Text = libro.Titulo;
                txbVolumenes.Text = libro.Volumenes.ToString();
                DTPFechaCompra.Value = libro.FechaCompra;
                txbObservaciones.Text = libro.Observaciones;
                CBEstado.SelectedItem = libro.Estado;
            }
            catch (NullReferenceException)
            {
                //excepcion que se produce al eliminar el ultimo libro, borramos los textos de los TextBox
                foreach (TextBox aux in this.Controls.OfType<TextBox>())
                {
                    aux.Clear();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            venInsertarLibros = new frmInsertarLibros(BLLibros, btnBorrar);
            venInsertarLibros.ShowDialog();

            if (btnBorrar.Enabled)
            {
                LBNumRegistros.SetSelected(LBNumRegistros.Items.Count - 1, true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comprobarDatos())
                {
                    Libro libro = (Libro)LBNumRegistros.SelectedItem;

                    if (this.crearLibro(libro))
                    {
                        try
                        {
                            daoBaseDatos.AbrirConexion();

                            daoBaseDatos.ActualizarLibro(libro);

                            this.mostrarMensaje("Se ha actualizado correctamente el libro");
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
                if (aux.Text == "" && aux.Name != "txbObservaciones")
                {
                    exito = false;
                }
            }

            return exito;
        }

        private bool crearLibro(Libro libro)
        {
            bool exito;

            try
            {
                libro.NumRegistro = Convert.ToInt32(txbNumRegistro.Text);
                libro.ISBN = txbISBN.Text;
                libro.Titulo = txbTitulo.Text;
                libro.Volumenes = Convert.ToInt32(txbVolumenes.Text);
                libro.FechaCompra = DTPFechaCompra.Value;
                libro.Observaciones = txbObservaciones.Text;
                libro.Estado = CBEstado.SelectedItem.ToString();

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
                if (aux.Name != "txbNumRegistro") aux.Clear();
            }

            CBEstado.SelectedIndex = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que quiere borrar el libro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Libro libro = (Libro)LBNumRegistros.SelectedItem;
                int index = LBNumRegistros.SelectedIndex;

                try
                {
                    daoBaseDatos.AbrirConexion();

                    daoBaseDatos.BorrarLibro(libro);

                    BLLibros.Remove(libro);

                    this.mostrarMensaje("Se ha borrado correctamente el libro");

                    if (BLLibros.Count != 0)
                    {
                        //si se borro el ultimo
                        if (index == LBNumRegistros.Items.Count)
                        {
                            //marcamos el nuevo ultimo
                            LBNumRegistros.SetSelected(index - 1, true);
                        }
                        else
                        {
                            LBNumRegistros.SetSelected(index, true);
                        }
                    }
                    else
                    {
                        this.mostrarMensaje("La base de datos no contiene ningún libro");
                        btnBorrar.Enabled = false;
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

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
