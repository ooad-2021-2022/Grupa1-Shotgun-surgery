using System.Collections.Generic;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class Prijevoznik : User
    {
        List<UslugaPrijevoza> usluge;
        List<PutnaLinija> putneLinije;

        public Prijevoznik(string password, string personalInfo, string username, List<UslugaPrijevoza> usluge,
            List<PutnaLinija> putneLinije) : base(password, personalInfo, username)
        {
            this.usluge = usluge;
            this.putneLinije = putneLinije;
        }

        public List<UslugaPrijevoza> GetUsluge()
        {
            return usluge;
        }

        public List<PutnaLinija> GetPutneLinije()
        {
            return putneLinije;
        }
    }
}
