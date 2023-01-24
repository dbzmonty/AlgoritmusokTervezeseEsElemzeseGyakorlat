using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Lancolt_Lista_Egyiranyu_Ede
{
    class Program
    {
        //static void ListaKiir(List<int> a)
        //{
        //    for (int i = 0; i < a.Count; i++)
        //    {
        //        if (i == a.Count - 1)
        //            Console.WriteLine(a[i]);
        //        else
        //            Console.Write(a[i] + ", ");
        //    }
        //    Console.WriteLine();
        //}

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<Ember> Emberek = new List<Ember>();
            Emberek.Add(new Ember("George Russel", 20));
            Emberek.Add(new Ember("Robert Kubica", 42));
            Emberek.Add(new Ember("Pascal Wehrline", 25));

            Emberek.Insert(1, new Ember("proba a ... indexen", 1));
            Emberek.Remove(new Ember("proba a ... indexen", 1));
            
            for (int i = 0; i < Emberek.Count; i++)
                Console.WriteLine(Emberek[i]);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
