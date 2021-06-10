/*3. Idem al ejercicio anterior pero se pueden vender 1 ,2, 3 ó cuatro productos por venta. 
 * (se cierra la venta con ingresando un producto ‘0000’*/
using System;

namespace Ejercicio3Pag56
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int productoAvender = 0;
            int importeDelProducto = 0;
            int contador = 0;
            int contador2 = 0;
            int cantidadDeVentasDelProductoConMayorVentas = 0;
            int importeDelProductoQueMasDIneroVendio = 0;
            int nombreDeProductoConMayorVenta = 0;
            int nombreDelProductoQueMasDineroVendio = 0;
            string continuar = "";
            string[] productos = { "producto 1", "producto 2", "producto 3", "producto 4" };
            int[] producto1 = new int[30];
            int[] producto2 = new int[30];
            int[] producto3 = new int[30];
            int[] producto4 = new int[30];
            int[] sumaDeImportes = new int[4];
            int[] cantidadDeVentasPorProducto = new int[4];
            int[] importePorVenta = new int[30];
            string[] nombreDelProductoDeLaVenta = new string[30];
            int[] ventasDelDia = new int[40]; 


            do {
                Console.WriteLine($"numero de venta {contador + 1}");
                Console.WriteLine("ingrese el producto a vender 1, 2, 3 0 4");
                productoAvender = int.Parse(Console.ReadLine());

                while (productoAvender != 1 && productoAvender != 2 && productoAvender != 3 && productoAvender != 4 && productoAvender != 0000)
                {
                    Console.WriteLine("ERROR.¿Que producto desea vender: 1, 2, 3 o 4?");
                    productoAvender = int.Parse(Console.ReadLine());
                }

                if (productoAvender != 0000)
                {
                    Console.WriteLine("ingrese el importe del producto");
                    importeDelProducto = int.Parse(Console.ReadLine());
                }

             


                switch (productoAvender)
                {
                    case 1:
                        producto1[contador] += importeDelProducto;
                        importePorVenta[contador] += importeDelProducto;
                        sumaDeImportes[0] += importeDelProducto;
                        cantidadDeVentasPorProducto[0] += 1;
                        nombreDelProductoDeLaVenta[contador] = "producto 1";
                        contador2++;
                        break;
                    case 2:
                        producto2[contador] += importeDelProducto;
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[1] += 1;
                        sumaDeImportes[1] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 2";
                        contador2++;
                        break;
                    case 3:
                        producto3[contador] += importeDelProducto;
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[2] += 1;
                        sumaDeImportes[2] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 3";
                        contador2++;
                        break;
                    case 4:
                        producto4[contador] += importeDelProducto;
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[3] += 1;
                        sumaDeImportes[3] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 4";
                        contador2++;
                        break;
                    default: break;
                }
                    //contador dos verifica que no se cargue mas de 4 productos por venta
                if(contador2 < 4 && productoAvender != 0000)
                {
                    Console.WriteLine("¿desea seguir cargando productos para la venta? Ingrese si o no");
                    continuar = Console.ReadLine();

                    while (continuar != "no" && continuar != "si")
                    {
                        Console.WriteLine("ERROR.¿desea seguir cargando productos para la venta? ingrese si o no");
                        continuar = Console.ReadLine();
                    }
                    if (continuar == "no")
                    {
                        contador++;
                        contador2 = 0;
                        RecorrerLasVentas(producto1, producto2, producto3, producto4);
                    }
                }
                else 
                {
                    contador++;
                    contador2 = 0;

                    RecorrerLasVentas(producto1, producto2, producto3, producto4);
                }



            } while (productoAvender != 0000 && contador < 30);

            for (int i = 0; i < cantidadDeVentasPorProducto.Length; i++)
            {
                if (cantidadDeVentasDelProductoConMayorVentas < cantidadDeVentasPorProducto[i])
                {
                    cantidadDeVentasDelProductoConMayorVentas = cantidadDeVentasPorProducto[i];
                    nombreDeProductoConMayorVenta = i;
                }


            }

            for (int i = 0; i < sumaDeImportes.Length; i++)
            {
                if (importeDelProductoQueMasDIneroVendio < sumaDeImportes[i])
                {
                    importeDelProductoQueMasDIneroVendio = sumaDeImportes[i];
                    nombreDelProductoQueMasDineroVendio = i;

                }
            }

            Console.WriteLine($"el producto que mas vendio es {productos[nombreDeProductoConMayorVenta]} con {cantidadDeVentasDelProductoConMayorVentas} ventas");
            Console.WriteLine($"el producto que mas dinero vendio es {productos[nombreDelProductoQueMasDineroVendio]} su importe es {importeDelProductoQueMasDIneroVendio}");
        }

      static void RecorrerLasVentas(int[] producto1, int[] producto2, int[] producto3, int[] producto4 )
        {
            for (int i = 0; i < 30; i++)
            {
                if (producto1[i] > 0)
                {
                    Console.WriteLine($"la venta {i + 1} el producto 1 vendio {producto1[i]}");
                }
                if (producto2[i] > 0)
                {
                    Console.WriteLine($"la venta {i + 1} el producto 2 vendio {producto2[i]}");
                }

                if (producto3[i] > 0)
                {
                    Console.WriteLine($"la venta {i + 1} el producto 3 vendio {producto3[i]}");
                }

                if (producto4[i] > 0)
                {
                    Console.WriteLine($"la venta {i + 1} el producto 4 vendio {producto4[i]}");
                }
            }
        }
    }

  }

