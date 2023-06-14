using System.Threading.Channels;

try
{
    //Arreglos.Pilas pila = new Arreglos.Pilas(5);
    //pila.Agregar("Edgar");
    //pila.Agregar("Amaya");
    //pila.Agregar("Allison");

    //string contenido = pila.Imprimir();
    //Console.WriteLine(contenido);
    //Console.WriteLine( "------------" );
    //pila.Eliminar();

    //contenido = pila.Imprimir();
    //Console.WriteLine(contenido);
    //Console.WriteLine("------------");
    //pila.Agregar("Pedro");
    //contenido = pila.Imprimir();
    //Console.WriteLine(contenido);

    Arreglos.Colas colas = new Arreglos.Colas(10);
    colas.Agregar("A");
    colas.Agregar("B");
    colas.Agregar("C");
    colas.Agregar("D");
    string contenido = colas.Imprimir();
    Console.WriteLine(contenido);
    Console.WriteLine(new string('-',10));
    colas.Eliminar();
    Console.WriteLine(colas.Imprimir());
    Console.WriteLine(new string('-', 10));
    colas.Eliminar();
    Console.WriteLine(colas.Imprimir());
    Console.WriteLine(new string('-', 10));
    colas.Eliminar();
    Console.WriteLine(colas.Imprimir());
    Console.WriteLine(new string('-', 10));
    colas.Eliminar();
    Console.WriteLine(colas.Imprimir());

}
catch (Exception ex) 
{

    Console.WriteLine($"Ocurrió un error:{ex.Message}"); 


}

