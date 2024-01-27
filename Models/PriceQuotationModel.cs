using System.ComponentModel.DataAnnotations;

namespace CPRO2211CalculatorProject.Models
{
    public class PriceQuotationModel : CalculatorModel
    {
        //setting attributes of the model
        [Required(ErrorMessage = ErrorMsg.EMPTY)]
        [Range(0, 999999999999, ErrorMessage = ErrorMsg.LESS_0)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = ErrorMsg.EMPTY)]
        [Range(0, 100, ErrorMessage = ErrorMsg.RANGE_0_100)]

        public decimal DiscountPercent { get; set; }
        //method to get the total price after discount
        public decimal Total() => Multiply(Price, DiscountPercent);

        //method to get the discounted amount as a dollar value
        public decimal Discount() => Subtract(Price, Total());
    }
}
