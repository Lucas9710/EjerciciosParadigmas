using System;

namespace Ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double piso = 0;
            double altura = 0;
            double superficie = 0.0;

            Console.WriteLine("ingrese la altura del triangulo");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la base del triaungulo");
            piso = double.Parse(Console.ReadLine());

            superficie = (piso * altura) / 2;
            


            Console.WriteLine("la superficie del triangulo es " + superficie);

            

        }
    }
}
