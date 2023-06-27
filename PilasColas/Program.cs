
try
{


    //Arreglos.Colas colas = new Arreglos.Colas(10);
    //colas.Agregar("A");
    //colas.Agregar("B");
    //colas.Agregar("C");
    //colas.Agregar("D");
    //string contenido = colas.Imprimir();
    //Console.WriteLine(contenido);
    //Console.WriteLine(new string('-', 10));
    //colas.Eliminar();
    //Console.WriteLine(colas.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //colas.Eliminar();
    //Console.WriteLine(colas.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //colas.Eliminar();
    //Console.WriteLine(colas.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //colas.Eliminar();
    //Console.WriteLine(colas.Imprimir());

    Listas.Colas lista = new Listas.Colas();

    lista.Agregar("A");
    lista.Agregar("B");
    lista.Agregar("C");
    lista.Agregar("D");
    string contenido = lista.Imprimir();
    Console.WriteLine(contenido);
    Console.WriteLine(new string('-', 10));
    lista.Eliminar();
    Console.WriteLine(lista.Imprimir());
    Console.WriteLine(new string('-', 10));
    lista.Eliminar();
    Console.WriteLine(lista.Imprimir());
    Console.WriteLine(new string('-', 10));
    lista.Eliminar();
    Console.WriteLine(lista.Imprimir());
    Console.WriteLine(new string('-', 10));
    lista.Eliminar();
    Console.WriteLine(lista.Imprimir());

}
catch (Exception ex)
{

    Console.WriteLine($"Ocurrió un error:{ex.Message}");


}

