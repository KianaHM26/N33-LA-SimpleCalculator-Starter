using System;
using System.Text;
using ClassEngineLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double? firstNumber;
                double? secondNumber;
                string operation;
                bool isValid = false;

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                do
                {
                    Console.WriteLine("Write a valid first number : ");
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Write a valid second number : ");
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Write a valid operation (+, -, *, /) or (plus , minus, time, divide by)");
                    operation = Console.ReadLine();

                    if(operation.Equals('+') || operation.Equals('-') || operation.Equals('*') || operation.Equals('/'))
                    {
                        isValid = true;
                    }
                    else if (operation.ToLower().Equals("plus") || operation.ToLower().Equals("minus") || operation.ToLower().Equals("time") || operation.Equals("divided by"))
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                } while (!firstNumber.HasValue && !secondNumber.HasValue && !isValid);


                StringBuilder sb = new StringBuilder();
                sb.Append("Value: ").Append(firstNumber.Value);
                sb.Append(" Operation: ").Append(operation);
                sb.Append(" Value: ").Append(secondNumber.Value);
                Console.WriteLine(sb.ToString());


                double result = calculatorEngine.Calculate(operation, firstNumber.Value, secondNumber.Value);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
