using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Kereses_Linearis
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

        static int Kereses_Linearis(List<int> a, int n, int keresett)
        {
            if (n <= 0)
                return -1;
            else if (a[n - 1] == keresett)
                return n - 1;
            else
                return Kereses_Linearis(a, n - 1, keresett);
        }
        
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 3, 5, 9, 12, 23 };
            Console.WriteLine("A lista:");
            ListaKiir(a);
            
            int keresett = 23;

            Console.WriteLine("A keresett szám: {0}", keresett);
            Console.WriteLine("Az indexe: {0}", Kereses_Linearis(a, a.Count, keresett));

            Console.ReadKey();
        }
    }
}
