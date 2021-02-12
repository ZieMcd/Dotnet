using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int iNum1, iNum2;

                Console.Write("Enter a number : ");
                iNum1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter anothere number : ");
                iNum2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(iNum1 / iNum2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
               Console.WriteLine(e.Message);
            }

            
          /*  finally
            {

            } */



        }
    }
}
