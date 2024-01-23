namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculator : Calculator
    {
        //extending our calculator class to create specific methods for interfacing with our program.
        public double Tip(double total, double tipPercent) => Multiply(total, .01*tipPercent);
        public double TotalWithTip(double total, double tipPercent) => Add(total, Tip(total, tipPercent));

    }
}
