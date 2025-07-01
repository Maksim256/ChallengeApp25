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

           // var index = 0;
            //do
            //{
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;

            //} while (index < this.grades.Count);

            //while (index < this.grades.Count)
            //{
            //    if (this.grades[index] == 5)
            //    {
            //        break;
            //    }
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;

            //}
            

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }

        //public static Statistics GetStatisticsWithFor()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Min = float.MaxValue;
        //    statistics.Max = float.MinValue;
        //    for (int i = 0; i < grades.Count; i++)
        //    {
        //        if (employee.grades[i] > 0)
        //        {
        //            statistics.Min = Math.Min(statistics.Min, employee.grades[i]);
        //            statistics.Max = Math.Max(statistics.Max, employee.grades[i]);
        //            statistics.Average += employee.grades[i];
        //        }
        //    }
        //    statistics.Average /= employee.grades.Count;
        //    return statistics;
        //}

        public  Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            int index = 0;
            do
            {
                if (this.grades[index] > 0)
                {
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Average += this.grades[index];
                }
                index++;
            } while (index < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            int index = 0;
            while (index < this.grades.Count)
            {
                if (this.grades[index] == 5)
                {
                    break;
                }
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            }
            statistics.Average /= grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            for (int i = 0; i < this.grades.Count; i++)
            {
                if (this.grades[i] > 0)
                {
                    statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                    statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                    statistics.Average += this.grades[i];
                }
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
