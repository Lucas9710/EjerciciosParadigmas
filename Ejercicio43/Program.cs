/*Idem al ejercicio 42 pero:
1) Informar el promedio de ventas de los meses que superaron la venta promedio total. 
 Por mes descendente, (de aquellos meses que superaron la venta promedio)
2) Informar el promedio de la venta de aquellos meses cuya venta superó al promedio)
*/
using System;

namespace Ejercicio43
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int meses = 0;
            double sumaDeVentas = 0;
            double promedio = 0;
            double sumaDeMesesQueSuperaronElPromedio = 0;
            double contador = 0;
            double PromedioDeMesesQueSuperaronElPromedioDeVentas = 0;


            Console.WriteLine("ingrese los meses");
            meses = int.Parse(Console.ReadLine());

            int[] ventas = new int[meses];
            string[] nombreDeLosMeses = new string[12] { "Enero", "Febrero", "Marzo", "Abril"
            , "Mayo", "Junio", "Julio", "Agosto", "septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("ingrese el numero de ventas del mes");
                ventas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ventas.Length; i++)
            {
                sumaDeVentas += ventas[i];
            }

            promedio = sumaDeVentas / meses;

            Console.WriteLine("el promedio de las ventas es " + promedio);

            for (int i = ventas.Length - 1; i >= 0 ; i--)
            {
                if (promedio < ventas[i])
                {
                    Console.WriteLine("el mes " + nombreDeLosMeses[i] + " supero el promedio con " + ventas[i] + " ventas");

                    sumaDeMesesQueSuperaronElPromedio += ventas[i];
                    contador++;

                }
            }

            PromedioDeMesesQueSuperaronElPromedioDeVentas = sumaDeMesesQueSuperaronElPromedio / contador;
            Console.WriteLine("el promedio de los meses que superaron el promedio de ventas es " + PromedioDeMesesQueSuperaronElPromedioDeVentas);

        }
    }
}
