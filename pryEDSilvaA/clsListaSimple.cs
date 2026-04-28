using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                if (nuevo.Codigo <= Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;

                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }

                        nuevo.Siguiente = aux;
                        ant.Siguiente = nuevo;
                    }
                }
            }
        }

        public void Eliminar(Int32 codigo)
        {
            if (Primero.Codigo == codigo)
            {
                Primero = Primero.Siguiente;
            }
            else 
            {
                clsNodo aux = Primero;
                clsNodo ant= Primero;

                while (aux.Codigo != codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
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