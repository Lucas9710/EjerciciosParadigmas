/*
 * En un curso de ciencias de la computación la calificación final del estudiante se determina a partir del
rendimiento en tres aspectos del trabajo. A) Existe una calificación por los exámenes parciales que representa el
30% del valor total de la nota final. B) la calificación por los trabajos prácticos corresponde al 20% del valor de la
nota final. C) el examen integrador que corresponde al 50% restante. (los valores de las notas pueden ir de 0 a
10)
*/
using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int parcial = 0;
            int tp = 0;
            int integrador = 0;
            int nota = 0;


            Console.WriteLine("ingrese la nota que saco en el parcial");
            parcial = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la nota del tp ");
            tp = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la nota del integrador");
            integrador = int.Parse(Console.ReadLine());

            parcial = 30 * parcial / 100;
            
            tp = 20 * tp / 100;

            integrador = 50 * integrador / 100;

            nota = parcial + tp + integrador;

            Console.WriteLine("la nota final es " + nota);


        }
    }
}
