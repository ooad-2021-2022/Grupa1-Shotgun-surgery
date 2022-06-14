using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{ 
    public class UslugaPrijevoza : Usluga
    {
        [Key]
        public int Id { get; set; }
        public int BrojSjedista { get; set; }
        [ForeignKey("Vozilo")]
        public int Vozilo { get; set; }
        [ForeignKey("PutnaLinija")]
        public int PutnaLinija { get; set; }
        [ForeignKey("Prijevoznik")]
        public int Prijevoznik { get; set; }
        [ForeignKey("Usluga")]
        public int Usluga { get; set; }
    

        public UslugaPrijevoza(decimal cijena, Tuple<DateTime, DateTime> periodOdDo, int brojSjedista, int vozilo, int putnaLinija) : base(cijena, periodOdDo)
        {
            this.BrojSjedista = brojSjedista;
            this.Vozilo = vozilo;
            this.PutnaLinija = putnaLinija;
        }

        public UslugaPrijevoza()
        {
        }

        public int getBrojSjedista()
        {
            return BrojSjedista;
        }

        public int getVozilo()
        {
            return Vozilo;
        }

        public int getPutnaLinija()
        {
            return PutnaLinija;
        }
    }
}
