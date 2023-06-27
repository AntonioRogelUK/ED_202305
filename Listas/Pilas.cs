using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class Pilas<T>
{
    private Stack<T> pila;

    public Pilas()
    {
        pila = new Stack<T>();
    }

    // Push para agregar elementos a la pila, 
    public void Push(T elemento)
    {
        pila.Push(elemento);
    }

    //Pop para eliminar y devolver el elemento en la cima de la pila
    public T Pop()
    {
        if (pila.Count == 0)
        {
            throw new InvalidOperationException("La pila está vacía");
        }

        return pila.Pop();
    }

    //Peek para devolver el elemento en la cima de la pila sin eliminarlo
    public T Peek()
    {
        if (pila.Count == 0)
        {
            throw new InvalidOperationException("La pila está vacía");
        }

        return pila.Peek();
    }

    //Count para obtener el número de elementos en la pila
    public int Count()
    {
        return pila.Count;
    }

    //IsEmpty para verificar si la pila está vacía
    public bool IsEmpty()
    {
        return pila.Count == 0;
    }

    //Clear para vaciar la pila.
    public void Clear()
    {
        pila.Clear();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pilas<int> pila = new Pilas<int>();

        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine("Elementos en la pila: " + pila.Count());
        Console.WriteLine("Elemento en la cima de la pila: " + pila.Peek());

        int elementoEliminado = pila.Pop();
        Console.WriteLine("Elemento eliminado de la pila: " + elementoEliminado);

        Console.WriteLine("Elementos en la pila después de eliminar uno: " + pila.Count());

        pila.Clear();
        Console.WriteLine("Elementos en la pila después de limpiarla: " + pila.Count());
    }
}
