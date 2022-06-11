using System;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class Notifikacija
    {
        User primalac;
        DateTime datum;
        string poruka;

        public Notifikacija(User primalac, DateTime datum, string poruka)
        {s
            this.primalac = primalac;
            this.datum = datum;
            this.poruka = poruka;
        }

        public User getPrimalac()
        {
            return primalac;
        }

        public DateTime getDatum()
        {
            return datum;
        }

        public string getPoruka()
        {
            return poruka;
        }
    }
}
