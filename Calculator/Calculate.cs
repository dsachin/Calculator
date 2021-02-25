using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public int CalculateSum()
        {
            return 0;
        }
        public int CalculateSum(int num)
        {
            return num;
        }
        public int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
