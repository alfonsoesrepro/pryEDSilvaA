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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple lista = new clsListaSimple();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            cmbCodigo.Items.Add(nuevo.Codigo);
            nuevo.Tramite = txtTramite.Text;

            lista.Agregar(nuevo);
            lista.Recorrer(dgvListaSimple);
            lista.Recorrer(lbListaSimple);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (lista.Primero != null) 
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.Text);
                lista.Eliminar(codigo);
                lista.Recorrer(dgvListaSimple);
                lista.Recorrer(lbListaSimple);
                lista.Recorrer();
            }
            else
            {
                cmbCodigo.Items.Clear();
            }

        }

        private void validarDatos()
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" 
                || txtTramite.Text == "")
            {
                cmdAgregar.Enabled = false;
            }
            else
            {
                cmdAgregar.Enabled = true;
            }

            if (cmbCodigo.Text == "")
            {
                cmdEliminar.Enabled = false;
            }
            else
            {
                cmdEliminar.Enabled = true;
            }
        }
        
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            cmdAgregar.Enabled = false;
            cmdEliminar.Enabled = false;
        }
    }
}