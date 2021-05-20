using System;

namespace Ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int altura = 0;
            int piso = 0;
            int superficie = 0;

            Console.WriteLine("ingrese la altura del rectangulo");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la base del rectangulo");
            piso = int.Parse(Console.ReadLine());

            superficie = altura * piso;

            Console.WriteLine("la superficie es: " + superficie);

        }
    }
}
