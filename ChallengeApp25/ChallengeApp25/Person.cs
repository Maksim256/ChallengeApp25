using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{

        public abstract class Person 
    {
        protected int counter;
        
        public Person(string name, string surname, string plec)
        {
            this.Name = name;
            this.Surname = surname;
            this.Plec = plec;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Plec { get; private set; }
    }
}
