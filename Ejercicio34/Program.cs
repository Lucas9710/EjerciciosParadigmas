/*Informar el máximo valor de un lote de n números reales. La cantidad de N números reales 
 * será ingresada por el usuario del programa.
*/
using System;

namespace Ejercicio34
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numero = 0;
            double numeroMayor = 0;
            int numeroTotal = 0;
           

            Console.WriteLine("ingrese la cantidad de numeros que tendra su lote, y luego ingreselos");
            numeroTotal = int.Parse(Console.ReadLine());

            for(int i = 0; i < numeroTotal; i++)
            {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if(numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
            }

            Console.WriteLine("su lote tiene " + numeroTotal + " y el mayor es " + numeroMayor);
        }
    }
}
