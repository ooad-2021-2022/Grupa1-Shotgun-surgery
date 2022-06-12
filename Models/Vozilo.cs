using System.Collections.Generic;
namespace TuristickaAgencija.Models
{
    public class Vozilo
    {
        TipVozila tipVozila;
        Dictionary<int, bool> sjedista;

        public Vozilo(TipVozila tipVozila, Dictionary<int,bool> sjedista)
        {
            this.tipVozila = tipVozila;
            this.sjedista = sjedista;
        }

        public TipVozila getTipVozila()
        {
            return tipVozila;
        }

        public Dictionary<int, bool> getSjedista()
        {
            return sjedista;
        }

        public bool isSjedisteZauzeto(int redniBrojSjedista)
        {
            if (sjedista[redniBrojSjedista].Equals(false))
            {
                return false;
            }
            return true;
        }
        
    }
}
