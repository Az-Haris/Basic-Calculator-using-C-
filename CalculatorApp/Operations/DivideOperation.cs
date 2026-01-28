using CalculatorApp.Operations;

public class DivideOperation : IOperation
{
    public string Symbol => "/";

    public double Execute(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");

        return a / b;
    }
}
