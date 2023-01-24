using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Szo_Megfordito
{
    class Program
    {
        static string SzoMegfordito_I(string be)
        {
            if (be.Length <= 1)
                return be;
            else
            {
                char[] be_char = be.ToCharArray();
                string ki = string.Empty;

                for (int i = be_char.Length - 1; i > -1; i--)
                {
                    ki += be_char[i];
                }
                return ki;
            }
        }

        static string SzoMegfordito_R(string be)
        {
            if (be.Length <= 1)
                return be;
            else
            {
                //return be[be.Length - 1] + SzoMegfordito_R(be.Substring(0, be.Length - 1));       //netes metódus
                return SzoMegfordito_R(be.Substring(1, be.Length - 1)) + be[0];                     //órai metódus
            }
        }

        static void Main(string[] args)
        {
            string megforditando = "DOBOZI";
            string megforditott_i = SzoMegfordito_I(megforditando);
            string megforditott_r = SzoMegfordito_R(megforditando);
            Console.WriteLine("Megfordítandó szó: {0}", megforditando);
            Console.WriteLine();
            Console.WriteLine("Iteratívan:");
            Console.WriteLine("Megfordított  szó: {0}", megforditott_i);
            Console.WriteLine();
            Console.WriteLine("Rekurzívan:");
            Console.WriteLine("Megfordított  szó: {0}", megforditott_r);

            Console.ReadKey();
        }
    }
}
