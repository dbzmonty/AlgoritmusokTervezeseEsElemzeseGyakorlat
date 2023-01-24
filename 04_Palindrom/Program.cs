using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindrom
{
    class Program
    {
        //FÜGGVÉNY PAL_REK(S: SZÖVEG): LOGIKAI;
        //      HA(S.HOSSZ <= 1) AKKOR
        //          PAL_REK <- IGAZ;
        //      KÜLÖNBEN
        //          HA(S[1] <> S[S.HOSSZ] ) AKKOR      ( <> az != )
        //              PAL_REK <- HAMIS;
        //          KÜLÖNBEN
        //              S.TÖRÖL(S[1]);
        //              S.TÖRÖL(S[S.HOSSZ]);
        //              PAL_REK <- PAL_REK(S);
        //          HA_VÉGE;
        //      HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static bool Pal_Rek(string s)
        {
            if (s.Length <= 1)
                return true;
            else if (s[0] != s[s.Length - 1])
                return false;
            else
                return Pal_Rek(s.Substring(1, s.Length - 2));
        }

        static void Main(string[] args)
        {
            string s;
            s = "EDE";
            Console.WriteLine("A(z) {0} {1}palindrom.", s, Pal_Rek(s) ? string.Empty : "nem ");
            s = "Troll";
            Console.WriteLine("A(z) {0} {1}palindrom.", s, Pal_Rek(s) ? string.Empty : "nem ");
            s = "GÉZAKÉKAZÉG";
            Console.WriteLine("A(z) {0} {1}palindrom.", s, Pal_Rek(s) ? string.Empty : "nem ");

            Console.ReadKey();
        }
    }
}
