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

namespace AlumnosLibrosRB.Vistas
{
    public partial class frmEliminarPrestamos : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        String anyo;

        public frmEliminarPrestamos(String anyo)
        {
            InitializeComponent();

            this.anyo = anyo;
        }

        private void CheckValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.comprobarDatos())
            {
                if (MessageBox.Show("Está seguro que quiere borrar el préstamo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        daoBaseDatos.AbrirConexion();

                        daoBaseDatos.EliminarPrestamo(txbIDAlumno.Text, txbNumRegistro.Text, anyo);

                        this.mostrarMensaje("Se ha eliminado el préstamo correctamente");

                        txbIDAlumno.Clear();
                        txbNumRegistro.Clear();
                        txbIDAlumno.Focus();
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
                this.mostrarMensaje("Los campos no están rellenados");
            }
        }

        private bool comprobarDatos()
        {
            return txbIDAlumno.Text != "" && txbNumRegistro.Text != "";
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
