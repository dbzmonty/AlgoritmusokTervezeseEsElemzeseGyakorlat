using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Lancolt_Sor
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Sor = new Queue<int>();
            for (int i = 1; i <= 10; i++)
            {
                Sor.Push(i);
            }

            while (Sor.Count != 0)
                Console.WriteLine(Sor.Pop());

            Console.ReadKey();
        }
    }
}
