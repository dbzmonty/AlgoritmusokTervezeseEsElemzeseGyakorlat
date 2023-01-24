using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Lista_Nevek
{
    class Program
    {
        //Az a feladatunk, hogy egy múzeum bejáratánál rögzítsük
        //az összes bejövő ember nevét.
        //Probléma, hogy nem tudjuk, mennyien fognak jönni.

        static NevReg Fej = new NevReg();
        static bool Kilepes = false;
        static NevReg GetUtolso(NevReg Temp)
        {
            if (Temp.Kovetkezo == null)
                return Temp;
            else return GetUtolso(Temp.Kovetkezo);
        }
        static void Main(string[] args)
        {

            int Darab = 0;
            do
            {
                Console.Write("Név: ");
                ConsoleKeyInfo CI = Console.ReadKey();
                if (CI.Key == ConsoleKey.Escape)
                    Kilepes = true;
                else
                {
                    if (Darab == 0)
                    {
                        Fej.Nev = CI.KeyChar + Console.ReadLine();
                    }
                    else
                    {
                        NevReg Uj = new NevReg();
                        Uj.Nev = CI.KeyChar + Console.ReadLine();
                        GetUtolso(Fej).Kovetkezo = Uj;
                    }
                    Darab++;
                }
            } while (!Kilepes);

            Console.Clear();
            Console.WriteLine("A regisztrált nevek:");
            NevReg Temp = Fej;
            for (int i = 0; i < Darab; i++)
            {
                Console.WriteLine("{0}. Név: {1}", i + 1, Temp.Nev);
                Temp = Temp.Kovetkezo;
            }

            Console.WriteLine("\nA regisztrált nevek visszafelé:");
            for (int i = Darab; i > 0; i--)
            {
                Temp = Fej;
                for (int j = 0; j < i - 1; j++)
                    Temp = Temp.Kovetkezo;
                Console.WriteLine("{0}. Név: {1}", i, Temp.Nev);
            }

            Console.WriteLine("\nNyomj Enter-t a kilépéshez!");
            Console.ReadLine();
        }
    }
}
