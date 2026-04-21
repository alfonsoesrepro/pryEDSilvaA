using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA
{
    internal class clsCola
    {
        //Campos
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades
        public clsNodo Primero { get => pri; set => pri = value; }
        public clsNodo Ultimo { get => ult; set => ult = value; }

        /*
        public clsNodo Primero
        {
            get {return pri;}
            set {pri = value;}
        }

        public clsNodo Ultimo
        {
            get {return ult;}
            set {ult = value;}
        }
        */

        public clsNodo Agregar(clsNodo nuevoElemento)
        {
            if (Primero == null)
            {
                Primero = nuevoElemento;
                Ultimo = nuevoElemento;
            }
            else
            {
                Ultimo.Siguiente = nuevoElemento;
                Ultimo = nuevoElemento;
            }
            return nuevoElemento;
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }


        /*
        public clsNodo Eliminar()
        {
            if (Primero != Ultimo)
            {
                clsNodo nodoEliminado = Primero;
                Primero = Primero.Siguiente;
                nodoEliminado.Siguiente = null; // Desconectar el nodo eliminado
                return nodoEliminado;
            }
            else
            {
                return null;
            }
        }
          
        */


        public void Recorrer(DataGridView dgv)
        {
            clsNodo Aux = Primero;
            dgv.Rows.Clear();
            while (Aux != null)
            {
                dgv.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lb)
        {
            clsNodo Aux = Primero;
            lb.Items.Clear();
            while (Aux != null)
            {
                lb.Items.Add($"Código: {Aux.Codigo}, Nombre: {Aux.Nombre}, Trámite: {Aux.Tramite}");
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox cb )
        {
            clsNodo Aux = Primero;
            cb.Items.Clear();
            while (Aux != null)
            {
                cb.Items.Add($"Código: {Aux.Codigo}, Nombre: {Aux.Nombre}, Trámite: {Aux.Tramite}");
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer() {
        
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (Aux != null)
            {
                AD.Write(Aux.Codigo);
                AD.Write(";");
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite);
                Aux = Aux.Siguiente;
            }
            AD.Close();
        }
    }
}