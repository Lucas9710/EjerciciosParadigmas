using System;
/*19. Se leen tres datos que representan el apellido, sueldo básico y antigüedad de un empleado. 
 Se debe informar el nombre y el sueldo a cobrar. El sueldo se calcula adicionando al sueldo básico 
 el 40% del mismo si la antigüedad supera los 9 años.
*/
namespace Ejercicio19
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string apellido = "";
            int sueldoBasico = 0;
            int antiguedad = 0;
            int sueldoTotal = 0;

            Console.WriteLine("ingrese apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("ingrese sueldo");
            sueldoBasico = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese antiguedad");
            antiguedad = int.Parse(Console.ReadLine());

            if(antiguedad > 9)
            {
                sueldoTotal = sueldoBasico + (sueldoBasico * 40 / 100);
                Console.WriteLine("el sueldo de " + apellido + " es " + sueldoTotal);
            }
            else
            {
                Console.WriteLine("el sueldo de " + apellido + " es " + sueldoBasico);
            }


        }
    }
}
