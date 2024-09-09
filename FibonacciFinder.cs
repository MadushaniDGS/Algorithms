using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28355
{
    public class FibonacciFinder
    {
        public long RecursiveFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            return RecursiveFibonacci(number - 1) + RecursiveFibonacci(number - 2);
        }

        public long IterativeFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            int currentFib = 1;
            int previousFib = 1;

            for (int i = 2; i < number; i++)
            {
                int temp = currentFib;
                currentFib = currentFib + previousFib;
                previousFib = temp;
            }
            return currentFib;
        }
    }
}
