using System;

namespace Ejercicio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int segundos = 0;
            int minutos = 0;
            int horas = 0;
            int suma = 0;

            Console.WriteLine("ingrese segundos");
            segundos = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese minutos");
            minutos = int.Parse(Console.ReadLine());
            minutos = minutos * 60;
            

            Console.WriteLine("ingrese horas");
            horas = int.Parse(Console.ReadLine());
            horas = horas * 3600;


            suma = segundos + horas + minutos;

            Console.WriteLine("el resultado de los segundos es " + suma);

        }
    }
}
