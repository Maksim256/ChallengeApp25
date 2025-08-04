using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        
        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
       {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)  // validation for grades
            {

                this.grades.Add(grade);

                if ((GradeAdded!= null))
                { 
                    GradeAdded(this, new EventArgs()); //event to notify that grade was added
                }
                else
                {
                    Console.WriteLine("No subscribers for GradeAdded event.");
                }
                
                    
                
            }
            else
            {
                throw new Exception("invalid grade value");
                //Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat); //converting double to float and adding grade
        }

        public override void AddGrade(int grade)
        {
            float gradeAsInt = (float)grade;
            this.AddGrade(gradeAsInt); //converting int to float and adding grade
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':

                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result)) //parsing string to float
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float.");
                //console.writeline("invalid grade format. string is not float.");
            }
        }

        public override Statistics GetStatistics()
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
