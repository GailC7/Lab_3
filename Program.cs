
using Lab_3;
using System;
using System.Collections;
using System.Numerics;

public class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        int option = 0;
        do
        {
            DisplayMenu();
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\n Hit Enter to return to menu");
            Console.ReadLine();
            Console.Clear();

        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("---------------Menu--------------");
        Console.WriteLine("1. Create a Person Profile");
        Console.WriteLine("2. Display all People Profiles");
        Console.WriteLine("3. Remove a Person");
        Console.WriteLine("4. Get a random last name");
        Console.WriteLine("5. Get a random SSN");
        Console.WriteLine("6. Get a random phone number");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("0. Exit");
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();

        switch (option)
        {
            case 0:
                Console.WriteLine("Byeee");
                break;

            case 1:
                people.Add(new Person());
                break;

            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;

            case 3:
                int i = 0;
                var choice = 0;
                Console.WriteLine("Select a profile to remove");
                foreach (Person p in people)
                {
                    Console.WriteLine((i + 1) + ": " + p.FirstName + p.LastName);
                }

                choice = Int32.Parse(Console.ReadLine());
                people.Remove(people[choice]);
                Console.Clear();

                break;

            case 4:
                var lastArray = Lab_3.LastName.GetValues(typeof(LastName));
                var value = (LastName)lastArray.GetValue(random.Next(lastArray.Length));
                Console.WriteLine(value.ToString());
                break;

            case 5:
                Person rand = people[random.Next(people.Count())];
                Console.WriteLine(rand.SSN);
                break;

            case 6:
                //Console.WriteLine(random.Next(phone);
                break;

            default:
                Console.WriteLine("Error");
                break;

        }

    }
}
    



