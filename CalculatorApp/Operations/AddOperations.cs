using CalculatorApp.Operations;

public class AddOperation : IOperation
{
    public string Symbol => "+";

    public double Execute(double a, double b)
    {
        return a + b;
    }
}
