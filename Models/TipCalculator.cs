namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculator : Calculator
    {
        public double Tip(double total, double tipPercent) => Multiply(total, tipPercent);
        public double TotalWithTip(double total, double tipPercent) => Add(total, Tip(total, tipPercent));
    }
}
