using System.Web.Providers.Entities;
namespace TuristickaAgencija.Models
{
    public class Zaposlenik : User
    {
        public Zaposlenik(string password, string personalInfo, string username) : base(password, personalInfo, username)
        {
        }
    }
}
