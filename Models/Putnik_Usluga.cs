using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Putnik_Usluga
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey("Putnik")]
        public int PutnikId { get; set; }
        [ForeignKey("Usluga")]
        public int UslugaId { get; set; }

        public Putnik_Usluga() {}

    }
}
