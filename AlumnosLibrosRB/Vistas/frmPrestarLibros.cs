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
    public partial class frmPrestarLibros : Form
    {
        DAOBaseDatos daoBaseDatos = new DAOBaseDatos();
        String anyo;

        public frmPrestarLibros(String anyo)
        {
            InitializeComponent();

            this.anyo = anyo;
        }

        private void CheckValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnPrestar.PerformClick();
                }
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (this.comprobarDatos())
            {
                try
                {
                    daoBaseDatos.AbrirConexion();

                    daoBaseDatos.RealizarPrestamo(txbIDAlumno.Text, txbNumRegistro.Text, anyo);

                    this.mostrarMensaje("Se ha prestado el libro correctamente");

                    txbIDAlumno.Clear();
                    txbNumRegistro.Clear();
                    txbIDAlumno.Focus();
                }
                catch (Exception error)
                {
                    //como mysql no tiene try catch si esta duplicado el insert aqui llega un excepcion "no creada", la tratamos a partir del mensaje generico
                    //aqui tambien llega si el alumno o libro no existe
                    if (error.Message == "Referencia a objeto no establecida como instancia de un objeto.")
                    {
                        this.mostrarMensaje("Se ha producido un error realizando el préstamo.\nCompruebe que tanto el ID del alumno y el número de referencia existen o que el libro no haya sido prestado a un alumno ya para el año " + anyo);
                    }
                    else
                    {
                        this.mostrarMensaje(error.Message);
                    }
                }
                finally
                {
                    daoBaseDatos.CerrarConexion();
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
