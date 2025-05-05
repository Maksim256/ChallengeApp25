using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25
{
    public class Employee
    {
        private string imie { get; set; }
        private string nazwisko { get; set; }
        private int wiek { get; set; }

        private List<int> punkty = new List<int>();
        public Employee()
        {
            this.imie = "-";
            this.nazwisko = "-";
            this.wiek = 0;
        }
        public Employee(string imie, string nazwisko, int wiek )
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public Employee(string imie)
        {
            this.imie = imie;
            
        }
        public string Imie
        {
            get { return this.imie; }
            set { this.imie = value; }
        }
        public string Nazwisko
        {
            get { return this.nazwisko; }
            set { this.nazwisko = value; }
        }
        public int Wiek
        {
            get { return this.wiek; }
            set { this.wiek = value; }
        }

        public int Punkty
        {
            get
            {
                return this.punkty.Sum();
            }
        }
        public void DodajPunkty(int punkty)
        {
            
            this.punkty.Add(punkty);
        }
        public void OdejmijPunkty(int punkty)
        {
            this.punkty.Add(-punkty);
        }

    }
}
