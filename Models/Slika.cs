using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Slika
    {
        [Key]
        public int Id { get; set; }
        public string Podatak { get; set; }
        [ForeignKey("UslugaSmjestaja")]
        public int UslugaSmjestajaId { get; set; }

        public Slika() {}
    }
}
