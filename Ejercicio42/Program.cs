/*42. Se tienen los montos de ventas totales de los n primeros meses (definidos por el usuario), 
 correspondiente a un mismo año de un comercio. Se quiere calcular e informar la venta promedio de
 esos meses, así como el nombre del mes y el monto de la venta de aquellos meses en que la venta 
 superó a la venta promedio calculada. Las ventas se encuentras ordenadas por mes ascendente 
 (enero al mes indicado por el usuario). El usuario podría no requerir ningún informe indicando 0 
  como número de meses a procesar.
*/
using System;

namespace Ejercicio42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int meses = 0;
            double sumaDeVentas = 0;
            double promedio = 0;
           

            Console.WriteLine("ingrese los meses");
            meses = int.Parse(Console.ReadLine());

            int[] ventas = new int[meses];
            string[] nombreDeLosMeses = new string[12] { "Enero", "Febrero", "Marzo", "Abril"
            , "Mayo", "Junio", "Julio", "Agosto", "septiembre", "Octubre", "Noviembre", "Diciembre" };

            for(int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("ingrese el numero de ventas del mes");
                ventas[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < ventas.Length; i++)
            {
                sumaDeVentas += ventas[i]; 
            }

            promedio = sumaDeVentas / meses;

            Console.WriteLine("el promedio de las ventas es " + promedio);

            for (int i = 0; i < ventas.Length; i++)
            {
                if(promedio < ventas[i] )
                {
                    Console.WriteLine("el mes " + nombreDeLosMeses[i] + " supero el promedio con " + ventas[i] + " ventas");
                   
                }
            }



         
        }
    }
}
