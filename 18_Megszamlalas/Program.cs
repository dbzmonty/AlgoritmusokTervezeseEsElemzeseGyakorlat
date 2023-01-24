using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Megszamlalas
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

        static int Megszamlalas(List<int> a, int hossz, int keresett_szam)
        {
            if (hossz < 1)
                return 0;
            else
            {
                int db = 0;
                if (a[hossz - 1] == keresett_szam)
                    db++;
                return db + Megszamlalas(a, hossz - 1, keresett_szam);
            }
        }
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8, 1, 22, 43, 8 , 72, 923, 8, 12};
            Console.WriteLine("A lista:");
            ListaKiir(a);
            
            int keresett = 8;
            Console.WriteLine("A keresett szám: {0}", keresett);
            Console.WriteLine();

            Console.WriteLine("{0} db. van a listában!", Megszamlalas(a, a.Count, keresett));

            Console.ReadKey();
        }
    }
}
