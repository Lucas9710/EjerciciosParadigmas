using System;
//Ingresar 3 números enteros e informar el menor de ellos. CONFECCIONAR PRUEBA DE ESCRITORIO

namespace Ejercicio17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            if(num1 < num2 && num1 < num3)
            {
                Console.WriteLine("el numero " + num1 + " es el menor");

            }


            if(num2 < num1 && num2 < num3)
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
