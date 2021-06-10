/*Escribir un método para determinar si una secuencia de caracteres de entrada es de la forma:
 X & Y siendo X una cadena de caracteres e Y la cadena inversa. El carácter & es el separador.
El siguiente ejemplo corresponde a una cadena inversa correcta Ej: hola&aloh
Esta otra expresión no lo es: hola&ahol*/
using System;
using System.Collections;

namespace Ejercicio49
{
    class Pila
    {
        public static void Main(string[] args)
        {
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            string cadena1 = "";
           // string cadena2 = "";

            Console.WriteLine("ingrese la primer secuencia de caracteres");
            cadena1 = Console.ReadLine();
            /*
            Console.WriteLine("ingrese la segunda secuencia de caracteres");
            cadena2 = Console.ReadLine();
            */
           SecuenciaDeCaracteres(cadena1);
        }

            static void SecuenciaDeCaracteres(string cadena1)
        {
            string[] arreglo = new string[cadena1.Length];
            arreglo = cadena1.Split('&');
            for(int i = 0; i < arreglo.Length; i++)
            {
              Console.WriteLine( arreglo[i]);
            }

        }
    }
}
