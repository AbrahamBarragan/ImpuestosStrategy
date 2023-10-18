namespace ImpuestosStrategy
{
    public class ShoppingCart
    {
        private ITaxCalculator _taxCalculator;

        public ShoppingCart(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public double CalculateTotalWithTax(double amount)
        {
            double tax = _taxCalculator.CalculateTax(amount);
            return amount + tax;
        }
    }
}
