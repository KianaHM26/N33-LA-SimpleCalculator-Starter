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

                if (argOperation == "+" || argOperation.ToLower() == "plus")
                {
                    result = argFirstNumber + argSecondNumber;

                }
                else if (argOperation == "-" || argOperation.ToLower() == "minus")
                {
                    result = argFirstNumber - argSecondNumber;
                }
                else if (argOperation == "*" || argOperation.ToLower() == "time")
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

