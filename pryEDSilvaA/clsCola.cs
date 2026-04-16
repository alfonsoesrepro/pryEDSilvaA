using System;
using System.Collections.Generic;
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
            while (Aux != null)
            {
                dgv.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lb)
        {
            clsNodo Aux = Primero;
            while (Aux != null)
            {
                lb.Items.Add($"Código: {Aux.Codigo}, Nombre: {Aux.Nombre}, Trámite: {Aux.Tramite}");
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox cb
            )
        {
            clsNodo Aux = Primero;
            while (Aux != null)
            {
                cb.Items.Add($"Código: {Aux.Codigo}, Nombre: {Aux.Nombre}, Trámite: {Aux.Tramite}");
                Aux = Aux.Siguiente;
            }
        }

        /*public void Recorrer()
        
            clsNodo Aux = Primero;
            while (Aux != null)
            {
                dgv.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }*/
    }
}