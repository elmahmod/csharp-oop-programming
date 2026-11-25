
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

        // Enum
        private enum OperationType
        {
            Add,
            Subtract,
            Divide,
            Multiply,
            Clear
        }

        private OperationType _currentOperation = OperationType.Clear;

        public void PrintResult()
        {
            switch (_currentOperation)
            {
                case OperationType.Add:
                    Console.WriteLine($"Result After Adding {_lastNumber} is : {_result}");
                    break;

                case OperationType.Subtract:
                    Console.WriteLine($"Result After Subtracting {_lastNumber} is : {_result}");
                    break;

                case OperationType.Multiply:
                    Console.WriteLine($"Result After Multiplying {_lastNumber} is : {_result}");
                    break;

                case OperationType.Divide:
                    if (_divisionByZeroError)
                    {
                        Console.WriteLine("Cannot Divide by 0!");
                        return;
                    }

                    Console.WriteLine($"Result After Dividing {_lastNumber} is : {_result}");
                    break;

                case OperationType.Clear:
                    Console.WriteLine($"Result Cleared = {_result}");
                    break;
            }
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
