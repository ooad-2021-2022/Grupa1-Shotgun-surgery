using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class Notifikacija
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("User")]
        public int primalacID { get; set; }
        DateTime datum { get; set; }
        string poruka { get; set; }

        public Notifikacija(int primalacID, DateTime datum, string poruka)
        {       
            this.primalacID = primalacID;
            this.datum = datum;
            this.poruka = poruka;
        }
        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }

        public Notifikacija() { }


    }
}
