using pryEDSilvaA.Clases;
using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario arbol = new clsArbolBinario();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            cmbCodigo.Items.Add(nuevo.Codigo);
            nuevo.Tramite = txtTramite.Text;

            arbol.Agregar(nuevo);
            arbol.Recorrer(dgvArbolBinario);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }
    }
}