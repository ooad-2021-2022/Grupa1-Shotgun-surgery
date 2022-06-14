using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TuristickaAgencija.Models
{
    public class UslugaSmjestaja : Usluga
    {
        [Key]
        public int Id { get; set; }
        public int Pansion { get; set; }
        [ForeignKey("VlasnikSmjestaja")]
        public int VlasnikSmjestaja { get; set; }
        [ForeignKey("Soba")]
        public int Soba { get; set; }
        [ForeignKey("Usluga")]
        public int Usluga { get; set; }
        //List<Image> slike;

        public UslugaSmjestaja(decimal cijena, Tuple<DateTime, DateTime> periodOdDo, int soba, int pansion): base(cijena, periodOdDo)
        {
            this.Soba = soba;
            this.Pansion = pansion;
        }

        public UslugaSmjestaja()
        {
        }



        /*public Soba getSoba()
        {
            return soba;
        }

        public Pansion GetPansion()
        {
            return pansion;
        }

        public List<Image> GetSlike()
        {
            return slike;
        }

        public void AddSlika(Image slika)
        {
            slike.Add(slika);
        }

        public void RemoveSlika(int index)
        {
            slike.RemoveAt(index);
        }

        public void RemoveSlika(Image slika)
        {
            slike.Remove(slika);
        }*/

    }
}
