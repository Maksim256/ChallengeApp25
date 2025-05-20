using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class Employee
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname )
        {
            this.Name = name;
            this.Surname = surname;
        }



        private string Name { get;  set; } //private
        private string Surname { get;  set; } //private
        
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            
            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
