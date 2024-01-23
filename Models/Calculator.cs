using Microsoft.CodeAnalysis.CSharp;

namespace CPRO2211CalculatorProject.Models
{
    public class Calculator
    {
        //creating a variety of methods that return the result of a varying qty of numbers after
        //performing mathmatical operations on them.
        public double Add(params double[] numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }
        public double Subtract(params double[] numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result -= number;
            }
            return result;
        }
        public double Multiply(params double[] numbers)
        {
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }
        public double Divide(params double[] numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                if (number == 0)
                    throw new ArgumentException("Divide by 0 error.");
                else if (result == 0)
                    result = number;
                else
                    result /= number;
            }        
            return result;
        }
    }
}
