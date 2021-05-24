/*Calcular e informar el promedio de los números pares menores a un valor definido por el usuario. 
 Dicho número no debe ser superior a 1500.
*/

using System;

namespace Ejercicio29
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           int numeroDefinidoPorUsuario = 0;
            int promedio = 0;

            do
            {
                Console.WriteLine("ingrese un numero");
                numeroDefinidoPorUsuario = int.Parse(Console.ReadLine());
           
            }while (numeroDefinidoPorUsuario > 1500);


            for (int i = 2; i < numeroDefinidoPorUsuario; i+=2)
            {
                promedio = promedio + i;
            }
           

            promedio = promedio / numeroDefinidoPorUsuario;
            Console.WriteLine("el promedio de los pares menores al numero " + numeroDefinidoPorUsuario
            + " es " + promedio);
        }
    }
}
