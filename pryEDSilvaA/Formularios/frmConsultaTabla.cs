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
    public partial class frmConsultaTabla : Form
    {
        public frmConsultaTabla()
        {
            InitializeComponent();
            this.Load += frmConsultaTabla_Load;
        }

        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {
            // Asegura que el combo esté vacío antes de cargar
            cmbTabla.Items.Clear();

            // Carga las tablas requeridas
            cmbTabla.Items.AddRange(new object[] { "Autor", "Idioma", "Libro", "Pais" });

            // Selecciona el primer elemento si existe
            if (cmbTabla.Items.Count > 0)
            {
                cmbTabla.SelectedIndex = 0;
            }
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(cmbTabla.Text, dgvTabla);
        }
    }
}
