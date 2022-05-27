using culebrita;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace snake
{
    class Program
    {

      

        static void Main()
        {
            ProgramColaArrayList hola = new ProgramColaArrayList();
            pcc lola = new pcc();
            pca lufy = new pca();
            ProgramColaListaEnlazada list = new ProgramColaListaEnlazada();

            Console.WriteLine("Digite un número");
            Console.WriteLine("Presione 1 para método ColaArrayList");
            Console.WriteLine("Presione 2 para método Cola Circular");
            Console.WriteLine("Presione 3 para método Cola Arreglo");
            Console.WriteLine("Presione 4 para método ColaListaEnlazada");

            int num = 0;

            Convert.ToInt32(Console.ReadLine());
            num= Convert.ToInt32(Console.ReadLine());


            if (num == 1)
            {
                hola.Mareo();
            }
            if (num == 2)
            {
                lola.Main();
            }
            if (num == 3)
            {
                lufy.Main();
            }
            if (num == 4)
            {
                list.MainListaEnlazada();
            }
        }


    }//end class
}













