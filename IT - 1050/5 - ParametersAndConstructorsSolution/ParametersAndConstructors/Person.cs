using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndConstructors
{
    class Person
    {
        public string Name;
        public int Age;

        //Constructor: 
        //constructors are special methods that exist even if you don't define them (default constructor) 
        //they have the same name as the class and never contain a return type 
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;  
        }

        //Overloading: creating another version of the sae method with a different parameter list
        public Person()
        {
            //Allows users to define a Person object without specifying values for the member variables 
        }

        //Methods w/ Parameters: 
        public int AddTwoIntegers(int firstNum, int secondNum)
        {
            int sum =  firstNum + secondNum;
            Console.WriteLine(this.Name + " added " + firstNum + " and " + secondNum + " and got " + sum);
            return sum; 
        }

        public string Speak(string whatToSay)
        {
            Console.WriteLine(this.Name + " says " + whatToSay);
            return whatToSay;   
        }
    }
}
