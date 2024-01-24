using Microsoft.CodeAnalysis.CSharp;

namespace CPRO2211CalculatorProject.Models
{
    public class Calculator
    {
        //checking if the inputed variables are null or empty, then throwing an error.
        public void Validate(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException(ErrorMsg.EMPTY);
        }

        //creating a variety of methods that return the result of a varying qty of numbers after
        //performing mathmatical operations on them.
        public double Add(params double[] numbers)
        {
            Validate(numbers);
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        public double Subtract(params double[] numbers)
        {
            Validate(numbers);
            double result = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public double Multiply(params double[] numbers)
        {
            Validate(numbers);
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
        public double Divide(params double[] numbers)
        {
            Validate(numbers);
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                    throw new ArgumentException(ErrorMsg.DIV_0);
                result /= numbers[i];
            }        
            return result;
        }
        
    }
}
