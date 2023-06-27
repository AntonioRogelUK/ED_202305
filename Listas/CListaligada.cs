using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Listas
{
    class CListaligada
    {

        private CNodo ancla;

        private CNodo trabajo;

        private CNodo trabajo2;

        public CListaligada()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }
        
        //recorelista
        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo=trabajo.Siguiente;
                int d = trabajo.Dato;

                Console.Write("{0}, ", d);

            }
            //bajar linea
            Console.WriteLine();
        }
        //Adicion nuevo elemento

        public void Adicionar (int pDato)
        {

            trabajo=ancla;

            //recorre lista hasta el final
            while (trabajo.Siguiente !=null)
            {
                //avanzar trabajo
                trabajo = trabajo.Siguiente;
            }
            //nuevo nodo
            CNodo temp = new CNodo();

            //insertamos dato
            temp.Dato = pDato;

            //finalizamos
            temp.Siguiente = null;

            //ligar ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }
        

    }
}
