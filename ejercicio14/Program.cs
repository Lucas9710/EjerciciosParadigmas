//Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor o si son iguales.

using System;

namespace ejercicio14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha1 = 0;
            int fecha2 = 0;
            int mes = 0;
            int dia = 0;
            int anio = 0;
            int anio2 = 0;
            int mes2 = 0;
            int dia2 = 0;
           
            

            Console.WriteLine("ingrese la primer fecha");
            fecha1 = int.Parse(Console.ReadLine());
            mes = fecha1 % 1000000 / 10000;
            dia = fecha1 / 1000000;
            anio = fecha1 % 10000;
            

            Console.WriteLine("ingrese la segunda fecha");
            fecha2 = int.Parse(Console.ReadLine());
            mes2 = fecha2 % 1000000 / 10000;
            dia2 = fecha2 / 1000000;
            anio2 = fecha2 % 10000;


            if (anio < anio2)
            {
                Console.WriteLine("la fecha " + dia + "/" + mes + "/" + anio + " es mayor");
                
            }

            if(anio > anio2)
            {
                Console.WriteLine("la fecha " + dia2 + "/" + mes2 + "/" + anio2 + " es mayor");
            }

            if(anio == anio2 && mes == mes2 && dia == dia2)
            {
                Console.WriteLine(" la fecha son iguales");
            }

            if(anio == anio2 && mes > mes2)
            {
                Console.WriteLine("la fecha " + dia2 + "/" + mes2 + "/" + anio2 + " es mayor");
            }

            if(anio == anio2 && mes < mes2)
            {
                Console.WriteLine("la fecha " + dia + "/" + mes + "/" + anio + " es mayor");
            }

            if(anio == anio2 && mes == mes2 && dia < dia2)
            {
                Console.WriteLine("la fecha " + dia + "/" + mes + "/" + anio + " es mayor");
            }

            if(anio == anio2 && mes == mes2 && dia > dia2)
            {
                Console.WriteLine("la fecha " + dia2 + "/" + mes2 + "/" + anio2 + " es mayor");
            }








        }
    }
}
