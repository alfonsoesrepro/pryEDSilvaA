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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble lista = new clsListaDoble();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            cmbCodigo.Items.Add(nuevo.Codigo);
            nuevo.Tramite = txtTramite.Text;

            lista.Agregar(nuevo);
            lista.Recorrer(dgvListaDoble);
            lista.Recorrer(lbListaDoble);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.Text);
                lista.Eliminar(codigo);
                lista.Recorrer(dgvListaDoble);
                lista.Recorrer(lbListaDoble);
                lista.Recorrer();

                cmbCodigo.Items.Remove(codigo);
                cmbCodigo.Focus();
                cmdEliminar.Enabled = false;
            }
            else
            {
                cmbCodigo.Items.Clear();
                txtCodigo.Focus();
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

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            cmdAgregar.Enabled = false;
            cmdEliminar.Enabled = false;
            optAscendente.Checked = true;
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optDescendente.Checked)
            {
                lista.RecorrerDes(dgvListaDoble);
                lista.RecorrerDes(lbListaDoble);
            }
            else
            {
                lista.Recorrer(dgvListaDoble);
                lista.Recorrer(lbListaDoble);
            }
        }
    }
}