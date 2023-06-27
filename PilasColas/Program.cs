
try
{
    Listas.Pilas lista = new Listas.Pilas();

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


    //Listas.Colas lista = new Listas.Colas();

    //lista.Agregar("A");
    //lista.Agregar("B");
    //lista.Agregar("C");
    //lista.Agregar("D");
    //string contenido = lista.Imprimir();
    //Console.WriteLine(contenido);
    //Console.WriteLine(new string('-', 10));
    //lista.Eliminar();
    //Console.WriteLine(lista.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //lista.Eliminar();
    //Console.WriteLine(lista.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //lista.Eliminar();
    //Console.WriteLine(lista.Imprimir());
    //Console.WriteLine(new string('-', 10));
    //lista.Eliminar();
    //Console.WriteLine(lista.Imprimir());

}
catch (Exception ex)
{

    Console.WriteLine($"Ocurrió un error:{ex.Message}");


}

