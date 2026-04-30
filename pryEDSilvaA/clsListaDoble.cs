using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            if (pri.Codigo == null)
            {
                pri = nvo;
                ult = nvo;
            }
            else
            {
                if (nvo.Codigo <= pri.Codigo)
                {
                    nvo.Siguiente = pri;
                    pri.Anterior = nvo;
                    pri = nvo;

                }
                else if (nvo.Codigo >= ult.Codigo)
                {
                    ult.Siguiente = nvo;
                    nvo.Anterior = ult;
                    ult = nvo;
                }
                else
                {
                    clsNodo aux = pri;
                    clsNodo ant = pri;

                    // Recorrido con los dos "índices"
                    while (aux.Codigo < nvo.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }

                    aux.Siguiente = nvo;
                    nvo.Anterior = ant;
                    nvo.Siguiente = aux;
                    aux.Anterior = nvo;
                }
            }
        }

        public void Eliminar()
        { 
            
        }

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

        public void Recorrer(ComboBox cb)
        {
            clsNodo Aux = Primero;
            cb.Items.Clear();
            while (Aux != null)
            {
                cb.Items.Add($"Código: {Aux.Codigo}, Nombre: {Aux.Nombre}, Trámite: {Aux.Tramite}");
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer()
        {

            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter("Pila.csv", false, Encoding.UTF8);
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