//Informar el valor máximo de un conjunto de números reales que finaliza con valor 0, 
//el cual pertenece al conjunto.Se lee al menos un valor.
using System;

namespace EJercicio33
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numMayor = 0;
            double numero = 0;

            do
            {
                Console.WriteLine("ingrese un numero");
                numero = double.Parse(Console.ReadLine());

                if (numero > numMayor)
                {
                    numMayor = numero;
                }
            } while (numero >= 0);

            Console.WriteLine("el numero mayor es " + numMayor);


        }
    }
}
