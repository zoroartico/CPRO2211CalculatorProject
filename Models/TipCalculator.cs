namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculator : Calculator
    {
        public double Total { get; set; }
        public double TipPercent { get; set; }
        //extending our calculator class to create specific methods for interfacing with our program.
        public double Tip() => Multiply(Total, .01* TipPercent);
        public double TotalWithTip() => Add(Total, Tip());

    }
}
