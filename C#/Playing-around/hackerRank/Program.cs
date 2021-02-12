using System;
using System.Collections.Generic;
using System.Text;

namespace hackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(repeatedString("abca", 10));
            // var numbers = rotLeft(new int[] { 1, 2, 3, 4, 5 }, 1);
            //minimumBribes(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });
            //System.Console.WriteLine(firstRepeatedWord("He had had quite enough of this nonsense."));
            System.Console.WriteLine(CalculateVat(123.45, Convert.ToDateTime("2018-04-01")));

        }

        public static double CalculateVat(double amount, DateTime transactionDate)
        {
            int year = transactionDate.Year;
            int month =transactionDate.Month;
            if ((year >= 2018) && (month >= 4)) 
            {
                return amount * 0.15;
            } 
            else
            {
                return amount * 0.14;
            }
                
    }
        public static string firstRepeatedWord(string sentence)
        {
            List<string> words = new List<string>(sentence.Split(' ', ',', ':', ';', '-', '.'));

            var repeatedString = "";

            for (int i = 0; i < words.Count; i++)
            {
                var word = words[i];
                words.RemoveAt(i);

                if (words.IndexOf(word) >= 0)
                {
                    repeatedString = word;
                    i = words.Count;
                }


            }

            return repeatedString;
        }

        static void minimumBribes(int[] q)
        {
            var numBribe = 0;
            bool isChaotic = false;
            for (int i = 1; i <= q.Length; i++)
            {
                var orginalPos = q[i - 1];
                var currentPos = i;

                if (orginalPos > currentPos)
                {
                    if (orginalPos - currentPos >= 3) isChaotic = true;
                    else numBribe += (orginalPos - currentPos);

                }
            }

            var result = isChaotic ? "Too chaotic" : Convert.ToString(numBribe);
            System.Console.WriteLine(result);

        }
        static int[] rotLeft(int[] a, int d)
        {

            Queue<int> numbers = new Queue<int>(a);

            for (int i = 0; i < d; i++)
            {
                numbers.Enqueue(numbers.Dequeue());
            }


            return numbers.ToArray();
        }



        static long repeatedString(string s, long n)
        {

            var numOfLetterPerS = 0;

            var num = Math.Ceiling(n / (double)s.Length);

            foreach (char letter in s)
            {
                if (letter == 'a') numOfLetterPerS++;
            }

            var partResult = numOfLetterPerS * (num - 1);

            for (int i = 0; i < n - s.Length * (num - 1); i++)
            {
                if (s[i] == 'a') partResult++;
            }


            return Convert.ToInt64(partResult);
        }

        static int hourglassSum(int[,] arr)
        {
            var result = 0;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (arr[i, j] + arr[i, j - 1] + arr[i, j + 1] + arr[i - 1, j - 1] + arr[i + 1, j - 1] + arr[i - 1, j + 1] + arr[i + 1, j + 1] > result) result = arr[i - 1, j - 1];
                }
            }
            return result;
        }



    }


}
