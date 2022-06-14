using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuristickaAgencija.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string personalInfo { get; set; }
        [ForeignKey("ZahtjevZaBrisanjem")]
        public int zahtjevZaBrisanjem { get; set; }

        public User(string password, string personalInfo, string username)
        {
            this.password = password;
            this.personalInfo = personalInfo;
            this.username = username;
        }

        public User()
        {
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public string getPersonalInfo()
        {
            return personalInfo;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setPersonalInfo(string personalInfo)
        {
            this.personalInfo = personalInfo;
        }
    }
}
