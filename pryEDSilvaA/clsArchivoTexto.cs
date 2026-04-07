using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public void Recorrer()
        {

        }
    }
}