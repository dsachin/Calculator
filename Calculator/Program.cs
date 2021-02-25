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


                if (args.Length >= 1)
                {
                    int result = 0;
                    int[] numbers = args.Length > 1?args[1].Split(',').Select(n => Convert.ToInt32(n)).ToArray():null;

                    if (args != null && args[0] == Operations.add.ToString())
                    {
                        Calculate calculate = new Calculate();
                        if (numbers==null)
                        {
                            result = calculate.CalculateSum();
                        }
                        else if (numbers.Length == 1)
                        {
                            result = calculate.CalculateSum(numbers[0]);
                        }
                        else if (numbers.Length == 2)
                        {
                            result = calculate.CalculateSum(numbers[0], numbers[1]);
                        }
                        else
                        {
                            throw new Exception("Invalid arguments.");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid Operation");
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    throw new InvalidOperationException("Invalid Operation");
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
