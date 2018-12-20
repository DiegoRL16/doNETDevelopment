using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejemplos_de_Clase
{
    class SumaProductoNumeros
    {

        /// <summary>
        /// Realizar un programa para la carga de 2 numeros enteros por teclado 
        /// e imprimir la suma y el producto de estos.
        /// </summary>

        static void Main(string[] args)
        {
            //Declarar las variables
            int num1, num2; //-->Guardar los datos introducidos por el teclado
            int suma, producto; //-->Guardar los resultados esperados

            //Asignar los valores a las variables
            Console.Write("Ingrese primer valor: ");

            //Recibe la informacion desde el teclado y la guarda en la variable
            //Convertir lo obtenido al esperado
            num1 = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Realizar las operaciones correspondientes
            suma = num1 + num2;
            producto = num1 * num2;

            //Mostrar los resultados 
            Console.WriteLine("La suma de los dos valores es: " + suma);
            Console.WriteLine("El producto de los dos valores : " + producto);

            //Detener las consola para ver el resultado 
            Console.Write("Presiona una tecla para salir");
            Console.ReadKey();

        }
    }
}
