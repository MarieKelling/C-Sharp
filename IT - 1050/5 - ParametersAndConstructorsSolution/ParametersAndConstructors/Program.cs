using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Used the defined constructor we created
            Person marie = new Person("Marie", 21);

            //Uses the default constructor
            Person brandon = new Person();
            brandon.Name = "Brandon";
            brandon.Age = 21; 

            int sum1 = marie.AddTwoIntegers(2, 3);
            int sum2 = brandon.AddTwoIntegers(5, 5);

            Console.WriteLine(); 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
