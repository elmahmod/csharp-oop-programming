
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Calculator
    {
        private float _result = 0;
        private float _lastNumber = 0;
        private bool _divisionByZeroError = false;

        private enum OperationType
        {
            Add,
            Subtract,
            Divide,
            Multiply,
            Clear
        }

        private OperationType _currentOperation = OperationType.Clear;

        private string GetOperationName()
        {
            switch (_currentOperation)
            {
                case OperationType.Add:
                    return "Adding";

                case OperationType.Subtract:
                    return "Subtracting";

                case OperationType.Multiply:
                    return "Multiplying";

                case OperationType.Divide:
                    return "Dividing";

                default:
                    return "Unknown";
            }
        }
        public void PrintResult()
        {
            if (_currentOperation == OperationType.Clear)
            {
                Console.WriteLine($"Result Cleared = {_result}");
                return;
            }

            if (_currentOperation == OperationType.Divide && _divisionByZeroError)
            {
                Console.WriteLine("Cannot Divide by 0!");
                return;
            }

            Console.WriteLine($"Result After {GetOperationName()} {_lastNumber} is: {_result}");
        }

        public void Clear()
        {
            _currentOperation = OperationType.Clear;
            _result = 0;
            _lastNumber = 0;
        }

        public void Add(float number)
        {
            _currentOperation = OperationType.Add;

            _lastNumber = number;
            _result += number;
        }

        public void Subtract(float number)
        {
            _currentOperation = OperationType.Subtract;

            _lastNumber = number;
            _result -= number;
        }

        public void Divide(float number)
        {
            _currentOperation = OperationType.Divide;

            if (number == 0)
            {
                _divisionByZeroError = true;
                return;
            }
            _divisionByZeroError = false;

            _lastNumber = number;
            _result /= number;
        }

        public void Multiply(float number)
        {
            _currentOperation = OperationType.Multiply;

            _lastNumber = number;
            _result *= number;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.Add(5);
            calculator.PrintResult();

            calculator.Add(10);
            calculator.PrintResult();

            calculator.Subtract(5);
            calculator.PrintResult();

            calculator.Multiply(3);
            calculator.PrintResult();

            calculator.Divide(0);
            calculator.PrintResult();

            calculator.Add(1);
            calculator.PrintResult();

            calculator.Clear();
            calculator.PrintResult();
        }
    }
}
