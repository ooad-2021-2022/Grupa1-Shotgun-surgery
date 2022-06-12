namespace TuristickaAgencija.Models
{ 
    public class UslugaPrijevoza : Usluga
    {
        int brojSjedista;
        Vozilo vozilo;
        PutnaLinija putnaLinija;

        public UslugaPrijevoza(decimal cijena, Tuple<DateTime, DateTime> periodOdDo, int brojSjedista, Vozilo vozilo, PutnaLinija putnaLinija):base(decimal cijena, Tuple < DateTime, DateTime > periodOdDo, List < Ocjena > ocjene)
        {
            this.brojSjedista = brojSjedista;
            this.vozilo = vozilo;
            this.putnaLinija = putnaLinija;
        }

        public int getBrojSjedista()
        {
            return brojSjedista;
        }

        public Vozilo getVozilo()
        {
            return vozilo;
        }

        public Vozilo getPutnaLinija()
        {
            return putnaLinija;
        }
    }
}
