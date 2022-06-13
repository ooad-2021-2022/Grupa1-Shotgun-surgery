using System;
using System.Collections.Generic;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class ZahtjevZaBrisanjem
    {
        List<User> korisnici;
        string obrazlozenje;
        DateTime datum;

        public ZahtjevZaBrisanjem(List<User> korisnici, string obrazlozenje, DateTime datum)
        {
            this.korisnici = korisnici;
            this.obrazlozenje = obrazlozenje;
            this.datum = datum;
        }

        public List<User> GetKorisnici()
        {
            return korisnici;
        }

        public string GetObrazlozenje()
        {
            return obrazlozenje;
        }

        public DateTime GetDatum()
        {
            return datum;
        }
    }
}
