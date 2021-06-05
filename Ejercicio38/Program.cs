/*La misma cadena de electrodomésticos anterior comienza a recibir un informe consolidado 
  de ventas por productos. Conteniendo la siguiente información”
• Producto vendido (alfabético 5 caracteres)
• Código de sucursal(alfabético 3 caracteres)
• Cantidad vendida (numérico entero)
El listado se encuentra ordenado en la forma que están informados los datos anteriores.
Se pide:
• Informar código y cantidad del producto más vendido.
• Informar la cantidad del producto con menor venta.
*/

using System;

namespace Ejercicio38
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string codigoProducto = "";
            string codigoDeSucursal = "";
            string codigoDeProductoMenor = "";
            string codProductoMayorVenta = "";
            string codigoProductoAnterior = "";
            int cantidadVendida = 0;
            int menorVentaxProducto = 0;
            int mayorVentaxProducto = 0;
            int cantPorProducto = 0;
           

            Console.WriteLine("ingrese un codigo de sucursal o 0 para finalizar");
            codigoDeSucursal = Console.ReadLine();

            Console.WriteLine("ingrese un codigo de producto");
            codigoProducto = Console.ReadLine();

            while (codigoDeSucursal != "0")
            {
                codigoProductoAnterior = codigoProducto;

                while(codigoDeSucursal!= "0" && codigoProducto == codigoProductoAnterior)
                {
                    Console.WriteLine("ingrese la cantidad vendida");
                    cantidadVendida = int.Parse(Console.ReadLine());

                    cantPorProducto += cantidadVendida;

                    Console.WriteLine("ingrese un codigo de sucursal o 0 para finalizar");
                    codigoDeSucursal = Console.ReadLine();

                    if( codigoDeSucursal != "0")
                    {

                        Console.WriteLine("ingrese un codigo de producto");
                        codigoProducto = Console.ReadLine();


                    }


                   
                }
               

                if (cantPorProducto < menorVentaxProducto || menorVentaxProducto == 0)
                {
                    menorVentaxProducto = cantPorProducto;
                    codigoDeProductoMenor = codigoProductoAnterior;

                }

                if(cantPorProducto > mayorVentaxProducto || mayorVentaxProducto == 0)
                {
                    mayorVentaxProducto = cantPorProducto;
                    codProductoMayorVenta = codigoProductoAnterior;
                }

                cantPorProducto = 0;
               
            }

                Console.WriteLine("el producto màs vendido es " + codProductoMayorVenta + " vendio " + mayorVentaxProducto);
                Console.WriteLine(" el producto menos vendido es " + codigoDeProductoMenor + " vendio " + menorVentaxProducto);
           
        }
    }
}
