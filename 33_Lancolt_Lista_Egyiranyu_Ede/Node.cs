using System;
using System.IO;
//using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _33_Lancolt_Lista_Egyiranyu_Ede
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;                
    }
}
