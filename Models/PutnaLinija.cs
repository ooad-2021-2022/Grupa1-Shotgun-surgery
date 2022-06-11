using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class PutnaLinija
    {
        Lokacija polaznaLokacija;
        Lokacija krajnjaLokacija;
        List<Lokacija> stajalista;
        int trajanjeMinute;
        DateTime vrijemePolaska;

        public PutnaLinija(Lokacija polaznaLokacija, Lokacija krajnjaLokacija, List<Lokacija> stajalista, int trajanjeMinute, DateTime vrijemePolaska)
        {
            this.polaznaLokacija = polaznaLokacija;
            this.krajnjaLokacija = krajnjaLokacija;
            this.stajalista = stajalista;
            this.trajanjeMinute = trajanjeMinute;
            this.vrijemePolaska = vrijemePolaska;
        }

        public Lokacija GetPolaznaLokacija()
        {
            return polaznaLokacija;
        }

        public Lokacija GetKrajnjaLokacija()
        {
            return krajnjaLokacija;
        }

        public List<Lokacija> GetStajalista()
        {
            return stajalista;
        }
        
        public int GetTrajanjeMinute()
        {
            return trajanjeMinute;
        }

        public DateTime GetVrijemePolaska()
        {
            return vrijemePolaska;
        }
        
        public void SetTrajanjeMinute(int trajanjeMinute)
        {
            this.trajanjeMinute=trajanjeMinute;
        }

        public void SetVrijemePolaska(DateTime vrijemePolaska)
        {
            this.vrijemePolaska = vrijemePolaska;
        }

        public void DodajStajaliste(Lokacija stajaliste)
        {
            if (stajalista.Contains(stajaliste)) throw new Exception("Stajaliste je vec prisutno!");
            stajalista.Add(stajaliste);
        }

        public void UkloniStajaliste(Lokacija stajaliste)
        {
            if (!stajalista.Contains(stajaliste)) throw new Exception("Stajaliste nije prisutno!");
            stajalista.Remove(stajaliste);
        }
    }
}
