using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Lancolt_Verem
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
