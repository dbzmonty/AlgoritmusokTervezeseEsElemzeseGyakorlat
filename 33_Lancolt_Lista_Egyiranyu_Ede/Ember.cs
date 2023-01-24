using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Lancolt_Lista_Egyiranyu_Ede
{
    class Ember
    {
        public Ember()
        {

        }

        public Ember(string Nev, int Eletkor)
        {
            this.Nev = Nev;
            this.Eletkor = Eletkor;
        }

        public string Nev { get; set; }
        public int Eletkor { get; set; }

        public override string ToString()
        {
            return string.Format("Név: {0}\nÉletkor: {1} év\n", Nev, Eletkor);
        }

        public int CompareTo(object obj)
        {
            if (this.Eletkor > (obj as Ember).Eletkor)
                return 1;
            else if (this.Eletkor < (obj as Ember).Eletkor)
                return 1;
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            if (((obj as Ember).Nev == this.Nev) && ((obj as Ember).Eletkor == this.Eletkor))
                return true;
            else
                return false;            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
