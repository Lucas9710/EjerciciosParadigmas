/*Dado un listado con los nombres y las 4 notas obtenidas por los alumnos de un curso, calcular 
 e informar el promedio de cada uno y una leyenda que indique si está o no aprobado. 
 No se conoce la cantidad total de alumnos a procesar. De acuerdo a cada versión utilice 
 la estructura de repetición más adecuada.
• Versión con listado de alumnos de 1 a n
• Versión con listado de 50 alumnos
• Versión con listado de 0 o n alumnos
*/
using System;

namespace Ejercicio35
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int version = 0;
            int contador = 0;
            int alumTotv1 = 0;
            int alumTotv3 = 0;
            string alumno = "";
            double nota1 = 1;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            double promedio = 0;

            Console.WriteLine("dependiendo el listado de sus alumnos. ingrese la version correspondiente " +
                "\n version 1: litado de 1 a n alumnos \n version 2 listado de 50 alumnos \n version 3 listo de 0 a n alumnos \n ingrese la version que desee utilizar ");
            version = int.Parse(Console.ReadLine());

            switch(version)
            {
                case 1:  Console.WriteLine("ingrese la cantidad total de alumnos del curso");
                alumTotv1 = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("ingrese el alumno y sus notas para saber si esta aprobado(se aprueba con 4\nIngrese el nombre del alumno");
                    alumno = Console.ReadLine();

                    Console.WriteLine("ingrese la primer nota");
                    nota1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese la primer nota");
                    nota2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese la primer nota");
                    nota3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese la primer nota");
                    nota4 = int.Parse(Console.ReadLine());

                    promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                    if (promedio >= 4)
                    {
                        Console.WriteLine("el alumno " + alumno + " esta aprobado, su nota fue " + promedio);
                    }
                    else
                    {
                        Console.WriteLine("el alumno " + alumno + " esta desaprobado, su nota fue " + promedio);
                    }
                    contador++;
                } while (contador < alumTotv1);
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("ingrese el alumno y sus notas para saber si esta aprobado(se aprueba con 4\nIngrese el nombre del alumno");
                        alumno = Console.ReadLine();

                        Console.WriteLine("ingrese la primer nota");
                        nota1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota4 = int.Parse(Console.ReadLine());

                        promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                        if (promedio >= 4)
                        {
                            Console.WriteLine("el alumno " + alumno + " esta aprobado, su nota fue " + promedio);
                        }
                        else
                        {
                            Console.WriteLine("el alumno " + alumno + "esta desaprobado, su nota fue " + promedio);
                        }
                        contador++;
                    } while (contador < alumTotv1);
                        break;

                case 3:
                    Console.WriteLine("ingrese la cantidad total de alumnos del curso");
                    alumTotv3 = int.Parse(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("ingrese el alumno y sus notas para saber si esta aprobado(se aprueba con 4\nIngrese el nombre del alumno");
                        alumno = Console.ReadLine();

                        Console.WriteLine("ingrese la primer nota");
                        nota1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese la primer nota");
                        nota4 = int.Parse(Console.ReadLine());

                        promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                        if (promedio >= 4)
                        {
                            Console.WriteLine("el alumno" + alumno +" esta aprobado, su nota fue " + promedio);
                        }
                        else
                        {
                            Console.WriteLine("el alumno " + alumno + " esta desaprobado, su nota fue " + promedio);
                        }
                        contador++;
                    } while (contador < alumTotv3);
                    break;

                default: Console.WriteLine("version no valida");
                    break;
            }


        }

    }
}
