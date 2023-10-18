namespace ImpuestosStrategy
{
    public class CanadaTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.15;
        }
    }
}
