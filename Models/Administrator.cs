using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Administrator : User
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int User { get; set; }
       // List<ZahtjevZaBrisanjem> zahtjevi { get; set; }
        
        public Administrator(string password, string personalInfo, string username) : base(password, personalInfo, username)    
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

        public Administrator () { }



    }
}
