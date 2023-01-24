using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Binaris_Fa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree = new BinaryTree();

            Tree.Insert(4);
            Tree.Insert(2);
            Tree.Insert(5);
            Tree.Insert(1);
            Tree.Insert(3);

            Tree.DisplayTree();

            Console.ReadKey();
        }
    }
}
