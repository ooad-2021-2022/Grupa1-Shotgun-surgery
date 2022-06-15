using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Rezervacija_Usluga
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Putnik")]
        public int RezervacijaId { get; set; }
        [ForeignKey("Usluga")]
        public int UslugaId { get; set; }

        public Rezervacija_Usluga() {}
    }
}
