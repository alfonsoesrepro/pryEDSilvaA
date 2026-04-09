using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEDSilvaA
{
    internal class clsArchivoTexto
    {
        public String NombreArchivo = "Colores.txt";

        public void Grabar()
        { 
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Abrir
            AD.WriteLine("Hello World!"); //Grabar
            AD.Close(); //Cerrar
        }

        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Abrir
            AD.WriteLine(Dato);
            AD.Close(); //Cerrar
        }

        public void Grabar(String Codigo, String Nombre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Abrir
            AD.Write(Codigo);
            AD.Write(";");
            AD.WriteLine(Nombre);
            AD.Close(); //Cerrar
        }

        public void Grabar(String dato_1, String dato_2, String dato_3)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Abrir
            AD.Write(dato_1);
            AD.Write(";");
            AD.Write(dato_2);
            AD.Write(";");
            AD.WriteLine(dato_3);
            AD.Close(); //Cerrar
        }

        public void Recorrer(ListBox lst)
        {
            String dato;
            lst.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo); //Abrir
            dato = AD.ReadLine(); //Leer

            while (dato != null)
            {
                lst.Items.Add(dato);
                dato = AD.ReadLine();
            }

            AD.Close(); //Cerrar
        }

        public void Recorrer(ComboBox cmb)
        {
            String dato;
            cmb.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo); //Abrir
            dato = AD.ReadLine(); //Leer

            while (dato != null)
            {
                cmb.Items.Add(dato);
                dato = AD.ReadLine();
            }

            AD.Close(); //Cerrar
        }

        public void Recorrer(DataGridView dgv)
        {
            String dato;
            dgv.Rows.Clear();
            StreamReader AD = new StreamReader(NombreArchivo); //Abrir
            dato = AD.ReadLine(); //Leer

            while (dato != null)
            {
                dgv.Rows.Add(dato.Split(';'));
                dato = AD.ReadLine();
            }

            AD.Close(); //Cerrar
        }
    }
}