// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

var employee = new Employee("Adam", "Nowak");
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(3);
var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max} Min: {statistics.Min} Average: {statistics.Average:N2}"); 
SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    // This method is intentionally left blank.
    // It serves as a placeholder for future functionality or testing purposes.
    // Currently, it does not perform any operations or return any values.
    statistics = new Statistics();
}
