using System;

namespace TuristickaAgencija.Models
{
    public class Ocjena
    {
        int brojZvjezdica;
        string komentar;
        DateTime datum;

        public Ocjena(int brojZvjezdica, string komentar, DateTime datum)
        {
            this.brojZvjezdica = brojZvjezdica;
            this.komentar = komentar;
            this.datum = datum;
        }

        public int getBrojZvjezdica()
        {
            return brojZvjezdica;
        }

        public string getKomentar()
        {
            return komentar;
        }

        public DateTime getDatum()
        {
            return datum;
        }
    }
}
