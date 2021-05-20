using System;

namespace Ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double cuadrado = 0.0;
            double superficie = 0.0;

            Console.WriteLine("ingrese la base del cuadrado");
            cuadrado = double.Parse(Console.ReadLine());

            superficie = cuadrado * cuadrado;

            Console.WriteLine("la superficie del cuadrado es " + superficie);
        }
    }
}
