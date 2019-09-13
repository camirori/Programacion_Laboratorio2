using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej27Guia_Arrays_Colecciones_Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pilas, Colas y Listas.
            Random random = new Random();
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();
            int aleatorio;

            for (int i = 0; i < 20; i++)
            {
                do
                    aleatorio = random.Next(-100, 101);
                while (aleatorio == 0);
                lista.Add(aleatorio);
                pila.Push(aleatorio);
                cola.Enqueue(aleatorio);
            }

            ////////////////////////////////////////
            Console.WriteLine("\nList");
            foreach (int elemento in lista)
            {
                Console.Write("{0} ", elemento);
            }

            Console.WriteLine("\nPositivos");
            lista.Sort(Decreciente);
            foreach (int elemento in lista)
            {
                if (elemento < 0)
                    break;
                Console.Write("{0} ", elemento);
            }
            Console.WriteLine("\nNegativos");
            lista.Sort();
            foreach (int elemento in lista)
            {
                if (elemento > 0)
                    break;
                Console.Write("{0} ", elemento);
            }

            ////////////////////////////////////////////
            Console.WriteLine("\nStack");
            foreach (int elemento in pila)
            {
                Console.Write("{0} ", elemento);
            }
            //no se puede ordenar?

            ///////////////////////////////////////////
            Console.WriteLine("\nQueue");
            foreach (int elemento in cola)
            {
                Console.Write("{0} ", elemento);
            }

            Console.ReadKey();
        }


        public static int Decreciente(int x, int y)
        {
            if (x > y)
                return -1;  //Si es mayor es predecesor
            else if (x < y)
                return 1;
            else
                return 0;
        }
    }
}

