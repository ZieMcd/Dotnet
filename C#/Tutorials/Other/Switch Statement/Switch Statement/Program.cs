using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum;

            Console.Write("Enter a Number: ");
            iNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetDay(iNum));
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wensday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saterday";
                    break;
                default:
                    dayName = "invalid";
                    break;
            }

            return dayName;
        }
    }
}
