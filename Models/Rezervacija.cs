using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Rezervacija
    {
        List<Usluga> usluge;
        decimal cijena = 0;

        public void izracunajCijenu()
        {
            foreach (Usluga usluga in usluge) cijena += usluga.getCijena();
        }
    }
}
