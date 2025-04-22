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

int number = 4566;
int[] tablica = new int[10 ]; // deklaracja tablicy    
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;





foreach (char letter in letters)
{
    if(letter == '0')
    {
        counter0++;
    }
    else if (letter =='1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
    else
    {
        Console.WriteLine("Nieznany znak");
    }
    
       
        Console.WriteLine($"Liczba {counter0} występuje {counter0} razy");
     Console.WriteLine($"Liczba {counter1} występuje {counter1} razy");
    Console.WriteLine($"Liczba {counter2} występuje {counter2} razy");
    Console.WriteLine($"Liczba {counter3} występuje {counter3} razy");
    Console.WriteLine($"Liczba {counter4} występuje {counter4} razy");
    Console.WriteLine($"Liczba {counter5} występuje {counter5} razy");
    Console.WriteLine($"Liczba {counter6} występuje {counter6} razy");
    Console.WriteLine($"Liczba {counter7} występuje {counter7} razy");
    Console.WriteLine($"Liczba {counter8} występuje {counter8} razy");
    Console.WriteLine($"Liczba {counter9} występuje {counter9} razy");
    
    
}