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

var employee = new EmployeeInFile("Jakub", "KowALSKI");
employee.AddGrade(0.5f);

//employee.SayHello();
//try
//{
//    EmployeeInMemory emp = null;
//    var name = emp.Surname;
//}
//catch (Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}

//finally
//{
//    Console.WriteLine("Finnally here");
//}
//    while (true)

//{
//    Console.WriteLine("podaj kolejna ocene pracownika");
//    var input = Console.ReadLine();


//    if (input == "q" || input == "Q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception exception )
//    {
//        Console.WriteLine($"Exception catched: {exception.Message}");
//       // continue; // Skip to the next iteration if an exception occurs
//    }



//}


var statistics = employee.GetStatistics();

Console.WriteLine($"Average:  { statistics.Average}");

Console.WriteLine($"Max: {statistics.Max} Min: {statistics.Min} Average: {statistics.Average:N2}");