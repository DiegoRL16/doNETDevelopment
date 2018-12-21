using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema14
    {
        static void Main(string[] args)
        {
            //Se ingresan un conjunto de N alturas de personas por teclado. Mostrar la altura promedio de las personas

            int n, x;
            float altura, suma, promedio;

            Console.Write("Cuantas personas hay? ");
            n = Convert.ToInt32 (Console.ReadLine());

            x = 1;
            suma = 0;

            while(x <= n)
            {
                Console.Write("Ingrese la altura: ");
                altura = Convert.ToInt32 (Console.ReadLine());

                suma = suma + altura;
                
                x = x + 1;
            }

            promedio = suma / n;
            Console.WriteLine("\nLa altura promedio es: " + promedio);


            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
