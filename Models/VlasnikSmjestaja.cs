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

        public void SetUslugeSmjestaja(List<UslugaSmjestaja> usluge)
        {
            this.usluge = usluge;

        }

        public void AddUslugaSmjestaja(UslugaSmjestaja usluga)
        {
            usluge.Add(usluga);
        }

        
        public void RemoveUslugaSmjestaja(UslugaSmjestaja usluga)
        {
            if (usluge.Contains(usluga).Equals(false))
            {
                throw new System.Exception("Ne postoji element u listi");
            }
            usluge.Remove(usluga);
        }

        public void RemoveUslugaSmjestaja(int index)
        {
            if(index<0 || index >= usluge.Capacity)
            {
                throw new System.Exception("Indeks van opsega liste");
            }
            usluge.RemoveAt(index);
        }

        public List<Smjestaj> GetSmjestaji()
        {
            return smjestaji;
        }
        public void SetSmejstaji(List<Smjestaj> smjestaji)
        {
            this.smjestaji = smjestaji;

        }

        public void AddSmjestaj(Smjestaj smjestaj)
        {
            smjestaji.Add(smjestaj);
        }


        public void RemoveSmjestaj(Smjestaj smjestaj)
        {
            if (smjestaji.Contains(smjestaj).Equals(false))
            {
                throw new System.Exception("Ne postoji element u listi");
            }
            smjestaji.Remove(smjestaj);
        }

        public void RemoveSmjestaj(int index)
        {
            if (index < 0 || index >= smjestaji.Capacity)
            {
                throw new System.Exception("Indeks van opsega liste");
            }
            smjestaji.RemoveAt(index);
        }

    }
}
