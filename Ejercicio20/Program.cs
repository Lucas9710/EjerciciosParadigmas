using System;
/*Diseñar un algoritmo que realice la consistencia de una fecha, es decir que los tres datos leídos 
 (día, mes, año) correspondan a una fecha válida. Informando si la fecha es correcta, o bien informando 
 la primer parte inconsistente. Ej Fecha válida: 31 12 2013 Ej Fecha inválida: 12 31 2013.
*/

namespace Ejercicio20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha = 0;

            Console.WriteLine("ingrese fecha");
            fecha = int.Parse(Console.ReadLine());
             int mes = fecha % 1000000 / 10000;
            int dia = fecha / 1000000;
           int anio = fecha % 10000;



            if (anio > 1900 & anio <= 2021  && mes > 0 && mes <= 12 && dia > 0 && dia <= 31  )
            {
                Console.WriteLine("la fecha es valida");
            }
            else
            {
                Console.WriteLine("la fecha es invalida");
            }

        }
    }
}
