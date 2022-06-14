using System;
using System.Collections.Generic;
using System.Web.Providers.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class ZahtjevZaBrisanjem
    {
        [Key]
        public int Id { get; set; }
        public string Obrazlozenje { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("Administrator")]
        public int Administrator { get; set; }

        public ZahtjevZaBrisanjem(string obrazlozenje, DateTime datum)
        {
            this.Obrazlozenje = obrazlozenje;
            this.Datum = datum;
        }
        public ZahtjevZaBrisanjem()
        {
        }

        /*public List<User> GetKorisnici()
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
        }*/
    }
}
