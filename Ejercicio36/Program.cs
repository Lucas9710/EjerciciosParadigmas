/*Informar el valor máximo de un conjunto de números reales que finaliza con un valor 0, el cual no 
  pertenece al conjunto a leer. Además Informar además la cantidad de veces que se repite el valor
  máximo en el conjunto.
*/
using System;

namespace Ejercicio36
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numero = 0;
            double numeroMayor = 0;
            int repeticiones = 0;

            Console.WriteLine("ingrese un conjunto de numeros reales en el cual 0 no pertenece y sera usado como el finaliador");

            do
            {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if(numero >= numeroMayor)
                {
                    numeroMayor = numero;
                    repeticiones++;
                }
            } while (numero != 0);

            Console.WriteLine("el numero mayor es " + numeroMayor + " cantidad de repeticiones " + repeticiones);
        }
    }
}
