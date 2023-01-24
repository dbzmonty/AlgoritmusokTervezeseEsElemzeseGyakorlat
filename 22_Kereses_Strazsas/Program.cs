using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Kereses_Strazsas
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

        static int Kereses_Strazsas(List<int> a, int n, int keresett)
        {
            if (n < 1)
                return -1;
            else
            {
                a.Add(keresett);
                if (a[n - 1] == keresett)
                    return n - 1;
                else
                    return Kereses_Strazsas(a, n - 1, keresett);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 3, 5, 9, 12, 23 };
            Console.WriteLine("A lista:");
            ListaKiir(a);

            int keresett = 1;
            Console.WriteLine("A keresett szám: {0}", keresett);

            int result = Kereses_Strazsas(a, a.Count, keresett);

            if (result == -1)
                Console.WriteLine("A listában NEM szerepel a szám!");
            else
                Console.WriteLine("A listában szerepel a szám, az indexe: {0}", result);
            
            Console.ReadKey();
        }
    }
}
