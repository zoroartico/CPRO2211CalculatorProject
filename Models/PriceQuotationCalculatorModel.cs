namespace CPRO2211CalculatorProject.Models
{
    public class PriceQuotationCalculatorModel : CalculatorModel
    {
        private const int CONST = 100;
        public decimal getTotal(decimal price, decimal discount) => Multiply(price, discount);
        
        public decimal getDiscount(decimal price, decimal discount) => Subtract(price, getTotal(price, discount));
    }
}
