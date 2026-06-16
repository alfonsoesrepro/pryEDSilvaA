using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA.Clases
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo ant = Raiz;
                clsNodo aux = Raiz;

                while (aux != null)
                {
                    ant = aux;
                    if (nvo.Codigo < aux.Codigo)  
                        aux = aux.Izquierdo; 
                    else  
                        aux = aux.Derecho; 
                }

                if (nvo.Codigo < ant.Codigo) 
                    ant.Izquierdo = nvo; 
                else  
                    ant.Derecho = nvo; 
            }
        }

        // Recorrer Grilla
        public void Recorrer(DataGridView dgv, string opt)
        {
            dgv.Rows.Clear();
            
            switch (opt)
            {
                case "InOrden":
                    InOrdenAsc(dgv, Raiz);
                    break;
                case "PreOrden":
                    PreOrden(dgv, Raiz);
                    break;
                case "PostOrden":
                    PostOrden(dgv, Raiz);
                    break;
                default:
                    MessageBox.Show("Opción de recorrido no válida.");
                    break;
            }
        }

        public void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R == null) return;
            InOrdenAsc(dgv, R.Izquierdo);
            
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            
            InOrdenAsc(dgv, R.Derecho);
        }

        public void PreOrden(DataGridView dgv, clsNodo R)
        {
            if (R == null) return;
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            PreOrden(dgv, R.Izquierdo);
            PreOrden(dgv, R.Derecho);
        }

        public void PostOrden(DataGridView dgv, clsNodo R)
        {
            if (R == null) return;
            PostOrden(dgv, R.Izquierdo);
            PostOrden(dgv, R.Derecho);

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        // Recorrer ComboBox
        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenAsc(cmb, Raiz);
        }

        public void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(cmb, R.Izquierdo);
            }

            cmb.Items.Add(R.Codigo + " - " + R.Nombre + " - " + R.Tramite);

            if (R.Derecho != null)
            {
                InOrdenAsc(cmb, R.Derecho);
            }
        }

        // Recorrer el árbol y llena la lista (vector)
        public void Recorrer(List<clsNodo> lista)
        {
            if (lista == null) throw new ArgumentNullException(nameof(lista));
            lista.Clear();
            InOrdenAsc(lista, Raiz);
        }

        public void InOrdenAsc(List<clsNodo> lista, clsNodo R)
        {
            if (R == null) return;

            if (R.Izquierdo != null)
            {
                InOrdenAsc(lista, R.Izquierdo);
            }

            lista.Add(R);

            if (R.Derecho != null)
            {
                InOrdenAsc(lista, R.Derecho);
            }
        }

        // Recorrer TreeView
        public void Recorrer(TreeView tv)
        {
            tv.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tv.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tv.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);

            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, nodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, nodoPadre);
            }
        }

        // Equilibrar el árbol
        public void Equilibrar()
        {
            int total = ContarNodos(Raiz);
            if (total == 0) return;

            clsNodo[] arr = new clsNodo[total];
            int i = 0;
            RecolectarInOrden(Raiz, arr, ref i);

            Raiz = null;
            Raiz = ConstruirEquilibrado(arr, 0, total - 1);
        }

        private int ContarNodos(clsNodo actual)
        {
            if (actual == null) return 0;
            return 1 + ContarNodos(actual.Izquierdo) + ContarNodos(actual.Derecho);
        }

        private void RecolectarInOrden(clsNodo actual, clsNodo[] arr, ref int i)
        {
            if (actual == null) return;
            RecolectarInOrden(actual.Izquierdo, arr, ref i);
            arr[i++] = actual;
            RecolectarInOrden(actual.Derecho, arr, ref i);
        }

        private clsNodo ConstruirEquilibrado(clsNodo[] arr, int inicio, int fin)
        {
            if (inicio > fin) return null;

            int medio = (inicio + fin) / 2;
            clsNodo nodo = arr[medio];

            nodo.Izquierdo = null;
            nodo.Derecho = null;

            nodo.Izquierdo = ConstruirEquilibrado(arr, inicio, medio - 1);
            nodo.Derecho = ConstruirEquilibrado(arr, medio + 1, fin);

            return nodo;
        }

        // Eliminar un nodo
        public bool Eliminar(int codigo)
        {
            bool eliminado = false;
            Raiz = EliminarRecursivo(Raiz, codigo, ref eliminado);
            return eliminado;
        }

        private clsNodo EliminarRecursivo(clsNodo actual, int codigo, ref bool eliminado)
        {
            if (actual == null) return null;

            if (codigo < actual.Codigo)
            {
                actual.Izquierdo = EliminarRecursivo(actual.Izquierdo, codigo, ref eliminado);
            }
            else if (codigo > actual.Codigo)
            {
                actual.Derecho = EliminarRecursivo(actual.Derecho, codigo, ref eliminado);
            }
            else
            {
                // Nodo encontrado
                eliminado = true;

                // Caso 1: Nodo hoja
                if (actual.Izquierdo == null && actual.Derecho == null)
                    return null;

                // Caso 2a: Solo hijo derecho
                if (actual.Izquierdo == null)
                    return actual.Derecho;

                // Caso 2b: Solo hijo izquierdo
                if (actual.Derecho == null)
                    return actual.Izquierdo;
                
                // Caso 3: Dos hijos → buscar sucesor in-orden (mínimo del subárbol derecho)
                clsNodo sucesor = ObtenerMinimo(actual.Derecho);

                // Copiar datos del sucesor al nodo actual
                actual.Codigo = sucesor.Codigo;
                actual.Nombre = sucesor.Nombre;
                actual.Tramite = sucesor.Tramite;

                // Eliminar el sucesor del subárbol derecho
                actual.Derecho = EliminarRecursivo(actual.Derecho, sucesor.Codigo, ref eliminado);
                eliminado = true;
            }

            return actual;
        }

        private clsNodo ObtenerMinimo(clsNodo actual)
        {
            while (actual.Izquierdo != null)
                actual = actual.Izquierdo;
            return actual;
        }
    }
}