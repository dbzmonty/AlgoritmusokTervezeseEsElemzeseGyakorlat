using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Lancolt_Sor
{
    class Queue<T>
    {
        public Queue()
        {
            Head = new Node<T>();
            Count = 0;
        }

        Node<T> Head;
        public int Count { get; private set; }

        private Node<T> GetNodeByIndex(int Index)
        {
            if (Index < -1 || Index >= Count)
                throw new IndexOutOfRangeException();

            if (Index == -1)
                return Head;

            Node<T> Temp = Head;
            for (int i = 0; i < Index; i++)
                Temp = Temp.Next;
            return Temp;
        }

        public void Push(T Value)
        {
            if (Count == 0)
                Head.Value = Value;
            else
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Value = Value;
                GetNodeByIndex(Count - 1).Next = NewNode;
            }
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new Exception("The queue is empty!");

            T Value = Head.Value;
            Node<T> Temp = Head.Next;
            Head.Next = null;
            Head = null;
            Head = Temp;

            Count--;

            return Value;
        }
    }
}
