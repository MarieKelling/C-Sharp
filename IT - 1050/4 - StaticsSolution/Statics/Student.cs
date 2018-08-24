using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Student
    {
        public string Name;
        public string Grade; 

        public static int Tally = 0;

        public static void SayHello()
        {
            Console.WriteLine("Hello, I am a Student."); 
        }
    }
}
