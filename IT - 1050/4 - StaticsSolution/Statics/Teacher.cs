using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Teacher
    {
        //Member Variable - specific to each instance of a Teacher
        public string Name;

        //Static Variable - specific to the Class Teacher only 
        public static int Tally = 0;    //Does not exist on the instance objects of the class
                                        //Exists on the class itself - ONCE 

        //Static Method - 
        public static void SayHello()
        {
            //We have no access to the memeber variables inside of the static method
            Console.WriteLine("Hello, I am a Teacher."); 
        }
    }
}
