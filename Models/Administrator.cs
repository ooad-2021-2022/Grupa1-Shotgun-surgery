using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Administrator : User
    {
        List<ZahtjevZaBrisanjem> zahtjevi;

        public Administrator(string password, string personalInfo, string username) : base(password, personalInfo, username)    
        {
        }

        public List<ZahtjevZaBrisanjem> getZahtjevi()
        {
            return zahtjevi;
        }

       

    }
}
