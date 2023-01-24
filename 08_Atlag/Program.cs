using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Atlag
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

        static double Atlag(List<int> a, int n)
        {
            if (n <= 1)
                return (double)a[0];
            else            
                return ((double)(Atlag(a, n - 1) * (n - 1) + a[n - 1]) / n);
        }
        
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };            
            Console.WriteLine("A lista:");
            ListaKiir(a);

            double atlag = Atlag(a, a.Count);
            Console.WriteLine("Átlag: {0}", atlag);

            Console.ReadKey();
        }
    }
}
