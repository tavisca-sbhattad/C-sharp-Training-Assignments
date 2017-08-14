using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student { RollNumber = 101, Name = "Sachin" };
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }

      
    }
    
}
