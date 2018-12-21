using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema7
    {
        static void Main(string[] args)
        {
            //Se ingresa por teclado un numero positivo de uno o dos digitos (1 - 99) mostrar un mensaje indicando si el numero tiene 1 o 2 digitos.

            int num1;

            Console.Write("Introduzca un numero entre 1-99: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 9 )
            {
                Console.WriteLine("\nEste valor contiene 2 digitos");
            }
            else
            {
                Console.WriteLine("\nEste valor contiene 1 digito");
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
