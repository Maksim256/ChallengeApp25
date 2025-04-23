using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class User
    {
        public static string GameName = "Diablo";
        private int Age { get; set; }
        //  private string login { get; set; }
        //   private string password;
        private string name;

        private List<int> score = new List<int>();



        public User()
        {
            this.Login = "-";
            this.Password = "-";
            this.name = "-";

        }
        public User(string login)
        {
            this.Login = login;
        }
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            // this.score = 0;
        }
        public User(string login, string password, string name)
        {
            this.Login = login;
            this.Password = password;
            this.name = name;
        }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
