using System;
using System.ComponentModel.DataAnnotations;

namespace TuristickaAgencija.Models
{
    public class Lokacija
    {
        [Key]
        public int ID { get; set; }
        double geografskaSirina { get; set; }
        double geografskaDuzina { get; set; }
        double geografskaVisina { get; set; }
        string linkNaKartu { get; set; }
        string drzava { get; set; }
        string grad { get; set; }
        string adresa { get; set; }

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
        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }

        public Lokacija() { }

    }


}
