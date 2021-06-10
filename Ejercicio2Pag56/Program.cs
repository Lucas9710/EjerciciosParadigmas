/*
Un comerciante tiene la venta de 4 tipos de productos principales. Se realizan a lo sumo 30 ventas
por día de cualquier producto de los ofrecidos. Se conoce el precio de venta unitario de cada uno
de los productos.Hacer un programa que determine cuál fue el producto que realizó el mayor aporte 
de dinero (el que más dinero vendió), cual fue el más vendido y la cantidad total de productos 
vendidos.Solo se puede vender de un producto a la vez.
(cierra el día cuando digita 0000 como producto a vender o cuando vende la unidad número 30)
Informar de manera ordenada la progresión de la venta de cada uno de los cuatro productos mostrando en
pantalla la siguiente información.*/
using System;

namespace Ejercicio2Pag56
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] productos = { "producto 1", "producto 2", "producto 3", "producto 4" };
            int[] sumaDeImportes = new int[4];
            int[] cantidadDeVentasPorProducto = new int[4];
            int[] importePorVenta = new int[30];
            string[] nombreDelProductoDeLaVenta = new string[30];
            int productoAvender = 0;
            int contador = 0;
            int cantidadDeVentasDelProductoConMayorVentas = 0;
            int productoQueMasDIneroVendio = 0;
            int nombreDeProductoConMayorVenta = 0;
            int nombreDelProductoQueMasDineroVendio = 0;
            int importeDelProducto = 0;

            do
            {

                Console.WriteLine("¿Que producto desea vender: 1, 2, 3 o 4?");
                productoAvender = int.Parse(Console.ReadLine());
                while(productoAvender != 1 && productoAvender != 2 && productoAvender != 3 && productoAvender != 4 && productoAvender != 0000)
                {
                    Console.WriteLine("ERROR.¿Que producto desea vender: 1, 2, 3 o 4?");
                    productoAvender = int.Parse(Console.ReadLine());
                }

                if(productoAvender != 0000)
                {
                    Console.WriteLine("ingrese el importe del producto");
                    importeDelProducto = int.Parse(Console.ReadLine());
                }
               

                switch (productoAvender)
                {
                    case 1: 
                        importePorVenta[contador] += importeDelProducto;
                        sumaDeImportes[0] += importeDelProducto;
                        cantidadDeVentasPorProducto[0] += 1;
                        nombreDelProductoDeLaVenta[contador] = "producto 1";
                        break;
                    case 2:
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[1] += 1;
                        sumaDeImportes[1] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 2";
                        break;
                    case 3:
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[2] += 1;
                        sumaDeImportes[2] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 3";
                        break;
                    case 4:
                        importePorVenta[contador] += importeDelProducto;
                        cantidadDeVentasPorProducto[3] += 1;
                        sumaDeImportes[3] += importeDelProducto;
                        nombreDelProductoDeLaVenta[contador] = "producto 4";
                        break;
                    default: break;
                }

                for(int i = 0; i < importePorVenta.Length; i++)
                {
                    if(importePorVenta[i] > 0)
                    {
                        Console.WriteLine($"la venta {i + 1} del dia fue el  {nombreDelProductoDeLaVenta[i]} por el importe {importePorVenta[i]} ");
                    }

                }

                contador++;

            } while (productoAvender != 0000 && contador < 30);

            for(int i = 0; i < cantidadDeVentasPorProducto.Length; i++)
            {
                if(cantidadDeVentasDelProductoConMayorVentas < cantidadDeVentasPorProducto[i])
                {
                    cantidadDeVentasDelProductoConMayorVentas = cantidadDeVentasPorProducto[i];
                    nombreDeProductoConMayorVenta = i;
                }


            }

            for(int i = 0; i < sumaDeImportes.Length; i++)
            {
                if (productoQueMasDIneroVendio < sumaDeImportes[i])
                {
                    productoQueMasDIneroVendio = sumaDeImportes[i];
                    nombreDelProductoQueMasDineroVendio = i;

                }
            }

            Console.WriteLine($"el producto que mas vendio es {productos[nombreDeProductoConMayorVenta]} con {cantidadDeVentasDelProductoConMayorVentas} ventas");
            Console.WriteLine($"el producto que mas dinero vendio es {productos[nombreDelProductoQueMasDineroVendio]} su importe es {productoQueMasDIneroVendio}");
        }
    }
}
