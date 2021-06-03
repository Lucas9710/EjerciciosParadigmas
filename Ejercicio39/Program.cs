/*39. Una institución educativa necesita evaluar la evolución de 5 materias correspondientes a primer,
 segundo y tercer año de carrera. (1. Matemática, 2. Lengua, 3 Historia, 4 Geografía, 5 Tecnología
Para realizar esta tarea se dispone de un listado, ordenado por Número de curso y Código de materia 
que contiene la siguiente información:
• Número de curso (valores de 1 a 3)
• Código de Materia (valores de 1 a 5)
• Nota del Examen final de cada alumno
Se pide informar:
• Por cada materia se pide saber el promedio de nota de todo el curso
• La cantidad de alumnos aprobados
• La cantidad de alumnos desaprobados aprobados
• La materia con mayor índice de aprobación
• La materia con menor índice de aprobación
*/
using System;

namespace Ejercicio39
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroDeCurso = 0;
            int codigoDeMateria = 0;
            int notaDeExamenFinal = 0;
            int numeroDeCUrsoAnterior = 0;
            int codigoDeMateriaAnterior = 0;
            int contadorAprobados = 0;
            int contadorDesaprobados = 0;
            int materiaConMayorAprobacion = 0;
            int materiaConMayorDesaprobacion = 0;
            double promedio = 0;
            int acumuladorDeNotas = 0;
            int acumuladorDeNotasPorMateria = 0;
            int acumuladorDeNotasPorMateriaDesaprobadas = 0;
            int codigoDeMateriaConMayorAprobacion = 0;
            int codigoDeMateriaConMenorAprobacion = 0;
            int contadorDeAprobadosPorMateria = 0;
            int contadorDeDesaprobadosPorMateria = 0;


            Console.WriteLine("ingrese el numero del curso");
            numeroDeCurso = int.Parse(Console.ReadLine());

            while (numeroDeCurso >= 1 && numeroDeCurso <= 3) 
            {


                numeroDeCUrsoAnterior = numeroDeCurso;

                while (numeroDeCurso >= 1 && numeroDeCurso <= 3 && numeroDeCurso == numeroDeCUrsoAnterior)
                {
                    Console.WriteLine("ingrese el codigo de la materia");
                    codigoDeMateria = int.Parse(Console.ReadLine());
                    codigoDeMateriaAnterior = codigoDeMateria;

                    while ((numeroDeCurso >= 1 || numeroDeCurso <= 3) && numeroDeCurso == numeroDeCUrsoAnterior && codigoDeMateria == codigoDeMateriaAnterior)
                    {
                        Console.WriteLine("ingrese la nota del alumno");
                        notaDeExamenFinal = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese el numero del curso");
                        numeroDeCurso = int.Parse(Console.ReadLine());

                        if (numeroDeCurso != 0)
                        {
                            Console.WriteLine("ingrese el codigo de la materia");
                            codigoDeMateria = int.Parse(Console.ReadLine());
                        }

                        if (notaDeExamenFinal >= 6)
                        {
                            contadorAprobados++;
                            contadorDeAprobadosPorMateria++;
                            acumuladorDeNotasPorMateria += notaDeExamenFinal;
                            acumuladorDeNotas += notaDeExamenFinal;

                        }

                        if (notaDeExamenFinal < 6)
                        {
                            contadorDesaprobados++;
                            contadorDeDesaprobadosPorMateria++;
                            acumuladorDeNotas += notaDeExamenFinal;
                            acumuladorDeNotasPorMateriaDesaprobadas += notaDeExamenFinal;
                        }

                       
                    }

                    if(acumuladorDeNotasPorMateria > materiaConMayorAprobacion)
                    {
                        materiaConMayorAprobacion = acumuladorDeNotasPorMateria;
                        codigoDeMateriaConMayorAprobacion = codigoDeMateriaAnterior;

                    }

                    if( acumuladorDeNotasPorMateriaDesaprobadas > materiaConMayorDesaprobacion)
                    {
                        acumuladorDeNotasPorMateriaDesaprobadas = materiaConMayorDesaprobacion;
                        codigoDeMateriaConMenorAprobacion = codigoDeMateriaAnterior;

                    }


                }
                promedio = acumuladorDeNotas / (contadorDeAprobadosPorMateria + contadorDeDesaprobadosPorMateria);

                Console.WriteLine("El promedio de la materia " + codigoDeMateriaAnterior + " del curso " + numeroDeCUrsoAnterior + " es " + promedio);

                acumuladorDeNotas = 0;
                promedio = 0;
                contadorDeAprobadosPorMateria = 0;
                contadorDeDesaprobadosPorMateria = 0;

            } 

            Console.WriteLine("la cantidad de alumnos aprobados es " + contadorAprobados);
            Console.WriteLine("la cantidad de alumnos desaaprobados es " + contadorDesaprobados);
            Console.WriteLine("la materia " + codigoDeMateriaConMayorAprobacion + " tiene el mayor indice de aprobacion");
            Console.WriteLine("la materia " + codigoDeMateriaConMenorAprobacion + " tiene el menor indice de aprobacion");
        }
    }
}