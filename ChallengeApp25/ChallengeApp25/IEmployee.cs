using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    // co ma byc zaimplementowane w klasie Employee
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade); // metoda dodajaca ocene
        void AddGrade(double grade); // metoda dodajaca ocene w formie double
        void AddGrade(int grade); // metoda dodajaca ocene w formie inta
        void AddGrade(char grade); // metoda dodajaca ocene w formie char      
     void AddGrade(string grade); // metoda dodajaca ocene w formie string (nie jest wymagana, ale moze byc przydatna)


        Statistics GetStatistics(); // metoda zwracajaca statystyki
    }
}
