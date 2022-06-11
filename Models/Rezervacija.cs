using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Rezervacija
    {
        List<Usluga> usluge;
        decimal cijena = 0;

        public Rezervacija(List<Usluga> usluge)
        {
            this.usluge = usluge;
        }

        public List<Usluga> GetUsluge()
        {
            return usluge;
        }

        public decimal GetCijena()
        {
            return cijena;
        }

        public void SetUsluge(List<Usluga> usluge)
        {
            this.usluge = usluge;
        }

        public void izracunajCijenu()
        {
            foreach (Usluga usluga in usluge) cijena += usluga.getCijena();
        }

        public void DodajUslugu(Usluga usluga)
        {
            usluge.Add(usluga);
        }

        public void UkloniUslugu(Usluga usluga)
        {
            usluge.Remove(usluga);
        }
    }
}
