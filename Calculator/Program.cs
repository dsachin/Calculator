using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Uncomment following code to test program
                //args = new string[2];
                //args[0] = Operations.add.ToString();
                //args[1] = "1,2";
                //args[1] = "1,2\n4,5";
                //args[1] = "\\;\\1;2\n3;1017;5;6";

                if (args.Length >= 1)
                {
                    int result = 0;
                    int[] numbers = args.Length > 1 ? Helper.ValidateAndGetInputAsIntegers(args[1]) : null;

                    if (args != null && args[0] == Operations.add.ToString())
                    {
                        Calculate calculate = new Calculate();
                        result = calculate.CalculateSum(numbers);
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid Operation");
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    throw new InvalidOperationException("Invalid Arguments");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
