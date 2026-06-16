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
            nuevo.Tramite = txtTramite.Text;

            arbol.Agregar(nuevo);
            arbol.Recorrer(dgvArbolBinario, "InOrden");
            arbol.Recorrer(twArbolBinario);
            CargarComboBox();

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            optInOrden.Checked = true;
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "InOrden");
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PreOrden");
            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PostOrden");
            }
        }

        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                MessageBox.Show("El arbol está vacío.", "Advertencia", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            arbol.Equilibrar();
            arbol.Recorrer(twArbolBinario);

            if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
            else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
            else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

            MessageBox.Show("Árbol equilibrado exitosamente!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un código válido para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCodigo.Text = "";
                return;
            }

            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el nodo con código {codigo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            bool eliminado = arbol.Eliminar(codigo);

            if (eliminado)
            {
                arbol.Recorrer(twArbolBinario);
                CargarComboBox();

                if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
                else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
                else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

                MessageBox.Show($"Nodo {codigo} eliminado exitosamente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCodigo.Text = "";
            }
            else
            {
                MessageBox.Show($"No se encontró el nodo {codigo}.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarComboBox()
        {
            cmbCodigo.Items.Clear();
            CargarCodigos(arbol.Raiz);
        }

        private void CargarCodigos(clsNodo nodo)
        {
            if (nodo == null) return;
            CargarCodigos(nodo.Izquierdo);
            cmbCodigo.Items.Add(nodo.Codigo);
            CargarCodigos(nodo.Derecho);
        }
    }
}