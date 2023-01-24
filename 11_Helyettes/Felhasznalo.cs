using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Helyettes
{
    class Felhasznalo
    {
        public Felhasznalo(int Id, string Nev, string Email, int HelyettesId)
        {
            this.Id = Id;
            this.Nev = Nev;
            this.Email = Email;
            this.HelyettesId = HelyettesId;
        }
        
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Email { get; set; }
        public int HelyettesId { get; set; }        //int? -ben lehet tárolni NULL értéket
    }
}
