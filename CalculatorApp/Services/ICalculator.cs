using CalculatorApp.Operations;

namespace CalculatorApp.Services
{
    public interface ICalculator
    {
        double Calculate(double a, double b, IOperation operation);
    }
}
