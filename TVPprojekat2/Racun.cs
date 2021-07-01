using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPprojekat2
{
    class Racun
    {
        double cena;
        string datum;
        string vreme;

        public Racun()
        {
            cena = 0;
            datum = DateTime.Now.ToShortDateString();
            vreme = DateTime.Now.ToShortTimeString();
        }

        public Racun(double cena, DateTime datum)
        {
            this.cena = cena;
            this.datum = datum.ToShortDateString();
            this.vreme = datum.ToShortTimeString();
        }
        
        public double Cena { get => cena; set => cena = value; }
        public string Datum { get => datum; set => datum = value; }
        public string Vreme { get => vreme; set => vreme = value; }
    }
}
