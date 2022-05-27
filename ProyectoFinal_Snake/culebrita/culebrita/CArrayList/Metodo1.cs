using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lca
{
    internal class Metodo1
    {
        ArrayList Carray = new ArrayList();//Se inicializa array list
        int tamano;
        public int TamanioCola()//Para saber el tamaño de la cola
        {
            return tamano;
        }


        //incializa la cola con una serie de elementos
        public Metodo1()//Constructor
        {
             this.Carray = new ArrayList();
        }


        public int NumElementos;

        public int NumElement()//Para saber el valor de los datos de la cola
        {
            return NumElementos;
        }

        public Object finalcola()//Para saber el valor final de la cola
        {

            return Carray[Carray.Count - 1];//Para posicionarse en el último valor
        }

        public void Insertar(object dato)//Insertar en la cola
        {
            if (!CLlena())//Si la cola no está llena 
            {
                NumElementos++;
                Carray.Add(dato);//Se agrega el dato a la cola
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
            tamano++;

        }

        public object Cancelar()//Se cancela o quita el valor de la cola
        {
            if (!CVacia())//Si la cola no está vacía 
            {
                object dato = Carray[0];//Se apunta al primer dato 
                Carray.RemoveAt(0);//Se remueve 
                NumElementos--;
                tamano--;
                return dato;//Devuelve dato
            }
            else
            {
                throw new Exception("Peeep Cola Vacía");
            }
        }

         
        
        public bool CVacia()//Si la cola está vacía 
        {
            if (Carray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CLlena()//Si la cola está llena
        {
            if (Carray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
