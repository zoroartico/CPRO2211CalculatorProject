namespace CPRO2211CalculatorProject.Models
{
    public class PriceQuotationModel : CalculatorModel
    {
        //setting attributes of the model
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        //method to get the total price after discount
        public decimal Total() => Multiply(Price, DiscountPercent);

        //method to get the discounted amount as a dollar value
        public decimal Discount() => Subtract(Price, Total());
    }
}
