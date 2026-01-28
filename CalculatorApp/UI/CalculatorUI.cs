using CalculatorApp.Services;
using CalculatorApp.Operations;

namespace CalculatorApp.UI
{
    public class CalculatorUI
    {
        private readonly ICalculator _calculator;

        public CalculatorUI()
        {
            _calculator = new BasicCalculator();
        }

        public void Start()
        {
            Console.WriteLine("==== OOP Calculator ====");

            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Choose operation (+ - * /): ");
                    string symbol = Console.ReadLine();

                    IOperation operation = GetOperation(symbol);

                    double result = _calculator.Calculate(a, b, operation);

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Write("Continue? (y/n): ");
                if (Console.ReadLine()?.ToLower() != "y")
                    break;
            }
        }

        private IOperation GetOperation(string symbol)
        {
            return symbol switch
            {
                "+" => new AddOperation(),
                "-" => new SubtractOperation(),
                "*" => new MultiplyOperation(),
                "/" => new DivideOperation(),
                _ => throw new Exception("Invalid operation")
            };
        }
    }
}
