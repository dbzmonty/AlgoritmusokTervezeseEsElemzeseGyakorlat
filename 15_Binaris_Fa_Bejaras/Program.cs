using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Binaris_Fa_Bejaras
{
    class Program
    {
        static void PreOrder(Node Start)
        {
            Console.Write(Start);
            if (Start.Left != null)
            {
                PreOrder(Start.Left);
            }
            if (Start.Right != null)
            {
                PreOrder(Start.Right);
            }
        }

        static void InOrder(Node Start)
        {
            if (Start.Left != null)
            {
                InOrder(Start.Left);
            }
            Console.Write(Start);
            if (Start.Right != null)
            {
                InOrder(Start.Right);
            }
        }

        static void PostOrder(Node Start)
        {
            if (Start.Left != null)
            {
                PostOrder(Start.Left);
            }
            if (Start.Right != null)
            {
                PostOrder(Start.Right);
            }
            Console.Write(Start);
        }

        static void Main(string[] args)
        {
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node plus = new Node("+", a, b);
            Node minus = new Node("-", c, d);
            Node star = new Node("*", plus, minus);

            Console.WriteLine("PreOrder "); PreOrder(star);
            Console.WriteLine("\n\nInOrder "); InOrder(star);
            Console.WriteLine("\n\nPostOrder "); PostOrder(star);

            Console.ReadKey();
        }
    }
}
