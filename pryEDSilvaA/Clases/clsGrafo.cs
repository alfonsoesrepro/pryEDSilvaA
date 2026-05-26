using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA.Clases
{
    internal class clsGrafo
    {
        // Vector Ciudades
        private String[] Ciudades = new String[] {"Córdoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta"};
        // Matriz Precio
        private Decimal[,] Precio = new Decimal[5, 5];

        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }

        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }

        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }

        public void MostrarDestinos(Int32 f, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("Col1", "Destino");
            dgv.Columns.Add("Col2", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;
            dgv.Rows.Clear();

            for (Int32 c = 0; c < 5; c++) 
            {
                if (Precio[f, c] > 0)
                {
                    dgv.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }

        public void MostrarOrigenes(Int32 c, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("Col1", "Origen");
            dgv.Columns.Add("Col2", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;

            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    dgv.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }

        public void MostrarTodo(DataGridView dgv) 
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("NomOrigen", "Origen");

            for (Int32 i = 0; i < 5; i++) 
            {
                dgv.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f < 5; f++) 
            {
                dgv.Rows.Add(Ciudades[f]);

                for (Int32 c = 0; c < 5; c++) 
                {
                    dgv.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            
            for (Int32 i = 0; i < 5; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}