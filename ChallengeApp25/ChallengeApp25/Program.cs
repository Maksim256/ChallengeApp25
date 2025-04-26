// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

User user1 = new User("Adam", "32546");
User user2 = new User("Monika","88995588");
User user3 = new User("Zuzia","99556688");
User user4 = new User("Damian","4455887755");

Employee employee1 = new Employee("aaa","nazwis1",23);
Employee employee2 = new Employee("bbbb","nazwisko2", 28);
Employee employee3 = new Employee("cccc","nazwisko3", 38);
Employee employee4 = new Employee("ddd","nazwisko4", 50);
Employee employee5 = new Employee("eee","nazwisko5", 55);


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
employee1.DodajPunkty(1);
employee1.DodajPunkty(2);
employee1.DodajPunkty(55);

employee2.DodajPunkty(2);
employee2.DodajPunkty(3);
employee2.DodajPunkty(24);

employee3.DodajPunkty(5);
employee3.DodajPunkty(6);
employee3.DodajPunkty(7);

employee4.DodajPunkty(8);
employee4.DodajPunkty(9);
employee4.DodajPunkty(10);
employee5.DodajPunkty(41);
employee5.DodajPunkty(12);
employee5.DodajPunkty(13);
employee5.DodajPunkty(14);




List<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,employee4,employee5
};

int maxPoints = -1;

Employee topEmployees = null;

foreach (var employee in employees)
{
    if (employee.Punkty > maxPoints)
    {
        topEmployees = employee;
        maxPoints = employee.Punkty;
    }
    
}
Console.WriteLine("najlepszy" +" "+ topEmployees.Nazwisko, "punkty " );