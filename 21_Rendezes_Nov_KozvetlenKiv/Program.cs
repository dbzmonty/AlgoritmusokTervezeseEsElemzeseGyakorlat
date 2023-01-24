using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Rendezes_Nov_KozvetlenKiv
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

        static void Rend_KozvetlenKiv_Nov(List<int> a, int hossz, int start_index)
        {
            if (hossz > 1 && start_index < hossz)
            {
                for (int i = start_index; i < hossz; i++)
                {
                    if (a[start_index] > a[i])
                    {
                        int temp = a[start_index];
                        a[start_index] = a[i];
                        a[i] = temp;
                    }
                    Rend_KozvetlenKiv_Nov(a, hossz, start_index + 1);
                }
            }
        }
   
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 30, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_KozvetlenKiv_Nov(a, a.Count, 0);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
