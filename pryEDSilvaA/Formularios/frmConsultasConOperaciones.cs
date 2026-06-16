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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEDSilvaA.Formularios
{
    public partial class frmConsultasConOperaciones : Form
    {
        private clsBaseDatos bd = new clsBaseDatos();
        private string[] consultas;

        public frmConsultasConOperaciones()
        {
            InitializeComponent();

            consultas = new string[]
            {
                "SELECT * FROM Autor",
                "SELECT * FROM Idioma",
                "SELECT * FROM Libro",
                "SELECT * FROM Pais",
                "SELECT Titulo, Precio FROM Libro WHERE Precio > 100",
                "SELECT L.Titulo, A.Nombre FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor",
                "SELECT COUNT(*) FROM Libro",
                "SELECT Nombre, COUNT(*) FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor GROUP BY A.Nombre"
            };

            string[] nombres = new string[]
            {
                "Todos los autores",
                "Todos los idiomas",
                "Todos los libros",
                "Todos los países",
                "Libros caros (>100)",
                "Libros con autor",
                "Cantidad de libros",
                "Libros por autor"
            };

            cmbOperacion.Items.Clear();
            
            for (int i = 0; i < nombres.Length; i++)
                cmbOperacion.Items.Add(nombres[i]);

            cmdListar.Click += (s, e) =>
            {
                if (cmbOperacion.SelectedIndex < 0)
                {
                    lblConsultaSQL.Text = "Seleccione una consulta.";
                    return;
                }
                lblConsultaSQL.Text = consultas[cmbOperacion.SelectedIndex];
                bd.Listar(dgvTabla, consultas[cmbOperacion.SelectedIndex]);
            };
        }
    }
}