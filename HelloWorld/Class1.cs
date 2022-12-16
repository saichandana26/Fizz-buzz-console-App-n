using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class1
    {
       
        public void display(string a, string b)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number entered is :" + n);
            Console.WriteLine($"{Environment.NewLine}");
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 & i % 5 == 0) { Console.WriteLine(a+b); continue; }
                if (i % 3 == 0) { Console.WriteLine(a); continue; }
                if (i % 5 == 0) { Console.WriteLine(b); continue; }
                Console.WriteLine(i);
            }
        }

    }
}
