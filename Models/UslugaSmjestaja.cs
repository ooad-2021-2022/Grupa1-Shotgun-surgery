using System.Collections.Generic;
using System.Drawing;
namespace TuristickaAgencija.Models
{
    public class UslugaSmjestaja : Usluga
    {
        Soba soba;
        Pansion pansion;
        List<Image> slike;

        public UslugaSmjestaja(decimal cijena, Tuple<DateTime, DateTime> periodOdDo,  Soba soba, Pansion pansion,List<Image> slike): base(decimal cijena, Tuple < DateTime, DateTime > periodOdDo, List < Ocjena > ocjene)
        {
            this.soba = soba;
            this.pansion = pansion;
            this.slike = slike;
        }

        public Soba getSoba()
        {
            return soba;
        }

        public Pansion getPansion()
        {
            return pansion;
        }

        public List<Image> getSlike()
        {
            return slike;
        }

        public void addSlika(Image slika)
        {
            slike.Add(slika);
        }

        public void removeSlika(int index)
        {
            slike.RemoveAt(index);
        }

        public removeSlika(Image slika)
        {
            slike.Remove(slika);
        }
            
    }
}
