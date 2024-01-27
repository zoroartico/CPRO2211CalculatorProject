namespace CPRO2211CalculatorProject.Models
{
    public class PriceQuotationModel : CalculatorModel
    {
        //method to get the total price after discount
        public decimal getTotal(decimal price, decimal discount) => Multiply(price, discount);

        //method to get the discounted amount as a dollar value
        public decimal getDiscount(decimal price, decimal discount) => Subtract(price, getTotal(price, discount));
    }
}
