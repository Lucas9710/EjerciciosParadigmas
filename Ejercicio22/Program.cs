/*22. Ingresar un número entero de cuatro dígitos que representa un año. 
 Se pide indicar si fue, es, o será bisiesto. Un año es bisiesto si es divisible por 400 ó, 
 si es divisible por 4 pero no por 100.
*/
using System;

namespace Ejercicio22
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int anio = 0;

            Console.WriteLine("ingrese el año");
            anio = int.Parse(Console.ReadLine());

            if(anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine("es año bisiesto");
            }
            else
            {
                Console.WriteLine("No es año bisiesto");
            }
        }
    }
}
