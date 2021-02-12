using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PlayingWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] fruits = new string[]
            // {
            //     "Apple","Mango","Strawberry","Date",
            //     "Banana","Avocado","Cherry","Grape",
            //     "Guava","Melon","Orange","Tomato"
            // };

            // var resultMethod = fruits.Where(f=> f.StartsWith("A"));

            // foreach (string fruit in resultMethod)
            // {
            //     System.Console.WriteLine(fruit);
            // }

            // var resultQuery = from f in fruits
            //                   where f.StartsWith("A")
            //                   select f;

            
            // foreach (string fruit in resultQuery)
            // {
            //     System.Console.WriteLine(fruit);
            // }

            List<Class> classes = new List<Class>();
            classes.Add(new Class { ClassID = 1, ClassName = "BSCS" });
            classes.Add(new Class { ClassID = 2, ClassName = "BSSE" });
            classes.Add(new Class { ClassID = 3, ClassName = "BSIT" });

            List<Student> students = new List<Student>();
            students.Add(new Student { ClassID = 1, StudentID = 1, StudentName= " harry " });
            students.Add(new Student { ClassID = 2, StudentID = 2, StudentName= "Zunaira" });
            students.Add(new Student { ClassID = 1, StudentID = 3, StudentName= "Zeeshan" });

            var joinResult = from std in students
                             join clas in classes on std.ClassID equals clas.ClassID
                             select  new {_Student = std.StudentName, _Class = clas.ClassName};
            
            foreach (var student in joinResult)
            {
                System.Console.WriteLine(student._Student +"\t" + student._Class);
            }

        }


    }

    class Class 
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int ClassID { get; set; }
    }
    
}
