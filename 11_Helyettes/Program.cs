using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Helyettes
{
    class Program
    {
        static List<Felhasznalo> Felhasznalok;

        static Felhasznalo GetFelhasznaloById(int Id)
        {
            //foreach (Felhasznalo felhasznalo in Felhasznalok)
            //{
            //    if (felhasznalo.Id == Id)
            //        return felhasznalo;
            //    return null;
            //}
            return Felhasznalok.Any(f => f.Id == Id) ? Felhasznalok.Where(f => f.Id == Id).First() : null;
        }

        static Felhasznalo GetActiveFelhasznaloById(int Id)
        {
            Felhasznalo Felhasznalo = GetFelhasznaloById(Id);
            if (Felhasznalo.HelyettesId == 0)
                return Felhasznalo;
            else
                return GetActiveFelhasznaloById(Felhasznalo.HelyettesId);
        }

        static void Main(string[] args)
        {
            Felhasznalok = new List<Felhasznalo>()
            {
                new Felhasznalo(1, "Troll Ede", "troll.ede@uni-eszterhazy.hu", 5),
                new Felhasznalo(2, "Geda Gábor", "geda.gabor@uni-eszterhazy.hu", 3),
                new Felhasznalo(3, "Keresztes Péter", "keresztes.peter@uni-eszterhazy.hu", 4),
                new Felhasznalo(4, "Hogyishívják", "arduino@buliwood.hu", 0),
                new Felhasznalo(5, "Valaki", "valaki@gaymail.com", 2)
            };

            int Id = 1;     //Hogy kinek akarom küldeni
            Felhasznalo Felhasznalo = Felhasznalok[Id - 1];                 //betölti egy példányba a listából a kívánt felhasználót
            Felhasznalo Aktiv = GetActiveFelhasznaloById(Felhasznalo.Id);   //betölti egy példányba, az elérhető felhasználót

            Console.WriteLine("{0} a leveleit a(z) {1} email címre kell küldeni.", Felhasznalo.Nev, Aktiv.Email);
            Console.ReadKey();
        }
    }
}
