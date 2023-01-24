using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Faktorialis
{
    class Program
    {
        static int FuggvenyHivas = 0;
        static int Ertekadas = 0;
        static int NumerikusMuvelet = 0;
        static int LogikaiVizsgalat = 0;
        static int Iteracio = 0;

        static void EroforrasNullaz()
        {
            FuggvenyHivas = 0;
            Ertekadas = 0;
            NumerikusMuvelet = 0;
            LogikaiVizsgalat = 0;
            Iteracio = 0;
        }

        static void EroforrasKiir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.Write("Fgv: {0}, Ert: {1}, Num: {2}, Log: {3}, Iter: {4}\n", FuggvenyHivas, Ertekadas, NumerikusMuvelet, LogikaiVizsgalat, Iteracio);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //FÜGGVÉNY FAKT_I(N: EGÉSZ) : EGÉSZ;
        //    VÁLTOZÓK
        //        I: EGÉSZ
        //        F: EGÉSZ
        //    ALGORITMUS
        //        HA (N = 1) AKKOR
        //            FAKT_I <- 1;
        //        KÜLÖNBEN
        //            F <- 1;
        //            CIKLUS I <- (N..2)
        //                F <- F * I;
        //            CIKLUS_VÉGE;
        //            FAKT_I <- F;
        //        HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static int Fakt_I(int n)
        {
            FuggvenyHivas++;
            LogikaiVizsgalat++;
            if (n == 1)
                return 1;
            else
            {
                Ertekadas++;
                int f = 1;
                Ertekadas++;
                for (int i = n; i >= 2; i--)
                {
                    Iteracio++;
                    LogikaiVizsgalat++;
                    Ertekadas++;
                    NumerikusMuvelet++;

                    Ertekadas++;
                    NumerikusMuvelet++;
                    f *= i;
                }
                return f;
            }
        }

        static int Fakt_I_2(int n)
        {
            int f = 1;
            for (int i = n; i >= 1; i--)
                f *= i;
            return f;
        }

        //FÜGGVÉNY  FAKT_R(N: EGÉSZ) : EGÉSZ;
        //    HA (N = 1) AKKOR
        //        FAKT_R <- 1;
        //    KÜLÖNBEN
        //        FAKT_R <- N * FAKT_R(N - 1);
        //    HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static int Fakt_R(int n)
        {
            FuggvenyHivas++;
            LogikaiVizsgalat++;
            if (n == 1)
                return 1;
            else
            {
                NumerikusMuvelet += 2;
                FuggvenyHivas++;
                return n * Fakt_R(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriális iteratívan:");
            for (int i = 1; i <= 15; i++)
            {
                EroforrasNullaz();
                Console.Write("{0}! = {1}", i, Fakt_I(i));
                EroforrasKiir();
            }
            Console.WriteLine("\nFaktoriális rekurzívan:");
            for (int i = 1; i <= 15; i++)
            {
                EroforrasNullaz();
                Console.Write("{0}! = {1}", i, Fakt_R(i));
                EroforrasKiir();
            }

            Console.ReadKey();
        }
    }
}
