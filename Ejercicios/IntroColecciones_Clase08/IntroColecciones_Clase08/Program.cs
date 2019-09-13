using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroColecciones_Clase08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //List<int> lista = new List<int>();
            //Stack<int> pila = new Stack<int>();
            //Queue<int> cola = new Queue<int>();

            //for (int i = 0; i < 5;i++)
            //{
            //    lista.Add(random.Next(1,100));
            //}
            //foreach(int elemento in lista)
            //{
            //    Console.Write("{0} ", elemento);
            //}

            //Console.WriteLine("\nOrdenar");
            //lista.Sort(Class1.Comparar);
            //foreach (int elemento in lista)
            //{
            //    Console.Write("{0} ", elemento);
            //}

            //Console.WriteLine("\nList");
            //foreach (int elemento in lista)
            //{
            //    Console.Write("{0} ", elemento);
            //    pila.Push(elemento);
            //}


            //Console.WriteLine("\nStack");
            //foreach (int elemento in pila)
            //{
            //    Console.Write("{0} ", elemento);
            //    cola.Enqueue(elemento);
            //}

            //Console.WriteLine("\nQueue");
            //foreach (int elemento in cola)
            //{
            //    Console.Write("{0} ", elemento);

            //}


            //Stack<int> pila2 = new Stack<int>();
            //Queue<int> cola2 = new Queue<int>();
            //for (int i=0;i<5;i++)
            //{
            //    pila2.Push(i);
            //    cola2.Enqueue(i);
            //}

            //Console.WriteLine("\nStack2");
            //foreach (int elemento in pila2)
            //{
            //    Console.Write("{0} ", elemento);
            //}

            //Console.WriteLine("\nQueue2");
            //foreach (int elemento in cola2)
            //{
            //    Console.Write("{0} ", elemento);

            //}

            //Diccionarios
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            string[] dni = { "30000000", "30000001", "30000002", "30000003", "30000004" };
            string[] valor = { "Aa", "Bb", "Cc", "Dd", "Ee" };

            for (int i=0;i<5;i++)
            {
                diccionario.Add(dni[i], valor[i]);
            }

            foreach(KeyValuePair<string,string> elemento in diccionario)
            {
                Console.WriteLine("{0}\t{1}", elemento.Key, elemento.Value);
            }




            Console.ReadKey();

        }
    }
}
