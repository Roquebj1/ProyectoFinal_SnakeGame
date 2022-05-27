using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colcc
{
    internal class Metodo2
    {
        private static int fin;
        private static int Max = 900000000;
        protected int frente;

        public int NumDeElementos;

        public int numeleme()//Para saber el valor de los datos de la cola
        {
            return NumDeElementos; 
        }



        protected Object[] listaCola; //Ac� vemos que lo �nico que cambia es lo de Object 
        // Ac� avanza una posici�n

        private int Siguiente(int r)//Obtiene el siguiente elemento de la cola
        {
            return (r + 1) % Max;
        }

        //Ac� inicializa la cola vac�a

        public Metodo2()//Constructor
        {
            frente = 0;
            fin = Max - 1;
            listaCola = new Object[Max];//Crea una lista de elementos de la cola
        }

        // Ac� vemos las operaciones de modificaci�n de la cola
        public void Insertar(Object elemento)////Insertar en la cola
        {
            if (!CLlena())//Si la cola no est� llena 
            {
                NumDeElementos++;
                fin = Siguiente(fin);//Obtiene el siguiente elemento de la cola
                listaCola[fin] = elemento;//Agrega el dato de la cola
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        }

        public Object Cancelar()//Se cancela o quita el valor de la cola
        {
            if (!CVacia())//Si la cola no est� vac�a 
            {
                NumDeElementos--;
                Object x = listaCola[frente];//Obtiene el siguiente elemento de la cola
                frente = Siguiente(frente);//Quita el primer elemento de la cola
                return x;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }



        public void SuprimirCOla()//Se suprime el valor de la cola
        {
            frente = 0;
            fin = Max - 1;
        }

        // Damos el acceso a la cola
        public Object FrenteCola()
        {
            if (!CVacia())//Si la cola no est� vac�a
            {
                return listaCola[frente];//Se retorna listacola frente
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }

        public Object FinalCola()
        {
            if (!CVacia())//Si la cola no est� vac�a
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }


        // Luego los m�todos de verificaci�n del estado de la cola

        public bool CVacia()//Si la cola est� vac�a
        {
            return frente == Siguiente(fin);
        }

        // Y comprobamos si est� llena

        public bool CLlena()
        {
            return frente == Siguiente(Siguiente(fin));
        }





    }

}
