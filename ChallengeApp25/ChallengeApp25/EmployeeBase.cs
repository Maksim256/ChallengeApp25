using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public abstract class EmployeeBase : IEmployee
    {

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
  

        public string Surname { get; private set; }
            

        public string Name { get; private set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"Witaj, jestem {this.Name} {this.Surname}");
        }

        public abstract void AddGrade(float grade);


        public abstract void AddGrade(double grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();
        
    }
}
