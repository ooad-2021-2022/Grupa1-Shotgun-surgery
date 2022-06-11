using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class Smjestaj
    {
        TipSmjestaja tipSmjestaja;
        Lokacija lokacija;
        Dictionary<int, Soba> sobe;
    }
}
