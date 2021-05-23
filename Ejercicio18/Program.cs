using System;
//18. Ingresar 5 números reales e informar el menor de ellos.

namespace Ejercicio18
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;

            Console.WriteLine("ingrese el primer numero");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            num3 = float.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("el numero " + num1 + " es el menor");

            }


            if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("el numero " + num2 + " es el menor");
            }


            if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("el numero " + num3 + " es el menor");
            }
        }
    }
}
