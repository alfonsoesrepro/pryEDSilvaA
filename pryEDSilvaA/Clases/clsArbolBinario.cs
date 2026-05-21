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
                    if (nvo.Codigo < aux.Codigo) { aux = aux.Izquierdo; }
                    else { aux = aux.Derecho; }
                }

                if (nvo.Codigo < ant.Codigo) { ant.Izquierdo = nvo; }
                else { ant.Derecho = nvo; }
            }
        }

        public void Recorrer(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenAsc(dgv, Raiz);
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