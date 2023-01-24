using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Lancolt_Verem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Verem = new Stack<int>();
            for (int i = 1; i <= 10; i++)
            {
                Verem.Push(i);
            }

            while (Verem.Count != 0)
                Console.WriteLine(Verem.Pop());

            Console.ReadKey();
        }
    }
}
