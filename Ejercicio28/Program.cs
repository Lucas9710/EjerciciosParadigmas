//Informar las potencias de 2 a partir de 2 0 y como máximo 2 10
using System;

namespace Ejercicio28
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numero = 0;
            const double dos = 2;

            for(double i = 0; i <= 10; i++)
            {
                numero = Math.Pow(dos, i);
                Console.WriteLine("2 elevado a la " + i +" es "+ numero);
            }

        }
    }
}
