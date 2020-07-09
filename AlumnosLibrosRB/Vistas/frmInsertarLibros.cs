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
    public partial class frmInsertarLibros : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        BindingList<Libro> BLLibros;
        Button btnBorrar;

        public frmInsertarLibros(BindingList<Libro> BLLibros, Button btnBorrar)
        {
            InitializeComponent();

            this.BLLibros = BLLibros;
            this.btnBorrar = btnBorrar;
        }

        private void frmInsertarLibros_Load(object sender, EventArgs e)
        {
            DTPFechaCompra.Value = DateTime.Today;
            CBEstado.SelectedIndex = 0;

            this.GenerarNumRegistro();
        }

        public void GenerarNumRegistro()
        {
            try
            {
                txbNumRegistro.Text = (BLLibros.Select(x => x.NumRegistro).Max() + 1).ToString();
            }
            catch (Exception)
            {
                //si la lista esta vacia peta, no hacemos nada
            }
        }

        private void txbISBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //se podria usar FirstOrDefault() y comparar que libro no sea null, es decir, si se encontro o no, pero usar try catch mola mas
                Libro libro = BLLibros.Where(x => x.ISBN.ToLower() == txbISBN.Text.ToLower()).First();

                txbTitulo.Text = libro.Titulo;
                txbObservaciones.Text = libro.Observaciones;
                txbVolumenes.Text = libro.Volumenes.ToString();
                DTPFechaCompra.Value = libro.FechaCompra;
            }
            catch (Exception)
            {
                //error que se produce al no encontrarse ningun libro en la lista con ese ISBN, no hacemos nada
            }

        }

        private void CheckValor(object sender, KeyPressEventArgs e)
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

            DTPFechaCompra.Value = DateTime.Today;
            CBEstado.SelectedIndex = 0;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.comprobarDatos())
            {
                Libro libro = this.crearLibro();

                if (!this.comprobarRepetido())
                {
                    try
                    {
                        daoBaseDatos.AbrirConexion();

                        daoBaseDatos.InsertarLibro(libro);

                        BLLibros.Add(libro);

                        this.mostrarMensaje("Se ha insertado correctamente el libro en la base de datos");

                        btnResetear.PerformClick();

                        this.GenerarNumRegistro();

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
                else
                {
                    this.mostrarMensaje("El libro ya existe. Cierre esta ventana y selecciónelo en la lista para editarlo");
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

            foreach (Libro libro in BLLibros)
            {
                if (libro.NumRegistro == Convert.ToInt32(txbNumRegistro.Text))
                {
                    repetido = true;
                    break;
                }
            }

            return repetido;
        }

        private Libro crearLibro()
        {
            Libro libro = new Libro();

            try
            {
                libro.NumRegistro = Convert.ToInt32(txbNumRegistro.Text);
                libro.ISBN = txbISBN.Text;
                libro.Titulo = txbTitulo.Text;
                libro.Volumenes = Convert.ToInt32(txbVolumenes.Text);
                libro.FechaCompra = DTPFechaCompra.Value;
                libro.Observaciones = txbObservaciones.Text;
                libro.Estado = CBEstado.Text;
            }
            catch (Exception e)
            {
                this.mostrarMensaje(e.Message);
            }

            return libro;
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
