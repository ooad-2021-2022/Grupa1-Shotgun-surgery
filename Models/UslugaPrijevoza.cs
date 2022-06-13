using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{ 
    public class UslugaPrijevoza : Usluga
    {
        int brojSjedista;
        Vozilo vozilo;
        PutnaLinija putnaLinija;

        public UslugaPrijevoza(decimal cijena, Tuple<DateTime, DateTime> periodOdDo, int brojSjedista, List<Ocjena> ocjene, Vozilo vozilo, PutnaLinija putnaLinija) : base(cijena, periodOdDo, ocjene)
        {
            this.brojSjedista = brojSjedista;
            this.vozilo = vozilo;
            this.putnaLinija = putnaLinija;
        }

        public int getBrojSjedista()
        {
            return brojSjedista;
        }

        public Vozilo getVozilo()
        {
            return vozilo;
        }

        public PutnaLinija getPutnaLinija()
        {
            return putnaLinija;
        }
    }
}
