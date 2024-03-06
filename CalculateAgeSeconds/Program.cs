using AgeCalculator;
using AgeCalculator.Extensions;

namespace CalculateAgeSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userAge;

            Console.WriteLine("Enter your age in this format - MM/DD/YYYY (For example: 08/20/2003)");
            userAge = Console.ReadLine();

            var dob = DateTime.Parse(userAge);
            var age = new Age(dob, DateTime.Today, true);
            Console.WriteLine($"Total Seconds alive: {age.TotalSeconds}");

            Console.ReadLine();
        }
    }
}