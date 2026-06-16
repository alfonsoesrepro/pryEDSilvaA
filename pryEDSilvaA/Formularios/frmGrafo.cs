using pryEDSilvaA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvGrafo);
            
            MessageBox.Show("Todos los datos fueron borrados.", "Aviso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigenConsulta.SelectedIndex;
            Int32 destino = cmbDestinoConsulta.SelectedIndex;
            Decimal precio = grafo.Consultar(origen, destino);
            
            if (precio > 0)
                lblPrecioConsulta.Text = "$ " + precio.ToString();
            else
                lblPrecioConsulta.Text = "Sin conexión";
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigenConsulta.SelectedIndex;
            Int32 destino = cmbDestinoConsulta.SelectedIndex;
            
            grafo.Eliminar(origen, destino);
            grafo.MostrarTodo(dgvGrafo);
            lblPrecioConsulta.Text = "Eliminado";
        }

        private void cmdListarDestinos_Click(object sender, EventArgs e)
        {
            grafo.MostrarDestinos(cmbOrigenListado.SelectedIndex, dgvGrafo);
        }

        private void cmdListarOrigenes_Click(object sender, EventArgs e)
        {
            grafo.MostrarOrigenes(cmbDestinoListado.SelectedIndex, dgvGrafo);
        }

        private void cmdVerTodos_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }
    }
}