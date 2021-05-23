/*21. Se conoce la cantidad total de preguntas realizadas y la cantidad de respuestas correctas
 de un test de nivel par ingresantes a la universidad. Se pide informar el porcentaje de respuestas 
 correctas y una leyenda que indique el nivel obtenido según el siguiente criterio:
a. Nivel 1 → Porcentaje >=89%
b. Nivel 2 → 75<=Porcentaje<89
c. Nivel 3 → 50<=Porcentaje<70
d. Nivel 4 → Porcentaje<50
¿Qué error tiene este algoritmo.?
El error que tiene el algoritmo es que no hay ningun nivel asignado para los porcentajes del 70% al 74%
*/

using System;

namespace Ejercicio21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int porcentaje = 0;

            Console.WriteLine("ingrese el porcentaje de preguntas correctas");
            porcentaje = int.Parse(Console.ReadLine());


            if(porcentaje >= 89)
            {
                Console.WriteLine("el porcentaje es " + porcentaje +" y el nivel es nivel 1");
            }

            if(porcentaje >= 75 && porcentaje < 89)
            {
                Console.WriteLine("el porcentaje es " + porcentaje + " y el nivel es nivel 2");
            }

            if(porcentaje >= 50 && porcentaje < 70)
            {
                Console.WriteLine("el porcentaje es " + porcentaje + " y el nivel es nivel 3");
            }

            if(porcentaje < 50)
            {
                Console.WriteLine("el porcentaje es " + porcentaje + " y el nivel es nivel 4");
            }
        }
    }
}

