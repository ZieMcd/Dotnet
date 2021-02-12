using System;

namespace Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Zie","IT",2.5);
            Student student2 = new Student("Pam","Art",3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
