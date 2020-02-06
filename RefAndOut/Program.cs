using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // get 1st name and say hello
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            string message = MakeGreeting(firstName);
            Console.WriteLine(message);

            // get last name and make full name
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            int nameLength = FullName(firstName, lastName, out string fullName);
            Console.WriteLine("Your full name is " + fullName + "! It has " + nameLength + " letters.");

            // put fullname in all caps
            Capitalize(ref fullName);
            Console.WriteLine("Your name in upper case: " + fullName);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static string MakeGreeting(string name)
        {
            string greeting = "Hello, " + name + "!";
            return greeting;
        }

        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length - 1; // -1 because space isn't a letter
        }

        static void Capitalize(ref string fullName)
        {
            fullName = fullName.ToUpper();
        }
    }
}
