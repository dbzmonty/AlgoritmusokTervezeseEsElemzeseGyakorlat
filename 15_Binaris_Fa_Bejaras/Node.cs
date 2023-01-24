using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Binaris_Fa_Bejaras
{
    class Node
    {
        public Node() { }
        public Node(string Data) : this()
        {
            this.Data = Data;
        }

        public Node(string Data, Node Left, Node Right) : this(Data)
        {
            this.Left = Left;
            this.Right = Right;
        }

        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return Data;
        }
    }
}
