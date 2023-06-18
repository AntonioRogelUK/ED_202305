using Arreglos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas;

namespace Listas
{
    public class Colas
    {
        public int elementos;
        Arreglos.Colas cola;

        public Colas(int elementos)
        {
            this.elementos = elementos;
            this.cola = new Arreglos.Colas(elementos);

            for (int i = 0; i < elementos; i++)
            {

                Console.Write("Introduce elemento [" + (i + 1).ToString() + "] de la cola:  ");
                string texto = Console.ReadLine();
                if (texto == "") texto = "vacío";
                this.Push(texto);

            }

            Console.WriteLine("Imprimiento valores de la cola: ");
            Console.WriteLine(this.Show());
            Console.WriteLine("------------");


            for (int i = 0; i < elementos; i++)
            {
                this.Pop();
            }

        }
        public void Push(string valor)
        {

            this.cola.Agregar(valor);

        }

        public void Pop()
        {

            Console.Write("Presiona una tecla para eliminar un elemento de la cola: ");
            Console.ReadLine();
            this.cola.Eliminar();
            Console.WriteLine(this.Show());
        }
        public string Show()
        {
            return this.cola.Imprimir();

        }


    }
}
