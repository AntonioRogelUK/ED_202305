using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();

        }
        private bool Esvacio()
        {
            return (lista.Count == 0);
        }
        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        public void Eliminar()
        {
            if (Esvacio())
            {
                throw new Exception("La lista esta vacía");
            }

            int indice = lista.Count;

            if (indice != -1)
            {
                lista.RemoveAt(indice);
            }

        }

        public string Imprimir()
        {
            string datos = string.Empty;
            foreach (string dato in lista)
            {
                datos += $"{dato}\n";
            }
            return datos;
        }
    }
}
