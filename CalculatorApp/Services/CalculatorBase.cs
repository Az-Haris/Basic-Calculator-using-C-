using CalculatorApp.Operations;

namespace CalculatorApp.Services
{
    public abstract class CalculatorBase : ICalculator
    {
        public virtual double Calculate(double a, double b, IOperation operation)
        {
            return operation.Execute(a, b);
        }
    }
}
