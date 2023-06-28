namespace ListasColas
{
    class Cola
    {
        class NodoColas
        {
            public int queOtro;
            public NodoColas otroQue;
        }
        private NodoColas procesoInc, fondo;
        public Cola()
        {
            procesoInc = null;
            fondo = null;
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
        public void Insertar(int info)
        {
            NodoColas nuevo;
            nuevo = new NodoColas();
            nuevo.queOtro = info;
            nuevo.otroQue = null;
            if (EstaVacia())
            {
                procesoInc = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.otroQue = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!EstaVacia())
            {
                int informacion = procesoInc.queOtro;
                if (procesoInc == fondo)
                {
                    procesoInc = null;
                    fondo = null;
                }
                else
                {
                    procesoInc = procesoInc.otroQue;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Imprimir()
        {
            NodoColas reco = procesoInc;
            Console.WriteLine("Listado de todos los elementos de la cola ");
            while (reco != null)
            {
                Console.Write(reco.queOtro + "\n ----- \n");
                reco = reco.otroQue;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola = new Cola();
            cola.Insertar(1);
            cola.Insertar(2);
            cola.Insertar(3);
            cola.Imprimir();
            Console.WriteLine("Extraemos un elemento de la cola:" + cola.Extraer());
            cola.Imprimir();
            Console.ReadKey();
        }
    }
}