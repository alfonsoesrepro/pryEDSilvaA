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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text) &&
                !String.IsNullOrWhiteSpace(txtAlumnos.Text) &&
                !String.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                clsArchivoTexto x = new clsArchivoTexto();
                x.NombreArchivo = "Alumnos.csv";
                x.Grabar(txtCodigo.Text, txtAlumnos.Text, txtCarrera.Text);
                x.Recorrer(dgvAlumnos);

                txtCodigo.Clear();
                txtAlumnos.Clear();
                txtCarrera.Clear();
                txtCodigo.Focus();

                MessageBox.Show("Alumno/a grabado correctamente");
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
                txtCodigo.Focus();
            }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Alumnos.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvAlumnos);
        }
    }
}