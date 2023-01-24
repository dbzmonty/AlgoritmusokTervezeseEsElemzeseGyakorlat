using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Fibonacci
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

        //FÜGGVÉNY FIB_I(N: EGÉSZ) : EGÉSZ;
        //    VÁLTOZÓK
        //        F: EGÉSZ;
        //        F1: EGÉSZ;
        //        F2: EGÉSZ;
        //        I: EGÉSZ;
        //    ALGORITMUS
        //        F1 <- 1;
        //        F2 <- 1;
        //        F <- 1;
        //        CIKLUS I <- (3..N)
        //            F <- F1 + F2;
        //            F1 <- F2;
        //            F2 <- F;
        //        CIKLUS_VÉGE;
        //        FIB_I <- F;
        //FÜGGVÉNY_VÉGE;

        static int Fib_I(int n)
        {
            FuggvenyHivas++;
            int f1 = 1;
            int f2 = 1;
            int f = 1;
            Ertekadas += 3;
            Ertekadas++;
            for (int i = 3; i <= n; i++)
            {
                Iteracio++;
                LogikaiVizsgalat++;
                Ertekadas++;
                NumerikusMuvelet++;

                f = f1 + f2;
                f1 = f2;
                f2 = f;
                Ertekadas += 3;
                NumerikusMuvelet++;
            }
            return f;
        }

        //FÜGGVÉNY FIB_R(N: EGÉSZ) : EGÉSZ;
        //    HA (N = 1 VAGY N = 2) AKKOR
        //        FIB_R <- 1;
        //    KÜLÖNBEN
        //        FIB_R <- FIB_R(N - 1) + FIB_R(N - 2);
        //    HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static int Fib_R(int n)
        {
            FuggvenyHivas++;
            LogikaiVizsgalat++;
            if (n == 1 || n == 2)
                return 1;
            else
            {
                NumerikusMuvelet++;
                return Fib_R(n - 1) + Fib_R(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci iteratívan:");
            for (int i = 1; i <= 15; i++)
            {
                EroforrasNullaz();
                Console.Write("f_{0} = {1}", i, Fib_I(i));
                EroforrasKiir();
            }
            Console.WriteLine("\nFibonacci rekurzívan:");
            for (int i = 1; i <= 15; i++)
            {
                EroforrasNullaz();
                Console.Write("f_{0} = {1}", i, Fib_R(i));
                EroforrasKiir();
            }

            Console.ReadKey();
        }
    }
}
