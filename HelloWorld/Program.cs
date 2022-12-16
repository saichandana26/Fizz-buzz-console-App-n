using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
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