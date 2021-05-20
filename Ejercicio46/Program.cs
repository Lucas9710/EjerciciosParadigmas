using System;

namespace Ejercicio46
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string[] productos = inicializarArreglos("productos");
            string[] dias = inicializarArreglos("dias");

            double[,] ventas = new double[4, 7];
            int opcionMenu = 0;
            int dia = 0;
            int prod = 0;
            double venta = 0;
            do
            {
                //Console.Clear();
                menu(99);

                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        //Cargar Ventas
                        menu(1);    // dia
                        dia = int.Parse(Console.ReadLine());
                        dia--;

                        menu(2);    // producto
                        prod = int.Parse(Console.ReadLine());
                        prod--;
                        menu(3);    // valor
                        venta = double.Parse(Console.ReadLine());
                        // acumulo en el mismo elemento la venta por si se ha registro otra para el mismo dia-producto
                        ventas[prod, dia] = ventas[prod, dia] + venta;
                        break;
                    case 2:
                        //Listar ventas totales de cada producto
                        menu(4);
                        mostrarMatriz(2, ventas, dias, productos);
                        break;
                    case 3:
                        menu(5);
                        //Listar ventas totales de cada dia de la semana
                        mostrarMatriz(3, ventas, dias, productos);
                        break;
                    case 4:
                        menu(6);

                        ventas = inicializarVentas(4, 7);
                        //Resetear la carga ventas
                        break;
                    case 0:
                        menu(0);
                        // Fin de la carga
                        Console.WriteLine("Fin del programa.");
                        break;
                    default:
                        Console.WriteLine("Ha ingresado una opción incorrecta");
                        break;
                }

            } while (opcionMenu != 0);
        }

        private static void mostrarMatriz(int opcion, double[,] matrizAuxiliarVentas, string[] auxDias, string[] auxProductos)
        {
            Console.Clear();

            double vtaAcumulada = 0;
            if (opcion == 2)
            {
                //Listar ventas totales de cada producto  --> recorro filas y luego columnas
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        vtaAcumulada = vtaAcumulada + matrizAuxiliarVentas[i, j];
                    }
                    Console.WriteLine($"El producto {auxProductos[i]}  tuvo una venta total de {vtaAcumulada}");
                    vtaAcumulada = 0;
                }
            }
            else
            {

                //Listar ventas totales de cada dia de la semana --> Recorro columna fila
                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        vtaAcumulada = vtaAcumulada + matrizAuxiliarVentas[i, j];
                    }
                    Console.WriteLine($"El dia {auxDias[j]} tuvo una venta total de {vtaAcumulada}");
                    vtaAcumulada = 0;
                }

            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void menu(int opcion)
        {
            string textoMenu = "";
            switch (opcion)
            {
                // texto general del menu
                case 99:
                    textoMenu = "1 para cargar las ventas\n2 para listar las ventas totales de cada producto\n3 para listar las ventas totales de cada dia de la semana\n4 para resetar las ventas cargadas\n0 para terminar";
                    break;
                // textos utilizados para la carga de ventas
                case 1:
                    textoMenu = "Ingrese el n° de día [1 para el lunes y 7 para el domingo]";
                    break;
                case 2:
                    textoMenu = "Ingrese el n° de producto [1. Harina 2.Vino 3.Polenta. 4.Arroz]";
                    break;
                case 3:
                    textoMenu = "Ingrese el valor de la venta";
                    break;
                case 4:
                    textoMenu = "Listar ventas totales de producto";
                    break;
                case 5:
                    textoMenu = "Listar ventas totales de cada día de la semana";
                    break;
                case 6:
                    textoMenu = "Resetear la carga de ventas";
                    break;
            }

            Console.WriteLine(textoMenu);
        }
        private static double[,] inicializarVentas(int fila, int columna)
        {
            double[,] matrizAuxiliar = new double[fila, columna];
            // voy a recorrer la matriz por fila y columna

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    // inicializo la matriz en la posición i y columna j con el valor 0;
                    matrizAuxiliar[i, j] = 0;
                }
            }
            return matrizAuxiliar;
        }

        private static string[] inicializarArreglos(string tipo)
        {
            string[] vectorAuxiliar;

            if (tipo.Equals("dias"))
            {
                vectorAuxiliar = new string[] { "lunes", "martes", "miércoles", "jueves", "viernes", "sabado", "domingo" };
            }
            else
            {
                vectorAuxiliar = new string[] { "harina", "vino", "polenta", "arroz" };
            }

            return vectorAuxiliar;
        }
    }
}
