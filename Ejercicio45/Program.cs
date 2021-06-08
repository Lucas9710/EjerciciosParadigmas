/*.Una agencia de autos nos pide confeccionar un programa que permita informar el estado de las 
  ventas de la agencia por modelo de auto. Se nos provee la siguiente información:
• Los modelos de autos están codificados numéricamente de 1 a 49.
• Las descripciones de los modelos de los autos son cargados manualmente por un usuario.
• Cada venta se registra con código de modelo, y el importe vendido. Las ventas no se realizan 
ordenadamente, ni tienen determinada su finalización de carga de forma preestablecida
Al final de del día se necesita contar con:
Listado de las ventas totales registradas por cada modelo de auto, este listado debe mostrar el 
código del modelo, Su descripción y el importe total vendido DEBE MOSTRAR SOLO LOS MODELOS QUE HAYAN
REGISTRADO VENTAS. Incluyendo el encabezado de títulos tal como se muestra a continuación
Modelo que registro la mayor venta unitaria. Se debe visualizar con leyenda “el modelo que registro 
la mejor venta fue <<modelo>> por <<importe>> pesos.” .
Tomando el ejemplo suministrado debería visualizarse:
El modelo que registró la mejor venta fue: Mondeo por 280000 pesos.
*/
using System;

namespace Ejercicio45
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] descripcionModelos = new string[49];
            int modelo = 0;
            int[] importe = new int[49];
            int[] totalVendido = new int[49];
            string continuar = "";
            int mejorVenta = 0;
          


            do
            {
                Console.WriteLine("ingrese el modelo del auto 1 - 49");
                modelo = int.Parse(Console.ReadLine());
               
               
                Console.WriteLine("ingrese la descripcion del modelo");
                descripcionModelos[modelo - 1] = Console.ReadLine();

              
                totalVendido[modelo - 1] += 1;

                Console.WriteLine("ingrese el precio");
                importe[modelo - 1] = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Desea continuar cargando ventas? \nescriba si o no");
                continuar = Console.ReadLine();

                while (continuar != "si" && continuar != "no")
                {
                    Console.WriteLine("ERROR. ¿Desea continuar cargando ventas? escriba si o no");
                    continuar = Console.ReadLine();
                }

            } while (continuar == "si");
          


            for (int i = 0; i < totalVendido.Length; i++)
            {

                if (mejorVenta < importe[i])
                {
                    mejorVenta = importe[i];
                    Console.WriteLine($"el modelo que registro la mejor venta fue  {descripcionModelos[i]}  por   {importe[i]} pesos");
                }

                if (totalVendido[i] > 0)
                {
                    Console.WriteLine($"el estado de las ventas es modelo { i + 1}  descripcion   {descripcionModelos[i]}  importe  {importe[i] * totalVendido[i]}   pesos");
                }



            }



        }
    }
}
