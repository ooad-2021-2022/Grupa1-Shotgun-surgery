using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuristickaAgencija.Models
{
    public class Putnik : User
    {

       [Key]
        public int ID { get; set; }
        List<Rezervacija> rezervacije { get; set; }
        List<Usluga> usluge { get; set; }
        PosebnaKategorija posebnaKategorija { get; set; }

        public Putnik(List<Rezervacija> rezervacije, List<Usluga> usluge, string password, string personalInfo, 
            string username, PosebnaKategorija posebnaKategorija) : base(password, personalInfo, username)
        {
            this.rezervacije = rezervacije;
            this.usluge = usluge;
            this.posebnaKategorija = posebnaKategorija;
        }

        public Putnik() { }

        
       /* public void DodajRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Add(rezervacija);
        }

        public void UkloniRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Remove(rezervacija);
        }

        public void DodajUslugu(Usluga usluga)
        {
            usluge.Add(usluga);
        }*/

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

        
    }
}
