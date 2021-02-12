namespace Testability
{

    interface ICalculator 
    {
        int Add(int num1, int num2);
    }
    public class Calculator : ICalculator
    {
          public int Add(int num1, int num2)
          {
              return num1 + num2;
          }
         
    }
}