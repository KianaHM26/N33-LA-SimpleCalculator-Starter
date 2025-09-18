using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEngineLibrary
{
        public class CalculatorEngine
        {
            public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
            {
                double result = 0;

                if (argOperation == "+" || argOperation.ToLower() == "add")
                {
                    result = argFirstNumber + argSecondNumber;

                }
                else if (argOperation == "-" || argOperation.ToLower() == "subtract")
                {
                    result = argFirstNumber - argSecondNumber;
                }
                else if (argOperation == "*" || argOperation.ToLower() == "multiply")
                {
                    result = argFirstNumber * argSecondNumber;
                }
                else if (argOperation == "/" || argOperation.ToLower() == "divide by")
                {
                    if (argSecondNumber != 0)
                        result = argFirstNumber / argSecondNumber;
                    else
                        throw new DivideByZeroException("Division by zero is not allowed.");
                }
                else
                {
                    throw new DivideByZeroException("Invalid operation.");
                }

                return result;
            }
        }
    }
}
