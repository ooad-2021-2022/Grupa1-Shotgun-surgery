using System.Collections.Generic;
namespace TuristickaAgencija.Models
{
    public class Putnik : User
    {
        List<Rezervacija> rezervacije;
        List<Usluga> usluge;
        PosebnaKategorija posebnaKategorija;

        public Putnik(List<Rezervacija> rezervacije, List<Usluga> usluge, string password, string personalInfo, 
            string username, PosebnaKategorija posebnaKategorija) : base(password, personalInfo, username)
        {
            this.rezervacije = rezervacije;
            this.usluge = usluge;
            this.posebnaKategorija = posebnaKategorija;
        }

        public List<Rezervacija> GetRezervacije()
        {
            return rezervacije;
        }

        public List<Usluga> GetUsluge()
        {
            return usluge;
        }

        public PosebnaKategorija GetPosebnaKategorija()
        {
            return posebnaKategorija;
        }

        public void SetPosebnaKategorija(PosebnaKategorija posebnaKategorija)
        {
            this.posebnaKategorija = posebnaKategorija;
        }

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Add(rezervacija);
        }

        public void UkloniRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Remove(rezervacija);
        }

        public void DodajUslugu(Usluga usluga)
        {
            usluge.Add(usluga);
        }
    }
}
