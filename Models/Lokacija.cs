namespace TuristickaAgencija.Models
{
    public class Lokacija
    {
        double geografskaSirina;
        double geografskaDuzina;
        double geografskaVisina;
        string linkNaKartu;
        string drzava;
        string grad;
        string adresa;

        public Lokacija(double geografskaSirina, double geografskaDuzina, double geografskaVisina)
        {
            this.geografskaSirina = geografskaSirina;
            this.geografskaDuzina = geografskaDuzina;
            this.geografskaVisina = geografskaVisina;
        }

        public Lokacija(double geografskaSirina, double geografskaDuzina, double geografskaVisina,
            string linkNaKartu, string drzava, string grad, string adresa)
        {
            this.geografskaSirina = geografskaSirina;
            this.geografskaDuzina = geografskaDuzina;
            this.geografskaVisina = geografskaVisina;
            this.linkNaKartu = linkNaKartu;
            this.drzava = drzava;  
            this.grad = grad;
            this.adresa = adresa;
        }
        
        public double GetGeografskaSirina()
        {
            return geografskaSirina;
        }

        public double GetGeografskaDuzina()
        {
            return geografskaDuzina;
        }

        public double GetGeografskaVisina()
        {
            return geografskaVisina;
        }

        public string GetLinkNaKartu()
        {
            return linkNaKartu;
        }

        public string GetDrzava()
        {
            return drzava;
        }

        public string GetGrad()
        {
            return grad;
        }

        public string GetAdresa()
        {
            return adresa;
        }

        public void SetGeografskaSirina(double geografskaSirina)
        {
            this.geografskaSirina = geografskaSirina;
        }

        public void SetGeografskaDuzina(double geografskaDuzina)
        {
            this.geografskaDuzina = geografskaDuzina;
        }

        public void SetGeografskaVisina(double geografskaVisina)
        {
            this.geografskaVisina = geografskaVisina;
        }

        public void SetLinkNaKartu(string linkNaKartu)
        {
            this.linkNaKartu = linkNaKartu;
        }

        public void SetDrzava(string drzava)
        {
            this.drzava = drzava;
        }

        public void SetGrad(string grad)
        {
            this.grad = grad;
        }

        public void SetAdresa(string adresa)
        {
            this.adresa = adresa;
        }
    }


}
