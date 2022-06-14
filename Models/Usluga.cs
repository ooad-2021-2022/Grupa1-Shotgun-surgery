using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Usluga
    {
        [Key]
        public int id { get; set; }
        public decimal cijena { get; set; }
        public DateTime pocetak { get; set; }

        public DateTime kraj { get; set; }
        //protected List<Ocjena> ocjene = new List<Ocjena>();
        public double prosjecnaOcjena { get; set; }


        public Usluga(decimal cijena, Tuple<DateTime,DateTime> periodOdDo)
        {
            this.cijena = cijena;
            this.pocetak = periodOdDo.Item1;
            this.kraj = periodOdDo.Item2;
            //this.ocjene = ocjene;
        }

        public Usluga()
        {
        }

        /*public void IzracunajProsjek()
        {
            if (ocjene.Count == 0) return;
            foreach (Ocjena ocjena in ocjene) prosjecnaOcjena += ocjena.getBrojZvjezdica();
            prosjecnaOcjena /= ocjene.Count;
        }*/

        /* public double GetProsjecnaOcjena()
         {
             return prosjecnaOcjena;
         }*/

        public Tuple<DateTime, DateTime> GetPeriodOdDo()
        {
            return new Tuple<DateTime, DateTime>(pocetak, kraj);
        }

        public void PromijeniDo(DateTime datumDo)
        {
            kraj = datumDo;
        }

        public void PromijeniOd(DateTime datumOd)
        {
            pocetak = datumOd;
        }

        public void SetPeriodOdDo(Tuple<DateTime, DateTime> periodOdDo)
        {
            PromijeniDo(periodOdDo.Item2);
            PromijeniOd(periodOdDo.Item1);
        }

        public decimal GetCijena()
        {
            return cijena;
        }

       /* public List<Ocjena> GetOcjene()
        {
            return ocjene;
        }*/

        public void setCijena(decimal cijena)
        {
            this.cijena = cijena;
        }

        /*public void DodajOcjenu(Ocjena ocjena)
        {
            ocjene.Add(ocjena);
        }*/

       /* public void ObrisiOcjenu(Ocjena ocjena)
        {
            ocjene.Remove(ocjena);
        }*/
    }
}
