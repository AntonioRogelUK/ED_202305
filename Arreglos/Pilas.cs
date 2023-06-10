namespace Arreglos
{
    public class Pilas
    {
        private string[] arreglo;
        private int max;
        private int tope;

        public Pilas(int elementos)
        {
            arreglo = new string[elementos];
            tope = 0;
            max = arreglo.Length - 1;
        }
        public bool EsVacio()
        {
            return tope < 1;
        }
        public bool EstaLleno()

        {
            return tope > max;
        }
        public void Agregar(string dato)
        {
            if (EstaLleno())
            {
                throw new Exception("El arreglo esta lleno");
            }
            arreglo[tope] = dato;
            tope++;

        }

        public void Eliminar()
        {
            if (EsVacio())
            {
                throw new Exception("El arreglo esta vacio");
            }
            tope--;
            arreglo[tope] = string.Empty;
        }

        public string Imprimir()
        {
            string dato = string.Empty;
            if (EsVacio())
            {
                return "No hay elementos en el arreglo";
            }
            for (int i = 0; i < tope; i++)
            {
                if (i > 0)
                {
                    dato += "\n";

                }
                dato += $"[{i}]-{arreglo[i]}";

            }
            return dato;


        }
    }
}
