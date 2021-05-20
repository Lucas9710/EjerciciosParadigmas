/*
 * Una concesionaria de autos paga a su personal, un salario de 5500 pesos por mes, mas una comisión del 200
pesos por cada auto vendido y un adicional del 5% del valor del auto vendido. Diseñar un algoritmo para calcular
el salario total del vendedor. Conociendo solamente el número de autos vendidos y el valor de venta de la
unidad.
*/
using System;

namespace Ejercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int salario = 5500; 
            int autos = 0;
            int valor = 0;
            int total = 0;
            int comision = 0;

            Console.WriteLine("ingrese la cantidad de autos vendidos");
            autos = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del auto vendido");
            valor = int.Parse(Console.ReadLine());

            comision = (200 * autos) + (5 * valor / 100) * autos;

            total = comision + salario;

            Console.WriteLine("el salario en total es " + total);



        }
    }
}
