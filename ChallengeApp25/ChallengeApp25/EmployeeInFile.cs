using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }
        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsInt = (float)grade;
            this.AddGrade(gradeAsInt);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                //case 'A':
                //case 'a':
                //    this.grades.Add(100);
                //    break;
                //case 'B':
                //case 'b':
                //    this.grades.Add(80);
                //    break;
                //case 'C':
                //case 'c':
                //    this.grades.Add(60);
                //    break;
                //case 'D':
                //case 'd':

                //    this.grades.Add(40);
                //    break;
                //case 'E':
                //case 'e':
                //    this.grades.Add(20);
                //    break;
                //default:
                //    throw new Exception("Wrong letter");


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
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
           
        private List<float> ReadGradesFromFile()
        { 
            var grades = new List<float>(); 
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName)) //using otwiera i zamyka plik automatycznie
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number); //dodawanie liczby do listy
                        line = reader.ReadLine(); //czytanie kolejnej linii

                    }
                }
            }
            
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in grades)
            {
                if (grade <= 0)
                {
                    
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= grades.Count;
            }
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
                
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
