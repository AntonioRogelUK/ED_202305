using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arreglos;
using Listas;

namespace Listas
{

    public class Pilas
    {
        public int elementos;
        Arreglos.Pilas pila;

        public Pilas(int elementos)
        {
            this.elementos = elementos;
            this.pila = new Arreglos.Pilas(elementos);

            for (int i = 0; i < elementos; i++)
            {

                Console.Write("Introduce elemento [" + (i + 1).ToString() + "] de la pila:  ");
                string texto = Console.ReadLine();
                if (texto == "") texto = "vacío";
                this.Push(texto);

            }

            Console.WriteLine("Imprimiento valores de la pila: ");
            Console.WriteLine(this.Show());
            Console.WriteLine("------------");


            for (int i = 0; i < elementos; i++)
            {
                this.Pop();
            }

        }
        public void Push(string valor)
        {

            this.pila.Agregar(valor);

        }

        public void Pop()
        {

            Console.Write("Presiona una tecla para eliminar un elemento de la pila: ");
            Console.ReadLine();
            this.pila.Eliminar();
            Console.WriteLine(this.Show());
        }
        public string Show()
        {
            return this.pila.Imprimir();

        }
    }
}
