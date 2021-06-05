/*40. Una gran cadena de electrodoméstico recibe mensualmente un informe consolidado de todas sus 
  sucursales conteniendo la siguiente información:
• Código de sucursal (alfabético 3 caracteres)
• Producto vendido (alfabético 5 caracteres)
• Cantidad vendida (numérico entero)
El listado se encuentra ordenado por código de sucursal, producto y cantidad vendida.
Se pide informar:
Cantidad total vendida por cada sucursal Respetando la siguiente leyenda “La sucursal XXX vendió
yyyyyy productos”
Sucursal con la mejor venta, se debe respetar la siguiente leyenda: “La sucursal con mejor venta 
fue XXX y vendió yyyyy productos”
*/
using System;

namespace Ejercicio40
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string codigoDeSucursal = "";
            string codigoDeSucursalAnterior = "";
            string productoVendido = "";
            int cantidadTotalVendida = 0;
            int cantidadVendida = 0;
            int cantidadVendidaDeSucursalConMayorVenta = 0;
            string codigoDeSucursalConMayorVenta = "";
            

            Console.WriteLine("ingrese su codigo de sucursal");
            codigoDeSucursal = Console.ReadLine();

            while(codigoDeSucursal != "f")
            {
                codigoDeSucursalAnterior = codigoDeSucursal;

                while (codigoDeSucursal != "f" && codigoDeSucursalAnterior == codigoDeSucursal)
                {
                    Console.WriteLine("ingrese el producto vendido");
                    productoVendido = Console.ReadLine();

                    Console.WriteLine("ingrese la cantidad de producto vendida");
                    cantidadVendida = int.Parse(Console.ReadLine());

                    cantidadTotalVendida += cantidadVendida;

                    Console.WriteLine("ingrese su codigo de sucursal");
                    codigoDeSucursal = Console.ReadLine();

                }

                Console.WriteLine("la sucursal " + codigoDeSucursalAnterior + " vendio " + cantidadTotalVendida + " productos");

                if(cantidadVendidaDeSucursalConMayorVenta < cantidadTotalVendida)
                {
                    cantidadVendidaDeSucursalConMayorVenta = cantidadTotalVendida;
                    codigoDeSucursalConMayorVenta = codigoDeSucursalAnterior;
                }
                cantidadTotalVendida = 0;
            }

            Console.WriteLine("La sucursal con mejor venta fue" + codigoDeSucursalConMayorVenta + " y vendió yyyyy productos " + cantidadVendidaDeSucursalConMayorVenta);

        }
    }
}
