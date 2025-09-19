using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEngineLibrary.Properties;

namespace ClassEngineLibrary
{
        public class CalculatorEngine
        {
            public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
            {
                double result = 0;

                if (argOperation == "+" || argOperation.ToLower().Equals(LanguageResource.Plus))
                {
                Console.WriteLine("The words match in plus");
                result = argFirstNumber + argSecondNumber;

                }
                else if (argOperation == "-" || argOperation.ToLower().Equals(LanguageResource.Minus))
                {
                    Console.WriteLine("The words match in minus");
                result = argFirstNumber - argSecondNumber;
                }
                else if (argOperation == "*" || argOperation.ToLower().Equals(LanguageResource.Time))
                {
                    Console.WriteLine("The words match in time");
                result = argFirstNumber * argSecondNumber;
                }
                else if (argOperation == "/" || argOperation.ToLower().Equals(LanguageResource.DividedBy))
                {
                    Console.WriteLine("The words match in divided by");
                if (argSecondNumber != 0)
                        result = argFirstNumber / argSecondNumber;
                    else
                        throw new DivideByZeroException("Division by zero is not allowed.");
                }
                else
                {
                    throw new NoValidOperations("Invalid operation.");
                }

                return result;
            }
        }
    }

