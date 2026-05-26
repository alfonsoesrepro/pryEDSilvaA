using pryEDSilvaA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA.Formularios
{
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }

        clsGrafo grafo = new clsGrafo();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigenCarga);
            grafo.MostrarCiudades(cmbOrigenConsulta);
            grafo.MostrarCiudades(cmbOrigenListado);
            grafo.MostrarCiudades(cmbDestinoCarga);
            grafo.MostrarCiudades(cmbDestinoConsulta);
            grafo.MostrarCiudades(cmbDestinoListado);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenCarga.SelectedIndex;
            Int32 c = cmbDestinoCarga.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecioCarga.Text);

            grafo.Agregar(f, c, p);
            grafo.MostrarTodo(dgvGrafo);
            gbListado.Text = "Listado completo de viajes";
            txtPrecioCarga.Clear();
        }
    }
}