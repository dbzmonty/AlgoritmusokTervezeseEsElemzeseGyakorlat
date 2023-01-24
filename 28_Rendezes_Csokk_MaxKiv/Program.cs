using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Rendezes_Csokk_MaxKiv
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
             
        static void Rend_Max_Csokk(List<int> a)
        {
            if (a.Count > 1)
            {
                int max = a.Max();
                a.Remove(max);
                Rend_Max_Csokk(a);
                a.Insert(0, max);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_Max_Csokk(a);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
