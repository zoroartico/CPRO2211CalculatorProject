using System.ComponentModel.DataAnnotations;

namespace CPRO2211CalculatorProject.Models
{
    public class TipCalculatorModel : CalculatorModel
    {
        
        [Required(ErrorMessage = ErrorMsg.EMPTY)]
        [Range(0.00,Int32.MaxValue, ErrorMessage = ErrorMsg.LESS_0)]
        public decimal Total { get; set; }
        //extending our calculator class to create specific methods for interfacing with our program.
        public decimal Tip(decimal tipPercent) => Multiply(Total, Percent(tipPercent));
        //public double TotalWithTip() => Add(Total, Tip());

    }
}
