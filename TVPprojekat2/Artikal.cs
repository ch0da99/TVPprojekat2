using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPprojekat2
{
    class Artikal
    {
        int id_artikla;
        string naziv;
        int cena;
        int popust;
        int id_grupe;

        public Artikal(int id_artikla, string naziv, int cena, int popust, int id_grupe)
        {
            this.id_artikla = id_artikla;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
            this.id_grupe = id_grupe;
        }
        public Artikal()
        {
            naziv = "";
            cena = 0;
            popust = 0;
        }
        public int Id_artikla { get { return id_artikla; } set { id_artikla = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public int Cena { get { return cena; } set { cena = value; } }
        public int Popust { get { return popust; } set { popust = value; } }
        public int Id_grupe { get { return id_grupe; } set { id_artikla = value; } }
    }
}
