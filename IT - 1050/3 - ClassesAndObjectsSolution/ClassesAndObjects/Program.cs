using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Marie = new Person();
            Marie.name = "Marie";
            Marie.gender = "Female";
            Marie.age = 21;
            Marie.GPA = 3.7;

            Person Nate = new Person();
            Nate.name = "Nate";
            Nate.gender = "Male";
            Nate.age = 26;
            Nate.GPA = 3.5;

            //Does not create a new object. Simply points the object of 'oldestPerson' to the same 
                //memory location as the object 'Nate' 
            Person oldestPerson = Nate;

            //METHODS: 
            Console.WriteLine(Marie.GetPersonInfo());
            Console.WriteLine(Nate.GetPersonInfo());

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();


        }
    }
}
