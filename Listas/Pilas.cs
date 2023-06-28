namespace ListasPilas
{
    class Pilas
    {
        class Node
        {
            public int queOtro;
            public Node otroQue;
        }
        private Node procesoInc;

        public Pilas()
        {
            procesoInc = null;
        }

        public void Agregar(int x)
        {
            Node nuevo;
            nuevo = new Node();
            nuevo.queOtro = x;
            if (procesoInc == null)
            {
                nuevo.otroQue = null;
                procesoInc = nuevo;
            }
            else
            {
                nuevo.otroQue = procesoInc;
                procesoInc = nuevo;
            }
        }

        public int Extraer()
        {
            if (procesoInc != null)
            {
                int informacion = procesoInc.queOtro;
                procesoInc = procesoInc.otroQue;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }
        public void Imprimir()
        {
            Node reco = procesoInc;
            Console.WriteLine("Listado de todos los elementos de la pila.");
            while (reco != null)
            {
                Console.Write(reco.queOtro + "-");
                reco = reco.otroQue;
            }
            Console.WriteLine();
        }
        public bool EstaVacia()
        {
            if (procesoInc == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Cantidad()
        {
            int cant = 0;
            Node reco = procesoInc;
            while (reco != null)
            {
                cant++;
                reco = reco.otroQue;
            }

            return cant;
        }
        static void Main(string[] args)
        {
            Pilas pila = new Pilas();
            pila.Agregar(10);
            pila.Agregar(20);
            pila.Agregar(30);
            pila.Imprimir();
            Console.WriteLine("La cantidad de nodos de la lista es:" + pila.Cantidad());
            while (pila.EstaVacia() == false)
            {
                Console.WriteLine(pila.Extraer());
            }
            Console.ReadKey();
        }

    }
}
