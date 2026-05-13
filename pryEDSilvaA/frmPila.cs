using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila pila = new clsPila();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text) &&
                !String.IsNullOrWhiteSpace(txtNombre.Text) &&
                !String.IsNullOrWhiteSpace(txtTramite.Text))
            {
                clsNodo nuevo = new clsNodo();

                nuevo.Nombre = txtNombre.Text;
                nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
                nuevo.Tramite = txtTramite.Text;

                pila.Agregar(nuevo);
                pila.Recorrer(dgvPila);
                pila.Recorrer(lbPila);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
                txtCodigo.Focus();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                MessageBox.Show("Se ha sacado a: " + pila.Primero.Nombre);
                lblRCodigo.Text = pila.Primero.Codigo.ToString();
                lblRNombre.Text = pila.Primero.Nombre;
                lblRTramite.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lbPila);
                pila.Recorrer();
            }
            else
            {
                lblRCodigo.Text = "";
                lblRNombre.Text = "";
                lblRTramite.Text = "";
            }
        }
    }
}