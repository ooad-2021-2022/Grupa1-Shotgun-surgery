using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models
{
    public class PutnaLinija
    {
        Lokacija polaznaLokacija;
        Lokacija krajnjaLokacija;
        List<Lokacija> stajalista;
        int trajanjeMinute;
        DateTime vrijemePolaska;
    }
}
