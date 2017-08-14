using Assignment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Student
    {
        public string Name
        {
            get;
            set;
        }
        public int RollNumber
        {
            get;
            set;
        }

        public int Marks
        {
            get;
            set;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            return this.GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ RollNumber^Marks;
        }
        public override string ToString()
        {
            return Name + " " + RollNumber;
        }
    }
}
