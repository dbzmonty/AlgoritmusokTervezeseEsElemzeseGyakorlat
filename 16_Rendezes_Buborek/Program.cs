using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Rendezes_Buborek
{
    class Program
    {
        static void ListaKiir(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (i == a.Count - 1)
                    Console.WriteLine(a[i]);
                else
                    Console.Write(a[i] + ", ");
            }
            Console.WriteLine();
        }

        static void Rend_Buborek(List<int> a, int n)
        {
            if (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                Rend_Buborek(a, n - 1);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_Buborek(a, a.Count);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
