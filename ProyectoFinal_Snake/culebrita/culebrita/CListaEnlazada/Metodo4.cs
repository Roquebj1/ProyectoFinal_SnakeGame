using System;
using System.Collections.Generic;
using System.Text;

namespace lcle
{
    internal class Metodo4
    {
        public Nodo first;
        public Nodo last;
        int tamanio;

        public int NumElementos;

        public int NumElement()//Para saber el valor de los datos de la cola
        {
            return NumElementos;
        }

        public Metodo4()//Constructor
        {
            first = null;
            last = null;
        }

        //Devuelve si la Cola esta vacia
        public bool CVacia()//si la cola está vacía
        {
            return first == null;
        }

        // Devuelve el tamaño de la Cola
        public int TamanoCola()
        {
            return tamanio;
        }

        // Devuelve el frende de la Cola
        public Object FrenteCOla()
        {
            if (!CVacia())//Si la cola no está vacía
            {
                return (first.Dato);
               
            }
            throw new Exception("Cola Vacia");
        }

        // Devuelve el fin de la Cola
        public Object FinadeCOla()
        {
            if (!CVacia())//Si la cola no está vacía 
            {
                return (last.Dato);//Devuelve último dato
                
            }
            throw new Exception("Error Cola Vacia");
        }

        //Inserta un elemento en la cola de ListaEnlazada
        public void Insertar(Object elemento)
        {
            NumElementos++;
            Nodo nuevo =  new Nodo(elemento);//Crea un nodo con el dato ingresado
            if (!CVacia())
            {
                last.Siguiente = nuevo;//El último nodo apunta el nuevo nodo
            }
            else
            {
                first = nuevo;//Si la cola está vacía el primero apunta al nuevo nodo
            }
            last = nuevo;//Ultimo nodo apunta al nuevo nodo
            tamanio++;
        }

        //Quita un valor de la Cola ListaEnlazada
        public Object SuprimirValor()
        {
            NumElementos--;
            Object centinela;//Variable para guardar el dato del nodo a quitar
            if (!CVacia())
            {
                centinela = first.Dato;//guarda el dato del primer nodo
                first = first.Siguiente;//el primer nodo apunta al segundo nodo
                tamanio--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return centinela;
        }

        //Devuelve el Numero de Elementos de la Lista
        public int NumerodeElementosLista()
        {
            int numero;
            Nodo nodo = first;//El nodo apunta al primer elemento
            if (!CVacia())
            {
                numero = 1;
                while (nodo != last)//Si nodo no es igual al último
                {
                    numero++;//Que se sume un dato para nodo
                    nodo = nodo.Siguiente;//Y nodo apunta al siguiente nodo
                }
            }
            else
            {
                numero = 0;
            }
            return numero;
        }
    }

}
