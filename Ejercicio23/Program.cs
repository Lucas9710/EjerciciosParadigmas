/*
23. Se necesita ingresar una fecha en formato DDMMAAAA dos dígitos para el día, dos dígitos 
para el mes y cuatro dígitos para el año.Si pide informar si DD y MM son correctos o si son incorrectos.
Utilizar una prueba booleana para informar el resultado. (variable booleana puede tomar los valores 
true o false).
a.Ej.Fecha válida: 31122013
b.Ej.Fecha inválida: 12312013
c.Ej.Fecha inválida: 29022015
*/

using System;

namespace Ejercicio23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha = 0;
            int mes = 0;
            int dia = 0;
            int anio = 0;
            bool validoMes = false;
            bool validoDia = false;

            Console.WriteLine("ingrese el numero de fecha");
            fecha = int.Parse(Console.ReadLine());
            mes = fecha % 1000000 / 10000;
            dia = fecha / 1000000;
            anio = fecha % 10000;

            if(mes > 0 && mes <= 12)
            {
                validoMes = true;
            }

            if(dia > 0 && dia < 31)
            {
                validoDia = true;
            }

            if(validoDia == true)
            {
                Console.WriteLine("el dia esta valido");
            }

            if(validoMes == true)
            {
                Console.WriteLine("el mes esta valido");
            }
        }
    }
}
