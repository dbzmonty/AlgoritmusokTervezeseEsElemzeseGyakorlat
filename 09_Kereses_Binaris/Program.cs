using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Kereses_Binaris
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

        static int Kereses_Binaris(List<int> a, int elso, int utolso, int keresett)
        {
            int kozepso = (elso + utolso) / 2;
            if (a[kozepso] == keresett)
                return kozepso;
            else if (elso >= utolso)
                return -1;
            else if (keresett < a[kozepso])
                return Kereses_Binaris(a, elso, kozepso -1, keresett);
            else
                return Kereses_Binaris(a, kozepso +1, utolso, keresett);       
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 3, 5, 9, 12, 23 };
            Console.WriteLine("A lista:");
            ListaKiir(a);

            int elso = 0;            
            int utolso = a.Count - 1;
            int keresett = 23;

            Console.WriteLine("A keresett szám: {0}", keresett);
            Console.WriteLine("Az indexe: {0}", Kereses_Binaris(a, elso, utolso, keresett));

            Console.ReadKey();
        }
    }
}
