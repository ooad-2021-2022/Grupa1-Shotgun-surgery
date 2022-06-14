using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Soba
    {
        [Key]
        int Id { get; set; }
        [ForeignKey("Smjestaj")]
        int SmjestajId { get; set; }
        int kapacitet { get; set; }
        bool klima { get; set; }
        bool wifi { get; set; }

        public Soba(int kapacitet, bool klima, bool wifi)
        {
            this.kapacitet = kapacitet;
            this.klima = klima;
            this.wifi = wifi;
        }

        public Soba()
        {
        }
    }
}
