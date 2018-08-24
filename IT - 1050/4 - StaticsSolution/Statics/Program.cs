using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher Marie = new Teacher();
            Marie.Name = "Marie";
            Teacher.Tally++; 

            Student student1 = new Student();
            student1.Name = "Jane";
            student1.Grade = "A";

            Student student2 = new Student();
            student2.Name = "John";
            student2.Grade = "B";

            Console.WriteLine("Teachers: " + Teacher.Tally);
            Console.WriteLine("Students: " + Student.Tally);
            Console.WriteLine();
            //Any useful static methods???

        }
    }
}
