using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Gyakorlas_Egyenletek
{
    class Program
    {
        static double Egyenlet_1(int i)
        {
            if (i == 0)
                return 3;
            else if (i == 1)
                return 4;
            else if (i == 2)
                return 2;
            else
            {
                if (i % 2 != 0)
                    return Egyenlet_1(i - 3) + Math.Pow(Egyenlet_1(i - 2) + Egyenlet_1(i - 1), 2);
                else
                    return Egyenlet_1(i - 3) - Math.Pow(Egyenlet_1(i - 2) - Egyenlet_1(i - 1), 2);
            }
                
        }

        static double Egyenlet_2(int i)
        {
            if (i == 0)
                return 7;
            else if (i == 1)
                return 3;
            else if (i == 2)
                return 5;
            else
            {
                if (i % 2 == 0)
                    return Math.Pow(Math.Pow(Egyenlet_2(i - 3) + Math.Pow(Egyenlet_2(i - 2), 2), 2) + Egyenlet_2(i - 1), 3);
                else
                    return Math.Pow(Math.Pow(Egyenlet_2(i - 3) - Math.Pow(Egyenlet_2(i - 2), 2), 2) - Egyenlet_2(i - 1), 3);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
