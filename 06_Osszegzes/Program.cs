using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Osszegzes
{
    class Program
    {
        static void ListaKiir(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (i == a.Count -1)
                    Console.WriteLine(a[i]);
                else
                    Console.Write(a[i] + ", ");
            }
            Console.WriteLine();
        }

        //FÜGGVÉNY SUM(A: SOROZAT) : ELEMTÍPUS;
        //    HA (A.HOSSZ = 1) AKKOR
        //        SUM <- A[1];
        //    KÜLÖNBEN
        //        SUM <- A[1] + SUM(A.TÖRÖL(1));
        //    HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static int Sum(List<int> a)
        {
            if (a.Count == 1)
                return a[0];
            else
            {
                List<int> b = new List<int>(a);
                int elso = b[0];
                b.RemoveAt(0);
                return elso + Sum(b);
            }
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 5, 2, 8, 11, 8};
            Console.WriteLine("A lista:");
            ListaKiir(a);
            
            int osszeg = Sum(a);
            Console.WriteLine("Összeg: {0}", osszeg);            

            Console.ReadKey();
        }
    }
}
