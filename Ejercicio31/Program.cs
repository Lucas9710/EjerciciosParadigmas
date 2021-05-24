/*Dados dos números enteros A y B, se pide calcular el producto A*B por sumas sucesivas. 
 (Para obtener el producto se va a sumar B veces el número A. Teóricamente se debe obtener el mismo 
 resultado si se suma Aveces el número B.
*/
using System;

namespace Ejercicio31
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroA = 0;
            int numeroB = 0;
            int suma = 0;

            Console.WriteLine("ingrese el numero A");
            numeroA = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero b");
            numeroB = int.Parse(Console.ReadLine());

            for(int i = 0; i < numeroB; i++)
            {
                suma = suma + numeroA;
            }

            Console.WriteLine(suma);
        }
    }
}
