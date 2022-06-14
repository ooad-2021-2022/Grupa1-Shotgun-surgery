using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Providers.Entities;

namespace TuristickaAgencija.Models
{
    public class Prijevoznik : User
    {
        [Key]
        public int ID { get; set; }
       // List<UslugaPrijevoza> usluge { get; set; }
       // List<PutnaLinija> putneLinije { get; set; }

        public Prijevoznik(string password, string personalInfo, string username 
            ) : base(password, personalInfo, username)
        {
           
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

        public Prijevoznik() { }


    }
}
