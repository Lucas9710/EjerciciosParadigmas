/*44. Se tienen los montos de ventas diarias de un comercio para n meses(de un mismo año). 
 La información no está ordenada por mes, ni todos los meses registran ventas.
Se necesita informar un listado ordenado por mes de los montos mensuales indicando primeros aquellos 
meses que no registraron ventas.

*/
using System;

namespace Ejercicio44
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int mes = 0;
            int[] cargarVentas = new int[12];
            string[] nombreDeLosMeses = {"Enero", "Febrero", "Marzo", "Abril"
            , "Mayo", "Junio", "Julio", "Agosto", "septiembre", "Octubre", "Noviembre", "Diciembre" };


           for(int i = 0; i < cargarVentas.Length; i++)
            {
                Console.WriteLine("ingrese el numero del mes a ingresar");
                mes = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la venta del mes");
                cargarVentas[mes - 1] = int.Parse(Console.ReadLine());
            }

           for(int i = 0; i < cargarVentas.Length; i++)
            {
                if(cargarVentas[i] == 0)
                {
                    Console.WriteLine("el mes " + nombreDeLosMeses[i] + " no registro ventas ");
                }
               
            }

           for(int i = 0; i < cargarVentas.Length; i++)
            {
                if(cargarVentas[i] > 0)
                {
                    Console.WriteLine("el mes " + nombreDeLosMeses[i] + " registro " + cargarVentas[i] + " ventas");
                }
            }


        }
    }
}
