/*Escribir un método, copiarPila(), que copie el contenido de una pila en otra. El método tendrá dos
 argumentos de tipo pila, uno para la pila fuente y otro para la pila destino. Utilizar las operacio-
 -nes definidas sobre el TAD Pila.*/
using System;

namespace Ejercicio47
{
    class Pila
    {
        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            Pila pila2 = new Pila();
            pila1.Push(10);
            pila1.Push(40);
            pila1.Push(30);
            Console.WriteLine("la pila 1 tiene los siguente elementos" );
            pila1.Imprimir();
            Console.WriteLine("cortando los elementos de la pila 1 y pegandolos en la pila 2");
            QuitarPila(pila1, pila2);
            Console.WriteLine("la pila uno tiene los siguente elementos");
            pila1.Imprimir();
            Console.WriteLine("la pila 2 tiene los siguente elementos");
            pila2.Imprimir();


            Console.ReadKey();
        }

        static Pila QuitarPila(Pila pila1, Pila pila2)
        {

            int largo = pila1.Count();
            for (int i = 0; i < largo; i++)
            {
                int elemento = pila1.Pop();
                pila2.Push(elemento);
            }


            return pila2;

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






