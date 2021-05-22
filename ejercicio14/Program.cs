//Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor o si son iguales

using System;

namespace ejercicio14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha = 0;
            int anio = 0;
            int mes = 0;
            int dia = 0;

            int fecha2 = 0;
            int anio2 = 0;
            int mes2 = 0;
            int dia2= 0;

            Console.WriteLine("ingrese la primera fecha");
            fecha = int.Parse(Console.ReadLine());
            mes = fecha % 1000000 / 10000;
            dia = fecha / 1000000;
            anio = fecha % 10000;

            Console.WriteLine("ingrese segunda fecha");
            fecha2 = int.Parse(Console.ReadLine());
            mes2 = fecha2 % 1000000 / 10000;
            dia2 = fecha2 / 1000000;
            anio2 = fecha2 % 10000;

            if(fecha == fecha2)
            {
                Console.WriteLine("las fechas son iguales");
            }
            else if(fecha>fecha2)
            {
                Console.WriteLine("la fecha menor es " + dia2 + "/" + mes2 + "/" + anio2);
            }
            else
            {
                Console.WriteLine("la fecha menor es " + dia + "/" + mes + "/" + anio);
            }
        }
    }
}
