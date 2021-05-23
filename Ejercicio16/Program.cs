using System;
//16. Se leen dos números y se necesita informarlos en orden ascendentes;

namespace Ejercicio16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer numero");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num2 + " " + num1);
            }
            else
            {
                Console.WriteLine(num1 + " " + num2);
            }



        }
    }
}
