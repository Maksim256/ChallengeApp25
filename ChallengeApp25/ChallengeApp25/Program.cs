// See https://aka.ms/new-console-template for more information

//liczby całkowite
// var myAge = 25;
/*
int myAge2 = 25;
int myAge = 120;
int newAge = myAge + 5;
Console.WriteLine(newAge);
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

//liczby zmiennoprzevcinkowe
float myVar4 = float.MaxValue;
double myVar5 = double.MaxValue;
decimal myVar6 = decimal.MaxValue;


//zmienne tekstowe
string name = "Janek";
string surname = "Kowalski";
string result = name + " " + surname + " " + myAge;
Console.WriteLine(result);
char myChar = 'A';
var result2 = name.ToArray();

//zmienne logiczne
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);
var number1 = 5;
var number2 = 6;

var name2 = "Janek";
var age = 25;
// &&  logiczny AND
// ||  logiczny OR  
// !  logiczny NOT
// ==  logiczny równa się
// !=  logiczny różne

if (name == "Janek" && age <= 25)
{
    Console.WriteLine("Janek ma mniej niż 25 lat");
}
else if (name == "Janek" && age > 26)
{
    Console.WriteLine("Janek ma ponad 26 lat");
}
else
{
    Console.WriteLine("Nie znam tego Janek");
}

if (number1 > number2)
{
    Console.WriteLine("number1 jest większe od number2");
}
else if (number1 < number2)
{
    Console.WriteLine("number1 jest mniejsze od number2");
}
else
{
    Console.WriteLine("number1 jest równe number2");
}

//zagnieżdźanie if i else
if (number1 > number2)
{
    Console.WriteLine("number1 jest większe od number2");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("number1 jest mniejsze od number2");
    }
    else
    {
        Console.WriteLine("number1 jest równe number2");
    }
}
*/
using System;
using System.ComponentModel.Design;

String name = "Ewa";
string plec = "K";
int wiek = 31;
if (plec == "K" && wiek <30)
{
    Console.WriteLine("Cześć " + name + " jesteś kobietą ponizej 30 lat");
}
else if (plec == "K" && wiek == 30 && name == "Ewa")
{
    Console.WriteLine("Cześć " + name + " Lat 30");
}



else if (plec == "M" && wiek < 18)
{
    Console.WriteLine("Cześć " + name + " jesteś mężczyzną ponizej 18 lat ");
}



else
{
    Console.WriteLine("");
}