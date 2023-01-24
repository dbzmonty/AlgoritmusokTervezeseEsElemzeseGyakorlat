using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Lancolt_Lista_Egyiranyu_Ede
{
    class List<T>
    {
        //VARIABLES
        private Node<T> head;
        private int count { get; set; }

        //CONSTRUCTOR AND SHIT
        public List()
        {
            this.head = new Node<T>();
            this.count = 0;
        }

        private Node<T> GetNodeByIndex(int Index)
        {
            if (Index < 0 || Index >= count)
                throw new IndexOutOfRangeException();

            Node<T> Temp = head;
            for (int i = 0; i < Index; i++)
                Temp = Temp.Next;
            return Temp;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return GetNodeByIndex(index).Value;
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                GetNodeByIndex(index).Value = value;
            }
        }

        //COUNT
        public int Count
        {
            get { return count; }
        }

        //ADD
        public void Add(T Value)
        {
            if (count == 0)
                head.Value = Value;
            else
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Value = Value;
                GetNodeByIndex(count - 1).Next = NewNode;
            }
            count++;
        }

        //INSERT
        public void Insert(int index, T content)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            if (index == count)
                Add(content);
            else
            {
                Node<T> newItem = new Node<T>();
                newItem.Value = content;

                if (index == 0)
                {
                    newItem.Next = head;
                    head = newItem;
                }
                else
                {
                    Node<T> Previous = GetNodeByIndex(index - 1);
                    newItem.Next = Previous.Next;
                    Previous.Next = newItem;
                }
                count++;
            }
        }

        //REMOVEAT
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            if (index == 0)
                head = head.Next;
            else if (index == count - 1)
                GetNodeByIndex(index - 1).Next = null;
            else
                GetNodeByIndex(index - 1).Next = GetNodeByIndex(index + 1);

            count--;
        }

        //REMOVE
        public void Remove(T content)
        {
            Node<T> temp = head;
            int index = 0;
            do
            {
                if (temp.Value.Equals(content))
                    RemoveAt(index);
                temp = temp.Next;
                index++;
            }
            while (temp != null);
        }

        //CONTAINS
        public bool Contains(T content)
        {
            Node<T> temp = head;
            do
            {
                if (temp.Value.Equals(content))
                    return true;
                temp = temp.Next;
            }
            while (temp != null);

            return false;
        }

    }
}
