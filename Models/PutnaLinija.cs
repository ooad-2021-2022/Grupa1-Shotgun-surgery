using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class PutnaLinija
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Prijevoznik")]
        public int prijevoznikID { get; set; }
        Lokacija polaznaLokacija { get; set; }
        Lokacija krajnjaLokacija { get; set; }
       // List<Lokacija> stajalista { get; set; }
        int trajanjeMinute { get; set; }
        DateTime vrijemePolaska { get; set; }

        public PutnaLinija(Lokacija polaznaLokacija, Lokacija krajnjaLokacija,  int trajanjeMinute, DateTime vrijemePolaska)
        {
            this.polaznaLokacija = polaznaLokacija;
            this.krajnjaLokacija = krajnjaLokacija;
            this.trajanjeMinute = trajanjeMinute;
            this.vrijemePolaska = vrijemePolaska;
        }

        public PutnaLinija() { }
        /*public void DodajStajaliste(Lokacija stajaliste)
        {
            if (stajalista.Contains(stajaliste)) throw new Exception("Stajaliste je vec prisutno!");
            stajalista.Add(stajaliste);
        }

        public void UkloniStajaliste(Lokacija stajaliste)
        {
            if (!stajalista.Contains(stajaliste)) throw new Exception("Stajaliste nije prisutno!");
            stajalista.Remove(stajaliste);
        }*/
    }
}
