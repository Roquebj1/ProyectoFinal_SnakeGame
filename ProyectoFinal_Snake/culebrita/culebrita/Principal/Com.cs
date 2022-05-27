using snake;
using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.Principal
{
    class Com
    {
        ProgramColaArrayList hola = new ProgramColaArrayList();
        pcc lola = new pcc();
        pca lufy = new pca();
        ProgramColaListaEnlazada list = new ProgramColaListaEnlazada();

        void main()
        {
            Console.WriteLine("Digite un número");
            Console.WriteLine("Presione 1 para método ColaArrayList");
            Console.WriteLine("Presione 2 para método Cola Circular");
            Console.WriteLine("Presione 3 para método Cola Arreglo");
            Console.WriteLine("Presione 4 para método ColaListaEnlazada");

            int num = 0;

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


    }
}
