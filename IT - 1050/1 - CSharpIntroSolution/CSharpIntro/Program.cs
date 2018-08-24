using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Hello World to console 
            Console.WriteLine("Hello World.");

            //ReadLine reads string input from the user
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " it is very nice to meet you.");
            Console.ReadKey();

            //Read an int from the console - Parse vs TryParse?? 
            Console.WriteLine("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old");
            Console.ReadKey();
        }
    }
}
