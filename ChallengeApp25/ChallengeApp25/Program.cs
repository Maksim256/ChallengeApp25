// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

//var employee = new Employee();
//employee.AddGrade("Tom");
//employee.AddGrade(9f);
//employee.AddGrade(2);
//employee.AddGrade(60);
//employee.AddGrade('a');


Console.WriteLine("Witamy w progamie do oceny pracowników");
Console.WriteLine("==========================================");

var employee = new Employee();
while (true)

{
    Console.WriteLine("podaj kolejna ocene pracownika");
    var input = Console.ReadLine();
    
    
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);

}


var statistics = employee.GetStatistics();

Console.WriteLine($"Average:  { statistics.Average}");

Console.WriteLine($"Max: {statistics.Max} Min: {statistics.Min} Average: {statistics.Average:N2}");