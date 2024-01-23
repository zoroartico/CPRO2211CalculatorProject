namespace CPRO2211CalculatorProject.Models
{
    public class Calculator
    {
        //creating a variety of methods that return the result of two numbers after performing mathmatical operations on them.
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Divide by 0 error.");
            return a / b;
        }
    }
}
