using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2;

namespace Assignment2UnitTestProject
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void ReflexiveTest()
        {
            var student = new Student { RollNumber=501,Name="Sachin",Marks=500};
            Assert.IsTrue(student.Equals(student));
        }

        [TestMethod]
        public void SymmetricTest()
        {
            var student1 = new Student { RollNumber = 501, Name = "Sachin",Marks = 600 };
            var student2 = new Student { RollNumber = 501, Name = "Sachin", Marks = 600 };
            Assert.IsTrue(student1.Equals(student2));
            Assert.IsTrue(student2.Equals(student1));
        }
        [TestMethod]
        public void TransitiveTest()
        {
            var student1 = new Student { RollNumber = 501, Name = "Sachin", Marks = 600 };
            var student2 = new Student { RollNumber = 501, Name = "Sachin", Marks = 600 };
            var student3 = new Student { RollNumber = 501, Name = "Sachin", Marks = 600 };
            Assert.IsTrue(student1.Equals(student2));
            Assert.IsTrue(student2.Equals(student3));
            Assert.IsTrue(student1.Equals(student3));
        }

        [TestMethod]
        public void AddInDictionary_Test()
        {
            TestStudentData();
            Assert.IsNotNull(DictionaryClass.StudentDict);
        }
        [TestMethod]
        public void UpdateDictionary_Test ()
        {
            TestStudentData();
            var student = new Student { RollNumber = 104, Name = "Sachin", };
             DictionaryClass.StudentDict[student]=10;
            Assert.AreEqual(DictionaryClass.StudentDict[student],10);
        }

        public void DeleteFromeDictionary_Test()
        {
            TestStudentData();
            var student = new Student { RollNumber = 104, Name = "Sachin", };
            DictionaryClass.StudentDict.Remove(student);
            Assert.IsFalse(DictionaryClass.StudentDict.ContainsKey(student));
            
        }
        public void TestStudentData()
        {
            var student = new Student();
            var student1 = new Student { RollNumber = 101, Name = "Sachin", };
            var student2 = new Student { RollNumber = 102, Name = "Sachin", };
            var student3 = new Student { RollNumber = 103, Name = "Sachin", };
            var student4 = new Student { RollNumber = 104, Name = "Sachin", };
            DictionaryClass.StudentDict.Add(student1, 1);
            DictionaryClass.StudentDict.Add(student2, 2);
            DictionaryClass.StudentDict.Add(student3, 3);
            DictionaryClass.StudentDict.Add(student4, 4);
        }
    }
}
