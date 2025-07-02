// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

var employee = new Employee("Adam", "Nowak");
employee.AddGrade("Tom");
employee.AddGrade("2");
employee.AddGrade(4);
employee.AddGrade("3");

    

var statistics = employee.GetStatistics();

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Max: {statistics.Max} Min: {statistics.Min} Average: {statistics.Average:N2}");
Console.WriteLine($"Max1: {statistics1.Max} Min: {statistics1.Min} Average: {statistics1.Average:N2}");
Console.WriteLine($"Max2: {statistics2.Max} Min: {statistics2.Min} Average: {statistics2.Average:N2}");
Console.WriteLine($"Max3: {statistics3.Max} Min: {statistics3.Min} Average: {statistics3.Average:N2}");
Console.WriteLine($"Max4: {statistics4.Max} Min: {statistics4.Min} Average: {statistics4.Average:N2}");

SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    // This method is intentionally left blank.
    // It serves as a placeholder for future functionality or testing purposes.
    // Currently, it does not perform any operations or return any values.
    statistics = new Statistics();
}
