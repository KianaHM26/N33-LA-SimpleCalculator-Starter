using System;


namespace SimpleCalculator
{
    public class InputConverter
    {
        static public double? ConvertInputToNumeric(string argTextInput)
        {
            double result;
            if (double.TryParse(argTextInput, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
