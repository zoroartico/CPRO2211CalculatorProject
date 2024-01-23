namespace CPRO2211CalculatorProject.Models
{
    public class Calculator
    {
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
