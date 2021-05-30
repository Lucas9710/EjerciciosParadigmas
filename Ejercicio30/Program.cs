/*30. Se leen 300 datos que representan el peso y la edad de los niños atendidos en un hospital, 
 se pide informar el peso promedio según el siguiente rango de edades:
• De 0 a 1 año inclusive / De 1 año a 3 inclusive / De 3 años a 5 inclusive
Las edades de los niños atendidos en el hospital van desde los 0 a los 14 años.
Informar la cantidad total de niños que no fueron contabilizados en el rango de edades.
Informar cuál fue el peso mínimo de todos los niños
Informar cual fue el peso máximo de todos los niños
*/
using System;

namespace Ejercicio30
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int contadorDeDatos = 0;
            int menu = 0;
            int contadorDe0a14Años = 0;
            double peso = 0;
            double acumuladorDePeso = 0;
            double promedio = 0;
            double pesoMaximo = 0;
            double pesoMinimo = 0;
            bool registro = true;

            do
            {
                Console.WriteLine("seleccione la edad del menor \n 1 Para de 0 a 1 \n 2 Para 1 a 3 inclusive \n 3 a 5 años inclusive \n 4 Para los de 6 a 14 años ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ingrese el peso del menor");
                        peso = int.Parse(Console.ReadLine());

                        if (registro == true)
                        {
                            pesoMaximo = peso;
                            pesoMinimo = peso;
                            registro = false;
                        }
                        if (peso > pesoMaximo)
                        {
                            pesoMaximo = peso;
                        }
                        else if (peso < pesoMinimo)
                        {
                            pesoMinimo = peso;
                        }
                        acumuladorDePeso += peso;
                        contadorDeDatos++;

                        break;

                    case 2:
                        Console.WriteLine("ingrese el peso del menor");
                        peso = int.Parse(Console.ReadLine());

                        if (registro == true)
                        {
                            pesoMaximo = peso;
                            pesoMinimo = peso;
                            registro = false;
                        }
                        if (peso > pesoMaximo)
                        {
                            pesoMaximo = peso;
                        }
                        else if (peso < pesoMinimo)
                        {
                            pesoMinimo = peso;
                        }
                        acumuladorDePeso += peso;
                        contadorDeDatos++;

                        break;

                    case 3:
                        Console.WriteLine("ingrese el peso del menor");
                        peso = int.Parse(Console.ReadLine());

                        if (registro == true)
                        {
                            pesoMaximo = peso;
                            pesoMinimo = peso;
                            registro = false;
                        }
                        if (peso > pesoMaximo)
                        {
                            pesoMaximo = peso;
                        }
                        else if (peso < pesoMinimo)
                        {
                            pesoMinimo = peso;
                        }
                        acumuladorDePeso += peso;
                        contadorDeDatos++;

                        break;

                    case 4:
                        Console.WriteLine("ingrese el peso del menor");
                        peso = int.Parse(Console.ReadLine());

                        if (registro == true)
                        {
                            pesoMaximo = peso;
                            pesoMinimo = peso;
                            registro = false;
                        }
                        if (peso > pesoMaximo)
                        {
                            pesoMaximo = peso;
                        }
                        else if (peso < pesoMinimo)
                        {
                            pesoMinimo = peso;
                        }
                        acumuladorDePeso += peso;
                        contadorDeDatos++;
                        contadorDe0a14Años++;

                        break;

                    default:
                        Console.WriteLine("fin de la carga");
                        break;


                }
               
               promedio = acumuladorDePeso / contadorDeDatos;

            } while (contadorDeDatos < 300 && menu != 0);

            Console.WriteLine("el peso maximo de todos los niños es " + pesoMaximo + "kg");
            Console.WriteLine("el peso minimo de todos los niños es " + pesoMinimo + "kg");
            Console.WriteLine("el promedio de peso de todos los niños es " + promedio + "kg");
            Console.WriteLine("la cantidad total de niños que no fueron contabilizados en el rango de edades " + contadorDe0a14Años);

        }
    }
}
