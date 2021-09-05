using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaSimple
{
    class Lista
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
       public Lista ()
        {
            head = null;
        }

        //Operaciones
        //Agregar 
        public void Agregar (Nodo n)
        {
            //Lista esta vacia 
            if (head ==null)
            {
                head = n;
                return;
            }
            // No esta vacia 
            if (n.Dato< head.Dato)
            {
                //Al inicio
                n.Siguiente = head;
                head = n;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
                h.Siguiente = h.Siguiente;
                h.Siguiente = n;
            
                
            
            
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaEnTexto += h.Dato + "";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
