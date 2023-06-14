namespace Arreglos
{
    public class Colas
    {
        private string[] arreglo;
        private int max;
        private int inicio;
        private int final;

        public Colas(int elementos)
        {
            arreglo = new string[elementos];
            max = arreglo.Length - 1;
            inicio = 0;
            final = 0;
        }

        private bool EsVacío()
        {
            return ((inicio < 1 && final < 1) || inicio == final);
        }
        private bool EstaLleno()
        {
            return (final > max);
        }
        public void Agregar(string dato)
        {
            if (EstaLleno())
            {
                throw new Exception("Esta lleno :(");
            }

            arreglo[final] = dato;
            final++;

        }

        public void Eliminar()
        {
            if (EsVacío())
            {
                throw new Exception("Esta vacío :D");
            }

            arreglo[inicio] = string.Empty;
            inicio++;
        }

        public string Imprimir()
        {
            string datos=string.Empty;
            if (EsVacío())
            {
                return "arreglo vacío";
            }

            for (int i = inicio; i < final; i++)
            {
                if (i > inicio)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {arreglo[i]} ";
            }
            return datos;
        }
    }
}
