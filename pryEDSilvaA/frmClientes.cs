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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text) && 
                !String.IsNullOrWhiteSpace(txtClientes.Text) &&
                !String.IsNullOrWhiteSpace(txtDeuda.Text))
            {
                clsArchivoTexto x = new clsArchivoTexto();
                x.NombreArchivo = "Clientes.csv";
                x.Grabar(txtCodigo.Text, txtClientes.Text, txtDeuda.Text);
                x.Recorrer(dgvClientes);
            
                txtCodigo.Clear();
                txtClientes.Clear();
                txtDeuda.Clear();
                txtCodigo.Focus();

                MessageBox.Show("Cliente grabado correctamente");
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
                txtCodigo.Focus();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Clientes.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvClientes);
        }

        //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    }
}