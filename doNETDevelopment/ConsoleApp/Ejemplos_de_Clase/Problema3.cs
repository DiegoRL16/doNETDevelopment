using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema3
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea cuatro valores numericos e informar su suma y promedio

            int num1, num2, num3, num4;
            int suma, promedio;

            Console.Write("Ingrese el primer valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el tercer valor: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el cuarto valor: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine("\nEl resultado de la suma es: " + suma);
            Console.WriteLine("\nEl resultado del promedio es: " + promedio);

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
