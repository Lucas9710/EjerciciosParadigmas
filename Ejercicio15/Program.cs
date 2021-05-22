//Se presentan dos personas en un banco, éste les asigna el primer lugar de la fila a la mayor de ellas, para lo cual
//le solicita a cada una de ellas su día, mes y año de nacimiento por separado.Se solicita informar a cuál de las
//personas se le asignará el primer lugar de la fila.
using System;

namespace Ejercicio152
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha = 0;
            int fecha2 = 0;
            int dia = 0;
            int dia2 = 0;
            int mes = 0;
            int mes2 = 0;
            int anio = 0;
            int anio2 = 0;

            Console.WriteLine("ingrese la fecha de nacimiento de la primera persona en formato ddmmaaaa");
            fecha = int.Parse(Console.ReadLine());
            mes = fecha % 1000000 / 10000;
            dia = fecha / 1000000;
            anio = fecha % 10000;

            Console.WriteLine("ingrese la fecha de nacimiento de la segunda persona en formato ddmmaaaa");
            fecha2 = int.Parse(Console.ReadLine());
            mes2 = fecha2 % 1000000 / 10000;
            dia2 = fecha2 / 1000000;
            anio2 = fecha2 % 10000;



            //fede begin
            if (anio != anio2)
            {
            }


            //fede end

                if (anio == anio2 )
            {
                if(mes == mes2)
                {
                    if(dia == dia2)
                    {
                        Console.WriteLine("las personas cumplen el mismo dia, ninguna es mayor a la otra");
                    
                    }else if(dia > dia2)
                    {
                        Console.WriteLine("la segunda persona se le asigna el primer lugar en la fila");
                    }
                    else
                    {
                        Console.WriteLine("la primer persona se le asigna el primer lugar en la fila");
                    }
                }
                else if(mes > mes2)
                {
                    Console.WriteLine("la segunda persona se le asigna el primer lugar en la fila");
                }
                else
                {
                    Console.WriteLine("la primer persona se le asigna el primer lugar en la fila");
                }

            }
            else if (anio > anio2)
            {
                Console.WriteLine("la segunda persona se le asgina el primer lugar en la fila");
            }
            else
            {
                Console.WriteLine("La primer persona se le asigna el primer lugar en la fila");
            }


        }
    }
}
