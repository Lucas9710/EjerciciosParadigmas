/*Escribir un método para determinar si una secuencia de caracteres de entrada es de la forma:
 X & Y siendo X una cadena de caracteres e Y la cadena inversa. El carácter & es el separador.
El siguiente ejemplo corresponde a una cadena inversa correcta Ej: hola&aloh
Esta otra expresión no lo es: hola&ahol*/
using System;

namespace Ejercicio49
{
    class Pila
    {
        public static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            Pila Pila2 = new Pila();
            string cadena1 = "";
           // string cadena2 = "";

            Console.WriteLine("ingrese la primer secuencia de caracteres");
            cadena1 = Console.ReadLine();
            /*
            Console.WriteLine("ingrese la segunda secuencia de caracteres");
            cadena2 = Console.ReadLine();
            */
           

            SecuenciaDeCaracteres(cadena1, pila1, Pila2);
            pila1.Imprimir();
            Pila2.Imprimir();

        }

            static void SecuenciaDeCaracteres(string cadena1, Pila pila1, Pila pila2)
        {
            int cortar = cadena1.Length;
          
            for (int i = 0; i < cortar; i++)
            {
                pila1.Push(cadena1[i]);
               
            }

            for(int i = 0; i < pila1.Count(); i++)
            {
                pila2.Push(pila1.Pop());
            }

            
        }
        class Nodo
        {
            public int data;
            public Nodo siguiente;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Push(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.data = x;
            if (raiz == null)
            {
                nuevo.siguiente = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.siguiente = raiz;
                raiz = nuevo;
            }
        }

        public int Pop()
        {
            if (raiz != null)
            {
                int informacion = raiz.data;
                raiz = raiz.siguiente;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int Count()
        {
            Nodo reco = raiz;
            int cant = 0;
            while (reco != null)
            {
                cant++;
                reco = reco.siguiente;
            }
            return cant;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.Write("[");
            while (reco != null)
            {
                Console.Write(reco.data);
                reco = reco.siguiente;
                if (reco != null)
                    Console.Write(" , ");
            }
            Console.WriteLine("]");
        }
    }
}
