using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        //List<Usluga> usluge;

        [ForeignKey("Putnik")]
        public int PutnikId { get; set; }
        decimal cijena { get; set; } = 0;

        public Rezervacija() { }      
        


       

        /*public void IzracunajCijenu()
        {
            foreach (Usluga usluga in usluge) cijena += usluga.GetCijena();
        }

        public void DodajUslugu(Usluga usluga)
        {
            usluge.Add(usluga);
        }

        public void UkloniUslugu(Usluga usluga)
        {
            usluge.Remove(usluga);
        }*/
    }
}
