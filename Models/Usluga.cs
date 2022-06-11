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

        public double GetProsjecnaOcjena()
        {
            return prosjecnaOcjena;
        }

        public Tuple<DateTime, DateTime> GetPeriodOdDo()
        {
            return periodOdDo;
        }

        public void SetPeriodOdDo(Tuple<DateTime, DateTime> periodOdDo)
        {
            this.periodOdDo = periodOdDo;
        }

        public void PromijeniDo(DateTime datumDo)
        {
            periodOdDo = new Tuple<DateTime, DateTime>(periodOdDo.Item1, datumDo);
        }

        public void PromijeniOd(DateTime datumOd)
        {
            periodOdDo = new Tuple<DateTime, DateTime>(datumOd, periodOdDo.Item1);
        }

        public decimal GetCijena()
        {
            return cijena;
        }

        public List<Ocjena> GetOcjene()
        {
            return ocjene;
        }

        public void setCijena(decimal cijena)
        {
            this.cijena = cijena;
        }

        public void DodajOcjenu(Ocjena ocjena)
        {
            ocjene.Add(ocjena);
        }

        public void ObrisiOcjenu(Ocjena ocjena)
        {
            ocjene.Remove(ocjena);
        }
    }
}
