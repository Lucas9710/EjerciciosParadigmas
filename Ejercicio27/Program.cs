/*Calcular e informar el factorial de un número positivo. (El Factorial de un número entero positivo 
  se define como n!=1*2*3....(n-2)*(n-1)*n. También se define que el factorial de 0=1 → 0!=1)
Utilizar un ciclo repetir para la lectura del dato con el fin de no permitir avanzar hasta que no se
ingrese un número mayor o igual que 0
*/
using System;

namespace Ejercicio27
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            double factorial = 1;

           

           do {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());

            } while (numero <= 0) ;

            for(int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("el factorial es " + factorial);
        }
    }
}
