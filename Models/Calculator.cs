namespace CPRO2211CalculatorProject.Models
{
    public class Calculator
    {
        public double Add(double a, double b) 
        {
            IsDoubles(a, b);
            return a + b; 
        }
        public double Subtract(double a, double b)
        {
            IsDoubles(a, b);
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            IsDoubles(a, b);
            return a * b;
        }
        public double Divide(double a, double b)
        {
            IsDoubles(a, b);
            if (b == 0)
                throw new ArgumentException("Divide by 0 error.");
            return a / b;
        }

        public void IsDoubles(params double[] nums)
        {
           foreach (double num in nums)
           {
               if (double.IsNaN(num) || double.IsInfinity(num))
                   throw new ArgumentException($"\"{num}\" is invalid.");
           }
        }
    }
}
