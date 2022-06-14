using System.Collections.Generic;
using System.Web.Providers.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class VlasnikSmjestaja : User
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int User { get; set; }
        

        public VlasnikSmjestaja(string password, string personalInfo, string username) : base(password, personalInfo, username)
        {
        }

        public VlasnikSmjestaja()
        {
        }

        /*
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
        */
    }
}
