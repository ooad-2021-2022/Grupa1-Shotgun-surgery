using System;
using System.Collections.Generic;
using System.Drawing;
namespace TuristickaAgencija.Models
{
    public class UslugaSmjestaja : Usluga
    {
        Soba soba;
        Pansion pansion;
        List<Image> slike;

        public UslugaSmjestaja(decimal cijena, Tuple<DateTime, DateTime> periodOdDo, List<Ocjena> ocjene, Soba soba, Pansion pansion,List<Image> slike): base(cijena, periodOdDo, ocjene)
        {
            this.soba = soba;
            this.pansion = pansion;
            this.slike = slike;
        }

        public Soba getSoba()
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
        }
            
    }
}
