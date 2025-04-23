// See https://aka.ms/new-console-template for more information
using ChallengeApp25;

User user1 = new User("Adam", "32546");
User user2 = new User("Monika","88995588");
User user3 = new User("Zuzia","99556688");
User user4 = new User("Damian","4455887755");

//user1.Login = "Marek";
var name =user1.Login;
user1.AddScore(5);
var result =user1.Result;
user1.AddScore(10);
Console.WriteLine(user1.Result);
User.GameName ="Doom";
var pi =  Math.PI;
Console.WriteLine(pi);


