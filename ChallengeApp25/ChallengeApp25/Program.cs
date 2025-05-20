// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

User user1 = new User("Adam", "32546");
User user2 = new User("Monika","88995588");
User user3 = new User("Zuzia","99556688");
User user4 = new User("Damian","4455887755");

Employee employee1 = new Employee("aaa","nazwis1");
Employee employee2 = new Employee("bbbb","nazwisko2");
Employee employee3 = new Employee("cccc","nazwisko3");
Employee employee4 = new Employee("ddd","nazwisko4");
Employee employee5 = new Employee("eee","nazwisko5");


var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(5);
employee.AddGrade(3);
employee.AddGrade(4);
var statistics = employee.GetStatistics();


Console.WriteLine($"Najlepsza ocena: {statistics.Max :N2}");
Console.WriteLine($"Najgorsza ocena: {statistics.Min :N2} ");
Console.WriteLine($"Srednia ocen: {statistics.Average:N2} ");
//user1.Login = "Marek";
var name =user1.Login;
user1.AddScore(5);
var result =user1.Result;
user1.AddScore(10);
Console.WriteLine(user1.Result);
User.GameName ="Doom";
var pi =  Math.PI;
Console.WriteLine(pi);

//var imie = employee1;
//Console.WriteLine(employee1.Punkty);




