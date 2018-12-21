using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema6
    {
        static void Main(string[] args)
        {
            //Se ingresan 3 notas de una alumno si el promedio es mayor o igual a 7 mostrar un mensaje que diga promocionado.ç

            int num1, num2, num3;
            int suma, promedio;

            Console.Write("Ingresa la primer tarea: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngresa la segunda tarea: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngresa la tercer tarea: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2 + num3;
            promedio = suma / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("\nFelicidades, Aprobaste Perro!");
            }
            else
            {
                Console.WriteLine("\nVales vrga we, alch te mmas, pinche burro");
            }
            
            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
