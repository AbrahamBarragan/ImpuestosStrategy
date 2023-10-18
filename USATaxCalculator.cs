namespace ImpuestosStrategy
{
    public class USATaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.08;
        }
    }
}
