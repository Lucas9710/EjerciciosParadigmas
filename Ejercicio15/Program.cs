using System;
/*Se presentan dos personas en un banco, éste les asigna el primer lugar de la fila a la mayor 
 de ellas, para lo cual le solicita a cada una de ellas su día, mes y año de nacimiento por separado.
 Se solicita informar a cuál de las personas se le asignará el primer lugar de la fila.
*/
namespace Ejercicio15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int diaPrimeraPersona = 0;
            int diaSegundaPersona = 0;
            int mesPrimeraPersona = 0;
            int mesSegundaPersona = 0;
            int anioPrimeraPersona = 0;
            int anioSegundaPersona = 0;

            Console.WriteLine("ingrese el año de nacimiento de la primera persona");
            anioPrimeraPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el mes de nacimiento de la primera persona");
            mesPrimeraPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el dia de nacimiento de la primera persona");
            diaPrimeraPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el año de nacimiento de la segunda persona");
            anioSegundaPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el mes de nacimiento de la segunda persona");
            mesSegundaPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el dia de nacimiento de la segunda persona");
            diaSegundaPersona = int.Parse(Console.ReadLine());

            if (anioPrimeraPersona < anioSegundaPersona)
            {
                Console.WriteLine("la primer persona obtiene el primer lugar en la fila");

            }

            if (anioPrimeraPersona > anioSegundaPersona)
            {
                Console.WriteLine("la segunda persona obtiene el primer lugar en la fila");
            }

         
            if (anioPrimeraPersona == anioSegundaPersona && mesPrimeraPersona > mesSegundaPersona)
            {
                Console.WriteLine("la segunda persona obtiene el primer lugar en la fila");
            }

            if (anioPrimeraPersona == anioSegundaPersona && mesPrimeraPersona < mesSegundaPersona)
            {
                Console.WriteLine("la primer persona obtiene el primer lugar en la fila");
            }

            if (anioPrimeraPersona == anioSegundaPersona && mesPrimeraPersona == mesSegundaPersona && diaPrimeraPersona < diaSegundaPersona)
            {
                Console.WriteLine("la primer persona obtiene el primer lugar en la fila"); 
            }

            if (anioPrimeraPersona == anioSegundaPersona && mesPrimeraPersona == mesSegundaPersona && diaPrimeraPersona > diaSegundaPersona)
            {
                Console.WriteLine("la segunda persona obtiene el primer lugar en la fila");
            }





        }
    }
}
