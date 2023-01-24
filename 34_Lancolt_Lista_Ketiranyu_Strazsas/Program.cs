using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Lancolt_Lista_Ketiranyu_Strazsas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Lista.Add(i);
            }
                       

            Lista.Insert(0, 99);

            foreach (var Node in Lista.ForEach())
            {
                Console.WriteLine(Node);
            }

            Console.WriteLine("Mérete: {0}", Lista.Count);

            Lista.Remove(5);

            foreach (var Node in Lista.ForEach())
            {
                Console.WriteLine(Node);
            }

            Console.WriteLine("Mérete: {0}", Lista.Count);
            
            foreach (var Node in Lista.ForEachBackward())
            {
                Console.WriteLine(Node);
            }

            Console.WriteLine("Mérete: {0}", Lista.Count);

            Console.WriteLine(Lista.Contains(5));

            Console.ReadKey();
        }
    }
}
