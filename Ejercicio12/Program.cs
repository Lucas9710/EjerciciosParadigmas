/*
 * 12. Dadas las 4 notas obtenidas por un alumno se pide calcular e informar el promedio y una leyenda que indique si
está aprobado. El dato de aprobación se hará a partir de un valor predeterminado que no podrá ser modificable
a lo largo del programa.
*/

using System;

namespace Ejercicio12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int aprobado = 6;
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            float promedio = 0;

            Console.WriteLine("ingrese el valor de la primer nota");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la segunda nota");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la tercera nota");
            nota3= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la cuarta nota");
            nota4 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if(promedio < aprobado)
            {
                Console.WriteLine("el alumno desaprobo, su nota es: " + promedio);
            }
            else
            {
                Console.WriteLine("el alumno aprobo, su nota es: " + promedio);
            }






        }
    }
}
