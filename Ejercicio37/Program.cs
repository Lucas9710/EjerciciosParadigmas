/*37. Una gran cadena de electrodoméstico recibe mensualmente un informe consolidado de todas sus 
 sucursales conteniendo la siguiente información:
• Código de sucursal (alfabético 3 caracteres)
• Producto vendido (alfabético 5 caracteres)
• Cantidad vendida (numérico entero)
El listado se encuentra ordenado por código de sucursal, producto y cantidad vendida.
Se pide informar:
Cantidad total vendida por cada sucursal Respetando la siguiente leyenda “La sucursal XXX vendió
yyyyyy productos”
Sucursal con la mejor venta, se debe respetar la siguiente leyenda: “La sucursal con mejor venta fue 
XXX y vendió yyyyy productos”
*/
using System;

namespace Ejercicio37
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string codSUc = "";
            string codSucMayorVenta = "";
            string codSucAnterior = "";
            string producto = "";
            string productoMayor = "";
            int cantVendida = 0;
            int cantPorSucursal = 0;
            int mayorVentaPorSucursal = 0;
            bool huboVenta = false;

            Console.WriteLine("ingrese un codgo de sucursal 999 para terminar");
            codSUc = Console.ReadLine();



            while (codSUc != "999")
            {
                codSucAnterior = codSUc;
                while (codSucAnterior != "999" && codSUc == codSucAnterior)
                {
                    Console.WriteLine("ingrese el producto vendido");
                    producto = Console.ReadLine();

                    Console.WriteLine("ingrese la cantidad vendida");
                    cantVendida = int.Parse(Console.ReadLine());
                   

                    cantPorSucursal += cantVendida;

                    Console.WriteLine("la sucursal " + codSucAnterior + " vendio "
                + cantPorSucursal + " " + producto);


                    Console.WriteLine("ingrese un codigo de sucursal 999 para terminar");
                    codSUc = Console.ReadLine();

                    huboVenta = true;
                }

              

                if (cantPorSucursal > mayorVentaPorSucursal)
                {
                    mayorVentaPorSucursal = cantPorSucursal;
                    codSucMayorVenta = codSucAnterior;
                    productoMayor = producto;
                }
                cantPorSucursal = 0;
                codSucAnterior = codSUc;

            }

            if (huboVenta == true)
            {

                Console.WriteLine("la sucursal con mayor venta fue " + codSucMayorVenta + " vendio " + mayorVentaPorSucursal + " " + productoMayor);

            }
            else
            {
                Console.WriteLine("no se registraron ventas");
            }
        }

    }

}