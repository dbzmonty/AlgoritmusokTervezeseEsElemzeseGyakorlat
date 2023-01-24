using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Lancolt_Lista_Egyiranyu
{
    class Program
    {
        static void ListaKiir(List<int> a)
        {
            for (int i = 0; i < a.count; i++)
            {
                if (i == a.count - 1)
                    Console.WriteLine(a[i]);
                else
                    Console.Write(a[i] + ", ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(10);
            lista.Add(12);
            lista.Add(7);
            lista.Add(8);
            ListaKiir(lista);

            lista.Insert(1, 99);
            ListaKiir(lista);

            lista.RemoveAt(1);
            ListaKiir(lista);

            lista.Remove(10);
            ListaKiir(lista);

            Console.WriteLine(lista.Contains(12));
            Console.WriteLine(lista.Contains(10));

            Console.ReadKey();
        }
    }
}
