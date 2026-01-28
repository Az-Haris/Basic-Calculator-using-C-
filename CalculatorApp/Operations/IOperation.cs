namespace CalculatorApp.Operations
{
    public interface IOperation
    {
        double Execute(double a, double b);
        string Symbol { get; }
    }
}
