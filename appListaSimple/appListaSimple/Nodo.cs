using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaSimple
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public Nodo Siguiente 
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo ()
        {
            dato = 0;
            siguiente = null;
        }
        public Nodo(int d, Nodo s)
        {
            dato = d;
            siguiente = s;
        }
        public override string ToString()
        {
            return dato + "";
        }
    }
}
