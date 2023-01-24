using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Binaris_Fa_2
{
    class BinaryTree
    {
        private Node _root;
        
        public BinaryTree()
        {
            _root = null;
        }

        public void Insert(int Data)
        {
            if (_root == null)
            {
                _root = new Node(Data);
                return;
            }

            InsertRec(_root, new Node(Data));
        }

        private void InsertRec(Node Root, Node newNode)
        {
            if (Root == null)
                Root = newNode;

            if (newNode.Data < Root.Data)
            {
                if (Root.Left == null)
                    Root.Left = newNode;
                else
                    InsertRec(Root.Left, newNode);
            }

            else
            {
                if (Root.Right == null)
                    Root.Right = newNode;
                else
                    InsertRec(Root.Right, newNode);
            }
        }

        public void DisplayTree(Node Root)
        {
            if (Root == null)
                return;

            DisplayTree(Root.Left);
            Console.Write(Root.Data + " ");
            DisplayTree(Root.Right);
        }

        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
