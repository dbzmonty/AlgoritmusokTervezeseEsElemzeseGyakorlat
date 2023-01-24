using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Rekurziv_Osszeadas
{
    class Program
    {
        static int RekurzivOsszeadas(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return a + RekurzivOsszeadas(1, b - 1);
        }

        static void Main(string[] args)
        {
            int a = 13;
            int b = 10;
            int result = RekurzivOsszeadas(a, b);

            Console.WriteLine("{0} és {1} összege: {2}", a, b, result);

            Console.ReadKey();
        }
    }
}
