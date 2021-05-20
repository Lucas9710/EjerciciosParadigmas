using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;

            Console.WriteLine("ingrese el primer numero a sumar");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero a sumar");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer numero a sumar");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero a sumar");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;

            Console.WriteLine("la suma dio resultado: " + suma);
        }
    }
}
