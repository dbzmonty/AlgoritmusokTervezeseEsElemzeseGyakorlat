using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hatvanyozas
{
    class Program
    {
        //FÜGGVÉNY HATV_I(A: VALÓS, N: EGÉSZ) : VALÓS;
        //    VÁLTOZÓK
        //        RESULT : VALÓS;
        //        I: EGÉSZ;
        //    ALGORITMUS
        //        HA (N = 0) AKKOR
        //            HATV_I <- 1;
        //        KÜLÖNBEN 
        //            HA (N = 1) AKKOR
        //                HATV_I <- A;
        //            KÜLÖNBEN
        //                HA (N > 1) AKKOR
        //                    RESULT <- A;
        //                    CIKLUS I <- (2..N)
        //                        RESULT <- RESULT * A;
        //                    CIKLUS_VÉGE;
        //                    HATV_I <- RESULT;
        //                KÜLÖNBEN
        //                    HA (N = -1) AKKOR
        //                        HATV_I <- 1 / A;
        //                    KÜLÖNBEN
        //                        N <- N * -1;
        //                        RESULT <- A;
        //                        CIKLUS I <- (2..N)
        //                            RESULT <- RESULT * A;
        //                        CIKLUS_VÉGE;
        //                        HATV_I <- 1 / RESULT;
        //                    HA_VÉGE;
        //                HA_VÉGE;
        //            HA_VÉGE;
        //        HA_VÉGE;
        //VÜGGVÉNY_VÉGE;

        static float Hatv_I(float a, int n)
        {
            float result;
            if (n == 0)
                return 1;
            else if (n == 1)
                return a;
            else if (n > 1)
            {
                result = a;
                for (int i = 2; i <= n; i++)
                    result *= a;
                return result;
            }
            else
            {
                if (n == -1)
                    return 1 / a;
                else
                {
                    n = n * -1;
                    result = a;
                    for (int i = 2; i <= n; i++)
                        result *= a;
                    return 1 / result;
                }
            }
        }

        //FÜGGVÉNY HATV_R(A: VALÓS, N: EGÉSZ) : VALÓS;
        //    HA (N = 0) AKKOR
        //        HATV_R <- 1;
        //    KÜLÖNBEN
        //        HA (N = 1) AKKOR
        //            HATV_R <- A;
        //        KÜLÖNBEN
        //            HA (N > 1) AKKOR
        //                HATV_R <- A * HATV_R(A, N - 1);
        //            KÜLÖNBEN
        //                HATV_R <- 1 / HATV_R(A, -N);
        //            HA_VÉGE;
        //        HA_VÉGE;
        //    HA_VÉGE;
        //FÜGGVÉNY_VÉGE;

        static float Hatv_R(float a, int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return a;
            else if (n > 1)
                return a * Hatv_R(a, n - 1);
            else
                return 1 / Hatv_R(a, -n);
        }
        static void Main(string[] args)
        {
            float hatvanyozando = 2;
            Console.WriteLine("Iteratívan:");
            for (int i = -5; i < 6; i++)
                Console.WriteLine("{0} a {1}. hatványon {2}", hatvanyozando, i, Hatv_I(hatvanyozando, i));
            Console.WriteLine();
            Console.WriteLine("Rekurzívan");
            for (int i = -5; i < 6; i++)
                Console.WriteLine("{0} a {1}. hatványon {2}", hatvanyozando, i, Hatv_R(hatvanyozando, i));

            Console.ReadKey();
        }
    }
}
