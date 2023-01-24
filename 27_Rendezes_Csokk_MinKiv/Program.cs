using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Rendezes_Csokk_MinKiv
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

        static void Rend_Min_Csokk(List<int> a)
        {
            if (a.Count > 1)
            {
                int min = a.Min();
                a.Remove(min);
                Rend_Min_Csokk(a);
                a.Add(min);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_Min_Csokk(a);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
