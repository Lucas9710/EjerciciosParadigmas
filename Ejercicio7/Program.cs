//Dados 6 números reales, informar el promedio de los mismos
using System;

namespace Ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;
            double num6 = 0;
            double promedio = 0;

            Console.WriteLine("ingrese el primer numero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el quinto numero");
            num5 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el sexto numero");
            num6 = double.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3 + num4 + num5 + num6) / 6;

            Console.WriteLine("el promedio es " + promedio);




        }
    }
}
