using pryEDSilvaA.BD;
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
    public partial class frmConsultaSQL : Form
    {
        public frmConsultaSQL()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(dgvTabla, txtConsultaSQL.Text);
        }
    }
}