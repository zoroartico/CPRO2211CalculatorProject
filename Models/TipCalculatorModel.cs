using System.ComponentModel.DataAnnotations;

namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculatorModel : CalculatorModel
    {
        
        [Required(ErrorMessage = "Total required.")]
        [Range(0.00,Int32.MaxValue, ErrorMessage = "Total cannot be negative.")]
        public decimal Total { get; set; }
        //extending our calculator class to create specific methods for interfacing with our program.
        public decimal Tip(decimal tipPercent) => Multiply(Total, tipPercent);
        //public double TotalWithTip() => Add(Total, Tip());

    }
}
