using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Zaposlenik : User
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int User { get; set; }
        public Zaposlenik(string password, string personalInfo, string username) : base(password, personalInfo, username)
        {
        }
        public Zaposlenik()
        {
        }
    }
}
