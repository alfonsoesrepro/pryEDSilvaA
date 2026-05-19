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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Colores.txt";
            x.Grabar(txtColores.Text);
            x.Recorrer(lstColores);
            txtColores.Clear();
            txtColores.Focus();

            MessageBox.Show("Color grabado correctamente");
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            cmdGrabar.Enabled = false;
        }

        private void txtColores_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        public void validarDatos()
        {
            if (txtColores.Text == "")
            {
                cmdGrabar.Enabled = false;
            }
            else
            {
                cmdGrabar.Enabled = true;
            }
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Colores.txt";
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(lstColores);
            }
            else
            {
                MessageBox.Show("No se han registrado colores aún");
            }
        }
    }
}