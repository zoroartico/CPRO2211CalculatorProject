using System.ComponentModel.DataAnnotations;

namespace CPRO2211CalculatorProject.Models
{
    public class PriceQuotationModel : CalculatorModel
    {
        //setting attributes of the model
        [Required(ErrorMessage = ErrorMsg.EMPTY)]
        [Range(0.00, Int32.MaxValue, ErrorMessage = ErrorMsg.LESS_0)]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = ErrorMsg.EMPTY)]
        [Range(0, 100, ErrorMessage = ErrorMsg.RANGE_0_100)]
        public decimal? DiscountPercent { get; set; }

        //method to get the total price after discount
        public decimal? Discount() => Multiply(Price, Percent(DiscountPercent));

        //method to get the discounted amount as a dollar value
        public decimal? Total() => Subtract(Price, Discount());
    }
}
