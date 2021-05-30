using System;
/*
Dados dos números enteros A y B, se pide calcular el resultado de la división entera de dividir A 
sobre B, por restas sucesivas (NO SE PUEDE USAR LA DIVISION DIRECTA). Para obtener la división entera 
de dividir A sobre B se debe hacer: A-B = r1, r1-b= r2, r2-B=r3…..rn-1-b=rn

La última resta es aquella que da como resultado rn<B. La cantidad de veces que se restó B es la 
división entera buscada y el rn es el resto de la división. Por ejemplo, suponer que se quiere hacer 
7 sobre 3 por restas sucesivas, el algoritmo seria el siguiente:
7>=2 verdadero → 7-2 = 5
5>=2 verdadero →5-2 = 3
3>=2 verdadero →3-2=1
1>=2 falso → finaliza el ciclo de restas
7 sobre 2 = cantidad de restas realizadas 3
*/

namespace Ejercicio32
{
    class ParadigmasDeProgramacion
    {
        public static void Main(string[] args)
        {
            int numA = 0;
            int numB = 0;
            int c = 0;

            Console.WriteLine("ingrese el primer numero entero");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer numero entero");
            numB = int.Parse(Console.ReadLine());

           if(numA >= numB)
            {
                numA -=  numB;
                c += 1;
            }

            Console.WriteLine("el resultado es " + c + "," + numA);


        }
    }
}
