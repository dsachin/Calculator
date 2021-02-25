using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
