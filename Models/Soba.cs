namespace TuristickaAgencija.Models
{
    public class Soba
    {
        int kapacitet;
        bool klima;
        bool wifi;

        public Soba(int kapacitet, bool klima, bool wifi)
        {
            this.kapacitet = kapacitet;
            this.klima = klima;
            this.wifi = wifi;
        }

        public int GetKapacitet()
        {
            return kapacitet;
        }

        public bool HasKlima()
        {
            return klima;
        }

        public bool HasWifi()
        {
            return wifi;
        }

        public void SetWifi(bool wifi)
        {
            this.wifi = wifi;
        }

        public void SetKlima(bool klima)
        {
            this.klima = klima;
        }
    }
}
