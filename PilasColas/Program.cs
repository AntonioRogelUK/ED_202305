try
{
    Arreglos.Pilas pila = new Arreglos.Pilas(5);
    pila.Agregar("Edgar");
    pila.Agregar("Amaya");
    pila.Agregar("Allison");
    
    string contenido = pila.Imprimir();
    Console.WriteLine(contenido);
    Console.WriteLine( "------------" );
    pila.Eliminar();

    contenido = pila.Imprimir();
    Console.WriteLine(contenido);
    Console.WriteLine("------------");
    pila.Agregar("Pedro");
    contenido = pila.Imprimir();
    Console.WriteLine(contenido);


}
catch (Exception ex) 
{

    Console.WriteLine($"Ocurrió un error:{ex.Message}"); 
}

