/*El supermercado Integral no se encuentra informatizado, debido a esto necesita ayuda en la 
 creación de informes de productos y ventas para ayudarlo en la gestión. En relación a esto nos 
 encomendó una tarea que consiste en crear un programa que registre y suministre información sobre
 las ventas realizadas en todas las líneas de caja en un determinado día. Nos suministran un ejemplo 
 del listado de ventas para que nos ayude a desarrollar nuestro programa
 Datos:
•
•
•
El listado de venta no tiene una cantidad prefijada de renglones.
Los productos están codificados del 0 al 999 exclusivamente con valores enteros, por ejemplo..
Todos los productos tienen asociado un valor real y una descripción.

La línea de cajas consta de 25 cajas y se enumeran 1 a la 25.
Se pide:
1. Crear un método llamado inicializarProductos que se encargará de cargar las descripciones de 
productos, y los precios de los mismos.
2. Dadas las ventas registradas determinar el producto que tuvo la mayor facturación, puede haber 
productos que registren la misma facturación, en esos casos informar la descripción los productos 
que coincidieron con la mayor facturación y el importe de la misma.
La leyenda del listado debería indicar lo siguiente Los productos xxxx, xxxx, xxxx registraron la 
mayor facturación por un importe de $xxxx.
Realizarlo a través de un método void llamado mayorFacturacion
3. Cuantas fueron las cajas que no tuvieron ventas .
Realizarlo a través de un método llamado cajasSinVentas.
Este método tiene que devolver un entero XX que represente la cantidad de cajas que no registraron,
desde el programaprincipal se debe utilizar este método y mostrar la leyenda “XX cajas no realizaron ventas”
El programa tiene que tener un menú con las opciones:
Cargar registro de ventas
Informe de mayor facturación.
 */
using System;

namespace ejercicio46
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] codigoDeProducto = new int[10];
            double[] precio = new double[10];
            int[] cajas = new int[10];
            bool[] cajasSeleccionadas = new bool[25];
            int[] cantidadVendida = new int[10];
            string[] descripciones = new string[10];
            int caja = 0;
            int contador = 0;
            double mayorFacturacion = 0;
            int menu = 0;
        
            string nombreDelProductoConMayorFacturacion = "";
            do
            {
                Console.WriteLine("ingrese que quiere hacer \n1 para registrar ventas \n2 Informe de mayor facturacion\n0 para terminar");
                menu = int.Parse(Console.ReadLine());
                while(menu != 0 && menu != 1 && menu != 2)
                {
                    Console.WriteLine("ERROR.ingrese que quiere hacer \n1 para registrar ventas \n2 Informe de mayor facturacion\n0 para terminar");
                    menu = int.Parse(Console.ReadLine());
                }

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ingrese el numero la caja 0 a 25 ");
                        caja = int.Parse(Console.ReadLine());
                        cajasSeleccionadas[caja] = true;

                        while (caja < 0 && caja > 25)
                        {
                            Console.WriteLine("ERROR.ingrese el numero la caja 0 a 25");
                            caja = int.Parse(Console.ReadLine());

                        }


                        if (caja != 0000)
                        {
                            Console.WriteLine("ingrese el codigo del producto");
                            codigoDeProducto[contador] = int.Parse(Console.ReadLine());

                            InicializarProducto(ref descripciones, ref precio, ref contador);

                            Console.WriteLine("ingrese la cantidad vendida");
                            cantidadVendida[contador] = int.Parse(Console.ReadLine());

                            contador++;
                        }



                        if (mayorFacturacion < precio[contador])
                        {
                            mayorFacturacion = precio[contador];
                            nombreDelProductoConMayorFacturacion = descripciones[contador];
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"el producto con mayor facturacion es {nombreDelProductoConMayorFacturacion} vendido a {mayorFacturacion} pesos ");
                        break;
                 
                }


            } while (menu != 0);

            bool mostrarUnaVezSola = false;

            for (int i = 0; i < codigoDeProducto.Length; i++)
            {
              
                if(mostrarUnaVezSola == false)
                {
                    Console.WriteLine("el registro de ventas");
                    mostrarUnaVezSola = true;
                }
               if(codigoDeProducto[i] > 0)
                {
                    Console.WriteLine($"Nombre de la caja {cajas[i]} codigo de producto {codigoDeProducto[i]} cantidad vendida {cantidadVendida[i]} descripcion {descripciones[i]} valor unitario {precio[i]} ");
                }
              
            }

            Console.WriteLine(CajasSinVentas(cajasSeleccionadas) + " cajas no realizaron ventas");
        }

        private static void InicializarProducto(ref string[] descripciones, ref double[] precio, ref int contador)
        {
            Console.WriteLine("ingrese el nombre del producto");
            descripciones[contador] = Console.ReadLine();

            Console.WriteLine("ingrese el precio del producto");
            precio[contador] = double.Parse(Console.ReadLine());

        }

        private static int CajasSinVentas(bool[] cajasSeleccionadas)
        {
            int contador = 0;
            for (int i = 0; i < cajasSeleccionadas.Length; i++)
            {
              if(cajasSeleccionadas[i] == false)
                {
                    contador++;
                }
            }

            return contador;
        }

    }
}
