using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema9
    {
        static void Main(string[] args)
        {
            //Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el numero es positvo, nulo o negativo.

            int num;
            int neg = 0;
            int nulo = 1000;

            Console.Write("Ingresa un valor entero: ");
            num = Convert.ToInt32 (Console.ReadLine());

            if (num > neg && num < nulo )
            {
                Console.WriteLine("\nEste es un numero positivo!");
            }
            else
            {
                if(num < neg)
                {
                    Console.WriteLine("\nEste numero es negativo!");
                }
                else
                {
                    Console.WriteLine("\nEste numero es nulo!");
                }
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
