using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, " +
                $"on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            */


            Class1 c = new Class1();
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.DayOfWeek}");

            if (Convert.ToString(currentDate.DayOfWeek) == "Wednesday")
            {
                c.display("wizz", "wuzz");
            }
            else
            { 
                c.display("fizz", "buzz");
            }
            

        }
       
    }


}