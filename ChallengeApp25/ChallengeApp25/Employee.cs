using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public Employee()
        {

        }

        public string Name { get; private set; } //private
        public string Surname { get; private set; } //private

        public void AddGrade(float grade)
        {

            
            if (grade >= 0 && grade <= 100)  // validation for grades
            { 
            this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result)) //parsing string to float
            {                 
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid grade format. String is not float.");
            }        
        }

        public void addGrade(char grade)
        {
            
            switch(grade)
            {
                case 'A':
                    case 'a': //case insensitive
                    this.grades.Add(100);
                    break;
                case 'B':
                    case 'b': //case insensitive
                    this.grades.Add(80);
                    break;
                case 'C':
                    case 'c': //case insensitive
                    this.grades.Add(60);
                    break;
                case 'D':
                    case 'd': //case insensitive

                    this.grades.Add(40);
                    break;
                case 'E':
                    case 'e': //case insensitive
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Invalid grade. Please enter a valid character grade (A, B, C, D, E).");
                    break;
            }
            
        }
        public void AddGrade(int grade)
        {
            float gradeAsInt = (float)grade;
            this.AddGrade(gradeAsInt); //converting int to float and adding grade
        }
        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat); //converting double to float and adding grade
        }

       

        public Statistics GetStatistics()  //Statistics to model danych w klasie statistics
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                if (grade > 0)
                {



                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Average += grade;
                }
            }


            statistics.Average /= this.grades.Count;

               switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 50:
                    statistics.AverageLetter = 'E';
                    break;
            }
                    return statistics;
        }
    }
}
