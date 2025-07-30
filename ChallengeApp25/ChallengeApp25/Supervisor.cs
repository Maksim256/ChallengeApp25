using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public string Name => "Adam";
        public string Surname => "Kowalski";

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            //6 = > 100
            //5 = > 80
            //4 = > 60
            //3 = > 40
            //-3==> 35
            //3-=>35    
            //2+ => 25
            //+2 =>25
            //2 => 20
            // 1 => 10
            // + / -  obsluga dla wszyskich ocen
            switch (grade)
            {
                case "6":
                  this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "5":
                
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "4":
                
                    this.grades.Add(60);
                    break;
                case "4-":
                case "-4":
                    this.grades.Add(55);
                    break;
                case "3":
                

                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2":
                
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1":

                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }

        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
