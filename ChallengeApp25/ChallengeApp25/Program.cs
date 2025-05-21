// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

var employee = new Employee("Adam", "Nowak");
employee.AddGrade(3);
employee.AddGrade(4);
var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}"); 


