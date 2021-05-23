/*Se necesita crear un programa que imprima lotes de 100 tiquets. La numeración de los tiquets 
 tiene que tener saltos de 10 en diez. Utilizando el ciclo de repetición Mientras – Hacer.
 */
using System;

namespace Ejercicio24
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int numerador = 0;
            int contador = 0;

            Console.WriteLine("ingrese el valor inicial del ticket");
            numerador = int.Parse(Console.ReadLine());

            while (contador < 100) 
            {
                Console.WriteLine("el numero de ticket es " + numerador);
                numerador+= 10 ;
                contador++;


            } 
        }
    }
}
