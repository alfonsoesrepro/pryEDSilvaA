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
            if (pri == null)
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

        public void Eliminar(Int32 cod)
        {
            if (pri.Codigo == cod && ult == pri)
            {
                pri = null;
                ult = null;
            }
            else
            {
                if (pri.Codigo == cod)
                {
                    pri = pri.Siguiente;
                    pri.Anterior = null;
                }
                else
                {
                    if (ult.Codigo == cod)
                    {
                        ult = ult.Anterior;
                        ult.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = pri;
                        clsNodo ant = pri;
                        while (aux.Codigo < cod)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                        ant.Siguiente = aux;
                    }
                }
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
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
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

        public void RecorrerDes(DataGridView dgv)
        {
            clsNodo aux = Ultimo;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox lb)
        {
            clsNodo aux = Ultimo;
            lb.Items.Clear();
            while (aux != null)
            {
                lb.Items.Add($"Código: {aux.Codigo}, Nombre: {aux.Nombre}, Trámite: {aux.Tramite}");
                aux = aux.Anterior;
            }
        }

        public void RecorrerDes(ComboBox cb)
        {
            clsNodo aux = Ultimo;
            cb.Items.Clear();
            while (aux != null)
            {
                cb.Items.Add($"Código: {aux.Codigo}, Nombre: {aux.Nombre}, Trámite: {aux.Tramite}");
                aux = aux.Anterior;
            }
        }

        public void RecorrerDes()
        {
            clsNodo aux = Ultimo;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
    }
}