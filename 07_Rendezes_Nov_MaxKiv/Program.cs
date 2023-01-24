using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Rendezes_Nov_MaxKiv
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

        //ELJÁRÁS REND_NÖV_MAX(A: SOROZAT);
        //  VÁLTOZÓK
        //      MAX: ELEMTIPUS;
        //  ALGORITMUS
        //      HA(A.HOSSZ > 1) AKKOR
        //          MAX <- A.MAX();
        //          A.TÖRÖL(MAX);
        //          REND_NÖV_MAX(A);
        //          A.HOZZÁAD(MAX);
        //      HA_VÉGE;
        //ELJÁRÁS_VÉGE;
        
        static void Rend_Max_Nov(List<int> a)
        {
            if (a.Count > 1)
            {
                int max = a.Max();
                a.Remove(max);
                Rend_Max_Nov(a);
                a.Add(max);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8 };
            Console.WriteLine("A rendezetlen lista:");
            ListaKiir(a);

            Rend_Max_Nov(a);
            Console.WriteLine("A rendezett lista:");
            ListaKiir(a);

            Console.ReadKey();
        }
    }
}
