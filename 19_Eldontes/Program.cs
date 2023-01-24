using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Eldontes
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

        static bool Eldontes(List<int> a, int hossz, int keresett_szam)
        {
            if (hossz < 1)
                return false;
            else
            {
                if (a[hossz - 1] == keresett_szam)
                    return true;
                else
                    return Eldontes(a, hossz - 1, keresett_szam);               
            }
        }
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8, 1, 22, 43, 8, 72, 923, 8, 12 };
            Console.WriteLine("A lista:");
            ListaKiir(a);

            int keresett = 3;
            Console.WriteLine("A keresett szám: {0}", keresett);
            Console.WriteLine();

            if ( Eldontes(a, a.Count, keresett) )
                Console.WriteLine("A listában szerepel a szám!");
            else
                Console.WriteLine("NEM szerepel!");

            Console.ReadKey();
        }
    }
}
