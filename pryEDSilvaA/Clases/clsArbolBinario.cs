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
            if (R.Izquierdo != null)
            {
                InOrdenAsc(dgv, R.Izquierdo);
            }
            
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            
            if (R.Derecho != null)
            {
                InOrdenAsc(dgv, R.Derecho);
            }
        }

        public void PreOrden(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null)
            {
                PreOrden(dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(dgv, R.Derecho);
            }
        }

        public void PostOrden(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(dgv, R.Derecho);
            }

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
    }
}