using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Smjestaj
    {
        TipSmjestaja tipSmjestaja;
        Lokacija lokacija;
        Dictionary<int, Soba> sobe;

        public Smjestaj(TipSmjestaja tipSmjestaja, Lokacija lokacija, Dictionary<int, Soba> sobe)
        {
            this.tipSmjestaja = tipSmjestaja;
            this.lokacija = lokacija;
            this.sobe = sobe;
        }

        public TipSmjestaja GetTipSmjestaja()
        {
            return tipSmjestaja;
        }

        public Lokacija GetLokacija()
        {
            return lokacija;
        }
    }
}
