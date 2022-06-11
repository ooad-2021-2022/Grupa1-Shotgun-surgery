using System.Collections.Generic;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class VlasnikSmjestaja : User
    {
        List<UslugaSmjestaja> usluge;
        List<Smjestaj> smjestaji;

        public VlasnikSmjestaja(string password, string personalInfo, string username) : base(password, personalInfo, username)
        {
        }
    }
}
