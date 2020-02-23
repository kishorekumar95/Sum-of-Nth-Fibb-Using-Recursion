using System;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public static int SumOfFibNumbers(int number)
        {
            var temp = 0;
            for(int i = 1; i <= number; i++)
            {
                temp += FindNthFib(i);
            }
            return temp;
        }

        public static int FindNthFib(int number)
        {
            if (number >= 3)
            {
                return FindNthFib(number - 1) + FindNthFib(number - 2);
            }
            else
            {
                return 1;
            }
        }
    }
}
