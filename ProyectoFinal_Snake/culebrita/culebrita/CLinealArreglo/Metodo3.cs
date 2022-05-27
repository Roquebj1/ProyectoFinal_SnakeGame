using System;
using System.Collections.Generic;
using System.Text;

namespace lclarr
{
    internal class Metodo3
    {
        protected int Fin;
        private static int Max = 900000000;
        protected int Frente;

        public int NumElemen;

        public int numeleme()//Para saber el valor de los datos de la cola
        {
            return NumElemen;
        }

        protected Object[] listaCola;//Lista elementos de la cola

        public Metodo3()//Constructor
        {
            Frente = 0;
            Fin = -1;
            listaCola = new Object[Max];
        }

        // OPERACIONES DE MODIFICACIN DE LA COLA

        public void Insertar(Object elemento)//Insertar en la cola
        {
            if (!Cllena())//Si la cola no está llena
            {
                NumElemen++;
                listaCola[++Fin] = elemento;//Agrega el dato de la cola
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        
        }

        public Object Cancelar() //Se cancela o quita el valor de la cola
        {
            if (!Cvacia()){//Si la cola no está vacía

                NumElemen--;
                Object aux = listaCola[Frente++];//Quita el dato de la cola
                return aux;
            //return listaCola[frente++];
            } 
            else {
            throw new Exception("Cola vacia");
            }
        }
        //cola vacia
        public void SuprimirCola()//Se suprime el valor de la cola
        {
            Frente = 0;
            Fin = -1;
        }

        //acceso a la cola
        public Object FrentedeCola()
        {
            if (!Cvacia()){//Si la cola no está vacía
                return listaCola[Frente];
            } 
            else {
                throw new Exception("Peeep Cola Vacía");
            }
        }

        public Object FinaldeCola()//Para saber el final de la cola
        {
            if (!Cvacia())//Si la cola no está vacía
            {
                return listaCola[Fin];
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }


        //metodos de verificacion de cola
        public bool Cvacia()//Si la cola está vacía 
        {
            return Frente > Fin;//Retorna true si la cola está vacía
        }

        public bool Cllena()//Si la cola está llena
        {
            return Fin == Max - 1;//Retorna true si la cola está llena
        }

    }
}
