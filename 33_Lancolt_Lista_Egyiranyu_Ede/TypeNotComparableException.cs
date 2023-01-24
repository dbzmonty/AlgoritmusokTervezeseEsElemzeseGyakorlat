using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Lancolt_Lista_Egyiranyu_Ede
{
    class TypeNotComparableException : Exception
    {
        public TypeNotComparableException(Type T)
            : base(string.Format("The type {0} is not IComparable", T))
        {

        }
    }
}
