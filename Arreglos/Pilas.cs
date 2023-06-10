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
    }
}
