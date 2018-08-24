using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Person
    {
        //Classes - should start w/ capital, not plural, represent the abstract form of the object your are creating. 
        //A 1 to many blueprint to create instances 

        //Member / Instance Varibale Declarations: 
        public string name;
        public string gender; 
        public int age;
        public double GPA;  

        //Member Methods: 
        public string GetPersonInfo()
        {
            return this.name + " is a " + this.gender + " who is " + this.age + " years old with a " + this.GPA + " GPA."; 
        }

        //Constructor

    }
}
