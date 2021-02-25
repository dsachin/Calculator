using System;
using System.Linq;

namespace Calculator
{
    public static class Helper
    {
        public static int[] ValidateAndGetInputAsIntegers(string inputValues)
        {
            inputValues = inputValues.Replace(Constants.NEWLINE, Constants.COMMA);

            int[] inputNumbers = inputValues.Split(Constants.COMMA)
                                    .Select(n => Convert.ToInt32(n)).ToArray();

            return inputNumbers;
        }
    }
}
