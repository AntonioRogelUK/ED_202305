using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

public class Colas<T>
{
    private Queue<T> cola;

    public Colas()
    {
        cola = new Queue<T>();
    }

    //Enqueue para agregar elementos a la cola
    public void Enqueue(T elemento)
    {
        cola.Enqueue(elemento);
    }

    //Dequeue para eliminar y devolver el elemento al frente de la cola,
    public T Dequeue()
    {
        if (cola.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }

        return cola.Dequeue();
    }

    //Peek para devolver el elemento al frente de la cola sin eliminarlo
    public T Peek()
    {
        if (cola.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }

        return cola.Peek();
    }

    //Count para obtener el número de elementos en la cola
    public int Count()
    {
        return cola.Count;
    }

    //IsEmpty para verificar si la cola está vacía
    public bool IsEmpty()
    {
        return cola.Count == 0;
    }

    //Clear para vaciar la cola.
    public void Clear()
    {
        cola.Clear();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Colas<string> cola = new Colas<string>();

        cola.Enqueue("Elemento 1");
        cola.Enqueue("Elemento 2");
        cola.Enqueue("Elemento 3");

        Console.WriteLine("Elementos en la cola: " + cola.Count());
        Console.WriteLine("Elemento al frente de la cola: " + cola.Peek());

        string elementoEliminado = cola.Dequeue();
        Console.WriteLine("Elemento eliminado de la cola: " + elementoEliminado);

        Console.WriteLine("Elementos en la cola después de eliminar uno: " + cola.Count());

        cola.Clear();
        Console.WriteLine("Elementos en la cola después de limpiarla: " + cola.Count());
    }
}