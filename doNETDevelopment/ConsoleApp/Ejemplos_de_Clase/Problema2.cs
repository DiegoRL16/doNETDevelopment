using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class Problema2
    {
        static void Main(string[] args)
        {
            //Escribir un programa en el cual se ingresan cuatro numeros y calcular e informar la suma de los primeros 2 y el producto del 3 por el cuarto

            int num1, num2, num3, num4;
            int suma, producto;

            Console.Write("Ingrese el primer valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el tercer valor: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el cuarto valor: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            producto = num3 * num4;

            Console.WriteLine("\nEl resultado de la suma del primero valor mas el segundo es: " + suma);
            Console.WriteLine("\nEl resultado del producto del tercer valor por el cuarto es: " + producto);

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
