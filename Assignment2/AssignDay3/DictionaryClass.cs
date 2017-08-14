using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class DictionaryClass
    {
        private static Dictionary<Student, int> studDict = new Dictionary<Student, int>();

        public static Dictionary<Student, int> StudentDict
        {
            get
            {
                return studDict;
            }
            set
            {
                studDict = value;
            }
        }
    }
}
