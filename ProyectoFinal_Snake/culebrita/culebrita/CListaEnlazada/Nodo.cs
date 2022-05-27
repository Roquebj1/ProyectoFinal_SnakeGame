namespace lcle
{
    public class Nodo
    {
        private Nodo siguiente;
        private object elemento;

        public Nodo(object elemento)
        {
            this.elemento = elemento;
        }

        public object Dato
        {
            get { return elemento; }

        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}