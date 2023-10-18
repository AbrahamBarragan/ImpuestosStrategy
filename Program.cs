using ImpuestosStrategy;

class Program
{
    static void Main(string[] args)
    {
        
        ITaxCalculator usaTaxCalculator = new USATaxCalculator();
        ShoppingCart usaCart = new ShoppingCart(usaTaxCalculator);
        double usaTotal = usaCart.CalculateTotalWithTax(100);
        Console.WriteLine($"Total con impuestos para USA: {usaTotal}");

        
        ITaxCalculator canadaTaxCalculator = new CanadaTaxCalculator();
        ShoppingCart canadaCart = new ShoppingCart(canadaTaxCalculator);
        double canadaTotal = canadaCart.CalculateTotalWithTax(100);
        Console.WriteLine($"Total con impuestos para Canadá: {canadaTotal}");

        Console.ReadKey();
    }
}