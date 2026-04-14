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
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador x = new frmDatosDesarrollador();
            x.ShowDialog();
        }

        private void coloresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmColores x = new frmColores();
            x.ShowDialog();
        }

        private void mesesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMeses x = new frmMeses();
            x.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();
            x.ShowDialog();
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
            //...
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos x = new frmAlumnos();
            x.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras x = new frmCarreras();
            x.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.ShowDialog();
        }
    }
}