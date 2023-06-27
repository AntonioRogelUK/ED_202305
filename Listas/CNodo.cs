using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class CNodo
    {
        private int dato;

        private CNodo siguiente = null;

        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        //imprimir
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
