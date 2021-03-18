using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyonyoru_Lajos_Gepszam
{
    class Konyvek
    {
        private string kod;
        private string szerzo;
        private string cim;
        private int kiadasEve;
        private int ar;
        private string iSBN;

        public string Kod { get => kod; set => kod = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
        public int Ar { get => ar; set => ar = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }

        public Konyvek(string kod, string szerzo, string cim, int kiadasEve, int ar, string iSBN)
        {
            this.kod = kod;
            this.szerzo = szerzo;
            this.cim = cim;
            this.kiadasEve = kiadasEve;
            this.ar = ar;
            this.iSBN = iSBN;
        }
        public override string ToString()
        {
            return szerzo + ":" + cim;
        }
    }
}
