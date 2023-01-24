using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Rendezes_Beszuro
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

        static void Rend_Beszuro(List<int> a, int n)
        {
            if (n > 1)
            {
                Rend_Beszuro(a, n - 1);
                int utolso = a[n - 1];
                int j = n - 2;

                while (j >= 0 && a[j] > utolso)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = utolso;
            }
        }
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_Beszuro(a, a.Count);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
