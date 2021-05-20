/*
 * Dada una fecha que se lee en formato numérico DDMMAAAA (dos números para el día, dos para el mes, cuatro
para el año), se solicita obtener el día el mes y año por separado en tres variables. (usar descomposición
matemática)
/*/
using System;

namespace Ejercicio9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha = 0;
            int anio = 0;
            int mes = 0;
            int dia = 0;

            Console.WriteLine("ingrese el numero de fecha");
            fecha = int.Parse(Console.ReadLine());
             mes = fecha % 1000000 / 10000;
            dia = fecha / 1000000;
            anio = fecha % 10000;

            Console.WriteLine("la fecha es: " + dia + "/" + mes + "/" + anio);

        }
    }
}
