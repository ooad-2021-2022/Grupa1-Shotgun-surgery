namespace TuristickaAgencija.Models
{
    public class User
    {
        protected string username;
        protected string password;
        protected string personalInfo;

        public User(string password, string personalInfo, string username)
        {
            this.password = password;
            this.personalInfo = personalInfo;
            this.username = username;
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

        public void setPersonalInfo(string personalnfo)
        {
            this.personalInfo = personalInfo;
        }
    }
}
