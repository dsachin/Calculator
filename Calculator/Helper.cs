using System;
using System.Linq;

namespace Calculator
{
    public static class Helper
    {
        private static bool isDelimeterPresent = false;
        public static int[] ValidateAndGetInputAsIntegers(string inputValues)
        {
            char delimiter = GetDelimiter(inputValues);
            inputValues = inputValues.Replace(Constants.NEWLINE, delimiter);

            if (isDelimeterPresent)
            {
                int lastIndexOfFormatter = inputValues.LastIndexOf('\\') + 1;
                inputValues = inputValues.Substring(lastIndexOfFormatter);
            }
            int[] inputNumbers = inputValues.Split(delimiter)
                                 .Select(n => Convert.ToInt32(n)).Where(n => n <= 1000).ToArray();

            int[] negativeNumbers = inputNumbers.Where(i => i < 0).ToArray();

            if (negativeNumbers.Length > 0)
            {
                string invalidValues = string.Join(", ", negativeNumbers);
                throw new Exception(string.Format("Error: Negative numbers ({0}) not allowed.", invalidValues));
            }
            return inputNumbers;
        }

        private static char GetDelimiter(string inputValues)
        {
            char delimiter = Constants.COMMA;
            if (inputValues.Contains("\\"))
            {
                int index = inputValues.IndexOf('\\');
                delimiter = Convert.ToChar(inputValues.Substring(index + 1, 1));
                isDelimeterPresent = true;
            }
            return delimiter;
        }
    }
}
