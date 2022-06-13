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

        public TipVozila GetTipVozila()
        {
            return tipVozila;
        }

        public Dictionary<int, bool> GetSjedista()
        {
            return sjedista;
        }

        public bool IsSjedisteZauzeto(int redniBrojSjedista)
        {
            return sjedista[redniBrojSjedista].Equals(false);
            /*if (sjedista[redniBrojSjedista].Equals(false))
            {
                return false;
            }
            return true;*/
        }
        
    }
}
