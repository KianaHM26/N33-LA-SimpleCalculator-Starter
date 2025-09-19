using System;
using System.Linq;
using System.Text;
using ClassEngineLibrary;
using ClassEngineLibrary.Properties;


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
                    Console.Write(LanguageResource.ValidFirstNumber);
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.Write(LanguageResource.ValidSecondNumber);
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.Write(LanguageResource.ValidOp);
                    operation = Console.ReadLine();

                    operation = operation.Trim();
                    // Check if operation is valid
                    if (operation.Equals('+') || operation.Equals('-') || operation.Equals('*') || operation.Equals('/'))
                    {
                        isValid = true;
                    }
                    else if (operation.ToLower().Equals(LanguageResource.Plus) || operation.ToLower().Equals(LanguageResource.Minus) || operation.ToLower().Equals(LanguageResource.Time) || operation.Equals(LanguageResource.DividedBy))
                    {
                        Console.WriteLine("The words match");
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                } while (!firstNumber.HasValue && !secondNumber.HasValue && !isValid);

                double result = calculatorEngine.Calculate(operation, firstNumber.Value, secondNumber.Value);

                StringBuilder sb = new StringBuilder();
                sb.Append(firstNumber.Value)
                  .Append(" ")
                  .Append(operation)
                  .Append(" ")
                  .Append(secondNumber.Value)
                  .Append(" = ")
                  .Append(result);
                

                Console.WriteLine(sb.ToString());

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
