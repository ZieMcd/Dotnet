using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Methods
{
    class Student
    {
        public string sName;
        public string sSubject;
        public double dGpa;

        public Student(string aName, string aSubject, double aGpa)
        {
            sName = aName;
            sSubject = aSubject;
            dGpa = aGpa;
        }

        public bool HasHonors()
        {
            if (dGpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
