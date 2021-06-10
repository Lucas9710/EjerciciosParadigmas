/*Escribir un programa en el que se manejen un total de n = 3 pilas: P1, P2, P3
La entrada de datos serán pares de enteros (i,j) tal que 1 ≤ abs(i) ≤ n. De tal forma que el 
criterio de selección de pila será:
i.
Si i es positivo, debe insertarse el elemento j en la pila Pi.
ii.
Si i es negativo, debe eliminarse el elemento j de la pila Pi.
iii.
Si i es cero, fin del proceso de entrada.
Los datos de entrada se introducen por teclado. Cuando termina el proceso el programa debe escribir
el contenido de la n Pilas en pantalla.*/
using System;
using System.Collections;
namespace Ejercicio48
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pila3 = new Stack();
            string terminar = "";
            int i = 0;
            int j = 0;

            do
            {
                Console.WriteLine("ingrese el numero i");
                i = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el elemento j");
                j = int.Parse(Console.ReadLine());


                switch (i)
                {
                    case 1:
                        pila1.Push(j);
                        break;
                    case 2:
                        pila2.Push(j);
                        break;
                    case 3:
                        pila3.Push(j);
                        break;
                    case 0:
                        terminar = "si";
                        break;
                   
                }

                if (i < 0)
                {
                    switch (i)
                    {
                        case -1:
                         
                            pila1.Pop();
                            break;
                        case -2:
                            pila2.Pop();
                            break;
                        case -3:
                            pila3.Pop();
                            break;
                       default:
                            Console.WriteLine($"no existe la pila {i}");
                            break;
                    }


                }
            } while (terminar != "si");

            for(int k = 0; k < pila1.Count; k++)
            {
                Console.WriteLine(pila1.Pop());
            }


            for (int k = 0; k < pila2.Count; k++)
            {
                Console.WriteLine(pila2.Pop());
            }

            for (int k = 0; k < pila3.Count; k++)
            {
                Console.WriteLine(pila3.Pop());
            }
        }
    }
}
