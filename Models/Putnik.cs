using System.Collections.Generic;
using System.Web.Providers.Entities;
namespace TuristickaAgencija.Models
{
    public class Putnik : User
    {
        List<Rezervacija> rezervacije;
        List<Usluga> usluge;
        PosebnaKategorija posebnaKategorija;

        public Putnik(string password, string personalInfo, string username) : base(password, personalInfo, username)
        {
        }
    }
}
