using System;
/*Se necesita crear un programa que imprima lotes de 100 tiquets. La numeración de los tiquets tiene 
  que tener saltos de 10 en diez. Utilizando el ciclo de repetición Hacer – Mientras.
*/

namespace Ejercicio25
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numerador = 0;
            int contador = 0;

            Console.WriteLine("ingrese el valor inicial del ticket");
            numerador = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("el numero de ticket es " + numerador);
                numerador += 10;
                contador++;


            } while (contador < 100);
        }
    }
}
