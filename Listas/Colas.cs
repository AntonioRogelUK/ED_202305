using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List<string> lista;
        public Colas()
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
            if(Esvacio())
            {
                throw new Exception("La lista esta vacía");
            }

           lista.RemoveAt(0);
        }

        public string Imprimir()
        {
          string datos= string.Empty;
            foreach(string dato in lista)
            {
                datos += $"{dato}\n";
            }
            return datos;
        }
    }
}
