using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class Ocjena
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Usluga")]
        public int uslugaID { get; set; }
        int brojZvjezdica { get; set; }
        string komentar { get; set; }
        DateTime datum { get; set; }

        public Ocjena(int brojZvjezdica, string komentar, DateTime datum)
        {
           
            this.brojZvjezdica = brojZvjezdica;
            this.komentar = komentar;
            this.datum = datum;
        }

        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }

        public Ocjena() { }

    }
}
