using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Person
    {
        public DateTime Brithday { get;  private set; }
        public string Name { get; set; } //prop + tab * 2


        public Person(DateTime abirthday)
        {
            Brithday = abirthday;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Brithday;
                var year = timeSpan.Days / 365;

                return year;
            }
        }
    }
}
