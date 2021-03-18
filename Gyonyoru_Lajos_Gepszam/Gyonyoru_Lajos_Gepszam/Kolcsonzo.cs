using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Kolcsonzo
    {
        private int iD;
        private string nev;

        public int ID { get => iD; set => iD = value; }
        public string Nev { get => nev; set => nev = value; }

        public Kolcsonzo(int iD, string nev)
        {
            this.iD = iD;
            this.nev = nev;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
