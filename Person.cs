using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Person
    {
        private string[] arrayOfFirstNames = new string[] {
                "Tim", "Carly", "Zane", "Becky", "Harris", "Lizzy", "Westley", "Paris", "Sam",
                "Veronica" };
        //private Dependent[] dependents;

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }

        public Person()
        {
            Random rand = new Random();
            FirstName = arrayOfFirstNames[rand.Next(arrayOfFirstNames.Length)];

            var lastArray = Lab3.LastName.GetValues(typeof(LastName));
            var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
            this.LastName = value.ToString();

            DateTime dateToday = DateTime.Now;

            int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);

            BirthDate = new DateTime(year, month, day);

            this.SSN = new SSN();

            this.Phone = new Phone();
        }

        public int GetAge()
        {
            var age = DateTime.Now - BirthDate;
            return age.Days / 365;
        }

        public override string ToString()
        {
            return
                $"-----------------------------------------\n" +
                $"Name:\t\t{FirstName} {LastName}\n" +
                $"Birthday:\t{BirthDate.ToShortDateString()}\n" +
                $"Age:\t\t{GetAge()}\n" +
                $"SSN:\t\t{SSN}\n" +
                $"Phone:\t\t{Phone.Number}\n" +
                $"-----------------------------------------\n";
        }
    }
}
