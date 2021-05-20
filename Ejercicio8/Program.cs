/*
 * Dados 2 números enteros, que representan una cantidad parcial y total se pide: Calcular e informar el
porcentaje que representa la primera de la segunda. ¿Qué tipo de datos son los recomendados para este
algoritmo?
*/
using System;

namespace Ejercicio8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double porcentaje = 0;

            Console.WriteLine("ingrese el porcentaje");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero a sacar porcentaje");
            num2 = double.Parse(Console.ReadLine());

            porcentaje = num1 * num2 / 100;

            Console.WriteLine("el porcentaje es: " + porcentaje);


        }
    }
}
