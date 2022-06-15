using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Sjediste
    {

        [Key]
        public int Id { get; set; }
        public bool Zauzeto { get; set; }
        [ForeignKey("Vozilo")]
        public int VoziloId { get; set; }

        public Sjediste() {}

    }
}
