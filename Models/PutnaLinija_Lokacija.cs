using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class PutnaLinija_Lokacija
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PutnaLinija")]
        public int PutnaLinijaId { get; set; }
        [ForeignKey("Lokacija")]
        public int LokacijaId { get; set; }
        public PutnaLinija_Lokacija() {}
    }
}
