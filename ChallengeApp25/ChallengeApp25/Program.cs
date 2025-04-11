// See https://aka.ms/new-console-template for more information

//Tablice
//int[] tablica = new int[5]; // deklaracja tablicy
int[] grades = new int[365]; // deklaracja tablicy
List<string> dayOfWeeks = new List<string>(); 
dayOfWeeks.Add ( "poniedziałek");
dayOfWeeks.Add  ("wtorek");
dayOfWeeks.Add  ("środa");
dayOfWeeks.Add  ("czwartek");
dayOfWeeks.Add  ("piątek");
dayOfWeeks.Add  ("sobota");
dayOfWeeks.Add  ("niedziela");
//Console.WriteLine(dayOfWeeks[0]);




for (int i = 0; i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
    
}
foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}

