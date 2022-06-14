using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Vozilo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("TipVozila")]
        public int TipVozila { get; set; }
        //Dictionary<int, bool> sjedista;

        public Vozilo(int tipVozila)
        {
            this.TipVozila = tipVozila;
        }

        public Vozilo()
        {
        }


        /*
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
            if (sjedista[redniBrojSjedista].Equals(false))
            {
                return false;
            }
            return true;
        }
        */
    }
}
