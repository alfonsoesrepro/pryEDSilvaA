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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Carreras.txt";
            x.Grabar(txtCarreras.Text);
            x.Recorrer(lstCarreras);
            txtCarreras.Clear();
            txtCarreras.Focus();

            MessageBox.Show("Carrera grabada correctamente");
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            cmdGrabar.Enabled = false;
        }

        private void txtCarreras_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        public void validarDatos()
        {
            if (txtCarreras.Text == "")
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
            x.NombreArchivo = "Carreras.txt";
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(lstCarreras);
            }
            else
            {
                MessageBox.Show("No se han registrado carreras aún");
            }
        }
    }
}