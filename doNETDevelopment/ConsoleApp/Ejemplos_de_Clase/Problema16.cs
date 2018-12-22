using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema16
    {
        static void Main(string[] args)
        {
            //Programa que solicite la carga de 10 numeros e imprima la suma de los ultimos 5 valores

            int suma, valor;

            suma = 0;
            valor = 0;

            for(int i = 1; i <=10; i++)
            {
                Console.Write("Introduce un numero: ");
                valor = Convert.ToInt32 (Console.ReadLine());
                if (i > 5)
                {
                    suma = suma + valor;
                }

            }

            Console.WriteLine("\nLa suma de los ultimos 5 numeros es: " + suma);
            
            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
