using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema15
    {
        static void Main(string[] args)
        {
            //Programa que imprima 25 terminos de la serie 11

            int x, n, a;

            x = 1;
            n = 11;

            while(x <= 25)
            {
                Console.WriteLine(n);
                Console.WriteLine(" - ");
                x = x + 1;
                n = n + 11;
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
