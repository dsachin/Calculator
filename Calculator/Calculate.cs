namespace Calculator
{
    class Calculate
    {

        public int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public int CalculateMultiplication(int[] numbers)
        {
            int multiplication = 0;
            if (numbers != null)
            {
                multiplication = 1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    multiplication *= numbers[i];
                }
            }
            return multiplication;
        }
    }
}
