using System.Threading.Channels;
using System;
try
{

    Console.WriteLine("EJERCICIO PILAS");
    Console.WriteLine("------------");
    Console.Write("Introduce cantidad de elementos para la pila:  ");
    int elementosPila = Convert.ToInt32(Console.ReadLine());
    new Listas.Pilas(elementosPila);


    Console.WriteLine("");
    Console.WriteLine("EJERCICIO COLAS");
    Console.WriteLine("------------");
    Console.Write("Introduce cantidad de elementos para la cola:  ");
    int elementosCola = Convert.ToInt32(Console.ReadLine());
    new Listas.Colas(elementosCola);


}
catch (Exception ex)
{

    Console.WriteLine($"Ocurrió un error:{ex.Message}");


}


