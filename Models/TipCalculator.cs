namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculator : Calculator
    {
        public decimal Total { get; set; }
        public decimal TipPercent { get; set; }
        //extending our calculator class to create specific methods for interfacing with our program.
        public decimal Tip() => Multiply(Total, .01* TipPercent);

        //public double TotalWithTip() => Add(Total, Tip());

    }
}
