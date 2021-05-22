//Se ingresan dos números enteros y se pide el resultado de dividirlos, 
//informando el resultado de la división o un mensaje de error si el mismo no se pudo hacer 
//porque uno de los valores no puede ser admitido para la división

using System;

namespace Proyecto13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;
            int division = 0;

            Console.WriteLine("ingrese el dividendo");
            dividendo = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el divisor");
            divisor = int.Parse(Console.ReadLine());

            if(divisor != 0)
            {
                division = dividendo / divisor;
                Console.WriteLine("el resultado es: " + division);
            }
            else
            {
                Console.WriteLine("el divisor no puede contener 0");
            }








        }
    }
}
