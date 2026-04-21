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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola fila = new clsCola();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Tramite = txtTramite.Text;

            fila.Agregar(nuevo);
            fila.Recorrer(dgvCola);
            fila.Recorrer(lbCola);
            
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                MessageBox.Show("Se ha atendido a: " + fila.Primero.Nombre);
                lblRCodigo.Text = fila.Primero.Codigo.ToString();
                lblRNombre.Text = fila.Primero.Nombre;
                lblRTramite.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lbCola);
                fila.Recorrer();
            }
            else {
                lblRCodigo.Text = "";
                lblRNombre.Text = "";
                lblRTramite.Text = "";
            }
        }
    }
}