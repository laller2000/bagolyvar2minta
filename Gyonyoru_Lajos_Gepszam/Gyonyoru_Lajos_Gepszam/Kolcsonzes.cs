using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Kolcsonzes
    {
        private string konyvID;
        private int kolcsonzoID;
        private DateTime kivetelDatum;
        private int peldany;
        Konyvek konyvek;
        Kolcsonzo kolcsonzo;

        public string KonyvID { get => konyvID; set => konyvID = value; }
        public int KolcsonzoID { get => kolcsonzoID; set => kolcsonzoID = value; }
        public DateTime KivetelDatum { get => kivetelDatum; set => kivetelDatum = value; }
        public int Peldany { get => peldany; set => peldany = value; }
        internal Konyvek Konyvek { get => konyvek; set => konyvek = value; }
        internal Kolcsonzo Kolcsonzo { get => kolcsonzo; set => kolcsonzo = value; }

        public Kolcsonzes(string konyvID, int kolcsonzoID, DateTime kivetelDatum, int peldany)
        {
            this.konyvID = konyvID;
            this.kolcsonzoID = kolcsonzoID;
            this.kivetelDatum = kivetelDatum;
            this.peldany = peldany;
        }
        public Kolcsonzes(string konyvID,int kolcsonzoID,int peldany)
        {
            this.konyvID = konyvID;
            this.kolcsonzoID = kolcsonzoID;
            this.peldany = peldany;
        }
       public void AddKonyvek(Konyvek konyv)
        {
            this.Konyvek = konyv;
            konyvID = konyv.Kod;
        }
        public void AddKolcsonzo(Kolcsonzo berlo)
        {
            this.Kolcsonzo = berlo;
            this.kolcsonzoID = berlo.ID;
        }
        public override string ToString()
        {
            return Kolcsonzo.Nev + "->" + Konyvek.Szerzo + ":" + Konyvek.Cim + (+this.peldany + "db");
        }
    }
}
