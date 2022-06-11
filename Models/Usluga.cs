using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Usluga
    {
        decimal cijena;
        Tuple<DateTime, DateTime> periodOdDo;
        List<Ocjena> ocjene;
        double prosjecnaOcjena = 0;

        public void izracunajProsjek()
        {
            if (ocjene.Count == 0) return;
            foreach (Ocjena ocjena in ocjene) prosjecnaOcjena += ocjena.getBrojZvjezdica();
            prosjecnaOcjena /= ocjene.Count;
        }

        public decimal getCijena()
        {
            return cijena;
        }

        public void setCijena(decimal cijena)
        {
            this.cijena = cijena;
        }
    }
}
