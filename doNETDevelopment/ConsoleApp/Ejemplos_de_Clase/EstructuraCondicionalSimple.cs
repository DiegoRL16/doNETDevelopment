using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class EstructuraCondicionalSimple
    {
        static void Main(string[] args)
        {
            //Programa para ingresar el sueldo de una persona, si supera los $3,000 pesos, 
            //mostrar un mensaje en pantalla, indicando que debe abonar impuestos

            //Declarar las variables
            float sueldo;

            //Preguntar el sueldo de una persona
            Console.Write("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());

            //Hacer la condicional para validar el sueldo
            if (sueldo > 3000)
            {
                Console.WriteLine("\nEsta persona debe abonar impuestos");
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
