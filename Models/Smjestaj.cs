using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Smjestaj
    {
        [Key]
        int Id { get; set; }
        [ForeignKey("VlasnikSmjestaja")]
        int VlasnikSmjestajaId { get; set; }
        int TipSmjestaja{ get; set; }

        [ForeignKey("Lokacija")]
        int LokacijaId { get; set; }

       // Dictionary<int, Soba> sobe;

        public Smjestaj(int tipSmjestaja)
        {
            this.TipSmjestaja = tipSmjestaja;
        }

        public Smjestaj()
        {
        }
    }
}
