using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema17
    {
        static void Main(string[] args)
        {
            //Programa que muestre la tabla de multiplicar del 5 (del 5 al 50)

            int num, resultado;

            Console.Write("Ingresa el valor a multiplicar: ");
            num = int.Parse (Console.ReadLine());

            for (int i = 1; i <= 10; i ++)
            {
                resultado = num * i;
                Console.WriteLine(num + " * " + i + " = " + resultado);
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
