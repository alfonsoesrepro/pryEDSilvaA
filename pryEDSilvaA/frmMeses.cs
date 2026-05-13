using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDSilvaA
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.txt";
            x.Grabar(txtMeses.Text);
            x.Recorrer(lstMeses);
            txtMeses.Clear();
            txtMeses.Focus();

            MessageBox.Show("Mes grabado correctamente", "Aviso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void validarDatos()
        {
            if (txtMeses.Text == "")
            {
                cmdGrabar.Enabled = false;
            }
            else 
            {
                cmdGrabar.Enabled = true;
            }
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            cmdGrabar.Enabled = false;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Meses.txt";
            
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(lstMeses);
            }
            else
            {
                MessageBox.Show("No se han registrado meses aún");
            }
        }
    }
}