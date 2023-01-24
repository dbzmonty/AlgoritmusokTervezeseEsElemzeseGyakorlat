using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Rekurziv_Szorzas
{
    class Program
    {
        static int RekurzivSzorzas(int a, int b)
        {
            if (b == 0)
                return 0;
            else
                return a + RekurzivSzorzas(a, b - 1);
        }

        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int result = RekurzivSzorzas(a, b);

            Console.WriteLine("{0} és {1} szorzata: {2}", a, b, result);

            Console.ReadKey();
        }
    }
}
