using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Lancolt_Lista_Ketiranyu_Strazsas
{
    class List<T>
    {
        public List()
        {
            Start = new Node<T>();
            End = new Node<T>();
            Start.Prev = null;
            Start.Next = End;
            End.Prev = Start;
            End.Next = null;

            Count = 0;
        }

        public int Count { get; private set; }
        private Node<T> Start;
        private Node<T> End;

        private Node<T> GetNodeByIndex(int Index)
        {
            if (Index < -1 || Index > Count)
                throw new IndexOutOfRangeException();

            if (Index == -1)
                return Start;

            else if (Index == Count)
                return End;

            else
            {
                Node<T> Temp = Start;
                for (int i = 0; i <= Index; i++)
                    Temp = Temp.Next;
                return Temp;
            }
        }

        //ADD
        public void Add(T Value)
        {
            Node<T> NewNode = new Node<T>();
            NewNode.Value = Value;

            NewNode.Next = End;
            End.Prev = NewNode;

            Node<T> Prev = GetNodeByIndex(Count - 1);
            Prev.Next = NewNode;
            NewNode.Prev = Prev;

            Count++;
        }

        //INSERT
        public void Insert(int Index, T Value)
        {
            if (Index < 0 || Index > Count)
                throw new IndexOutOfRangeException();

            if (Index == Count)
                Add(Value);
            else
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Value = Value;

                Node<T> NextNode = GetNodeByIndex(Index);
                NewNode.Next = NextNode;
                NextNode.Prev = NewNode;

                Node<T> Prev = GetNodeByIndex(Index - 1);
                Prev.Next = NewNode;
                NewNode.Prev = Prev;

                Count++;
            }
        }

        //REMOVEAT
        public void RemoveAt(int Index)
        {
            if (Index < 0 || Index >= Count)
                throw new IndexOutOfRangeException();

            if (Index == 0)
            {
                Node<T> NextNode = GetNodeByIndex(Index + 1);
                
                Start.Next = NextNode;
                NextNode.Prev = Start;
            }
            else if (Index == Count - 1)
            {                
                Node<T> Prev = GetNodeByIndex(Index - 1);
                Prev.Next = End;
                End.Prev = Prev;
            }
            else
            {
                Node<T> NextNode = GetNodeByIndex(Index + 1);
                Node<T> Prev = GetNodeByIndex(Index - 1);

                NextNode.Prev = Prev;
                Prev.Next = NextNode;
            }
            Count--;
        }

        //REMOVE
        public void Remove(T Content)
        {
            int SizeAtStart = Count;
            Node<T> Temp = Start;
            int Index = - 1;
            do
            {
                if (Temp.Value.Equals(Content))
                    RemoveAt(Index);
                Temp = Temp.Next;
                Index++;
            }
            while (Temp != End);
            if (SizeAtStart == Count)
                throw new Exception("Az elemet nem tartalmazza a lista!");
        }

        //CONTAINS
        public bool Contains(T Content)
        {
            Node<T> Temp = Start;
            do
            {
                if (Temp.Value.Equals(Content))
                    return true;
                Temp = Temp.Next;
            }
            while (Temp != End);

            return false;
        }

        //INDEXER
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                return GetNodeByIndex(index).Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                GetNodeByIndex(index).Value = value;
            }
        }

        public System.Collections.IEnumerable ForEach()
        {
            Node<T> Temp = Start.Next;
            while (Temp != End)
            {
                yield return Temp.Value;
                Temp = Temp.Next;
            }
        }

        public System.Collections.IEnumerable ForEachBackward()
        {
            Node<T> Temp = End.Prev;
            while (Temp != Start)
            {
                yield return Temp.Value;
                Temp = Temp.Prev;
            }
        }
    }
}
