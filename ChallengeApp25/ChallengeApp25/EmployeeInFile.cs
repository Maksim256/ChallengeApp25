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

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) // validation for grades
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs()); //event to notify that grade was added
                }
            }
            else
            {
                throw new Exception("invalid grade value");
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

            }
            throw new Exception("String is not float2");
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
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}")) //using otwiera i zamyka plik automatycznie
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
           

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.AddGrade(grade);
                }
                
            
            }

            return statistics;
        }
    }
}
