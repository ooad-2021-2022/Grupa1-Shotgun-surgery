using System.Collections.Generic;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class VlasnikSmjestaja : User
    {
        List<UslugaSmjestaja> usluge;
        List<Smjestaj> smjestaji;

        public VlasnikSmjestaja(string password, string personalInfo, string username, List<UslugaSmjestaja> usluge,List<Smjestaj> smjestaji) : base(password, personalInfo, username)
        {
            this.usluge = usluge;
            this.smjestaji = smjestaji;
        }

        public List<UslugaSmjestaja> getUsluge()
        {
            return usluge;
        }

        public void setUslugeSmjestaja(List<UslugeSmjestaja> usluge)
        {
            this.usluge = usluge;

        }

        public void addUslugaSmjestaja(UslugaSmjestaja usluga)
        {
            usluge.Add(usluga);
        }

        
        public void removeUslugaSmjestaja(UslugaSmjestaja usluga)
        {
            if (usluge.Contains(usluga).Equals(false))
            {
                throw new System.Exception("Ne postoji element u listi");
            }
            usluge.Remove(usluga);
        }

        public void removeUslugaSmjestaja(int index)
        {
            if(index<0 || index >= usluge.Capacity)
            {
                throw new System.Exception("Indeks van opsega liste");
            }
            usluge.RemoveAt(index);
        }

        public List<Smjestaj> getSmjestaji()
        {
            return smjestaji;
        }
        public void setSmejstaji(List<Smjestaj> smjestaji)
        {
            this.smjestaji = smjestaji;

        }

        public void addSmjestaj(Smjestaj smjestaj)
        {
            smjestaji.Add(smjestaj);
        }


        public void removeSmjestaj(Smjestaj smjestaj)
        {
            if (smjestaji.Contains(smjestaj).Equals(false))
            {
                throw new System.Exception("Ne postoji element u listi");
            }
            smjestaji.Remove(usluga);
        }

        public void removeSmjestaj(int index)
        {
            if (index < 0 || index >= smjestaji.Capacity)
            {
                throw new System.Exception("Indeks van opsega liste");
            }
            smjestaji.RemoveAt(index);
        }

    }
}
