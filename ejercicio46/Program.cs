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
            bool[] cajas = new bool[25];
            int numeroDeCaja = 0;
            string continuar = "";

            string[] descripciones = new string[25];
            int codigoDeProducto = 0;
            string descripcion = "";
            string precio = "";

           
            do
            {

                Console.WriteLine("ingrese el numero de caja");
                numeroDeCaja = int.Parse(Console.ReadLine());
                cajas[numeroDeCaja - 1] = true;

               
                 Console.WriteLine("ingrese el codigo del producto");
                codigoDeProducto = int.Parse(Console.ReadLine());


                Console.WriteLine("ingrese la descripcion del producto");
                descripcion = Console.ReadLine();

                Console.WriteLine("ingrese el precio");
                precio = Console.ReadLine();

                InicializarProducto(descripcion, precio, codigoDeProducto);

            } while (continuar == "si");
           
            
        }

        private static (String[], String[]) InicializarProducto(string descripcion, string precio, int codigoDeProducto)
        {
            string[] descripciones = new string[25];
            string[] precios = new string[25];

            descripciones[codigoDeProducto - 1] = descripcion;
            precios[codigoDeProducto - 1] = precio;

            return (descripciones, precios);
        

        }

    }
}
