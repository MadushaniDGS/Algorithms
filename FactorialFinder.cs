using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28355
{
    public class FactorialFinder
    {
        /// <summary>
        /// This method would find factorial for a given number
        /// </summary>
        /// <param name="number">A positive integer</param>
        /// <returns>Factorial</returns>
        public long RecursiveFactorial(int number)
        {
            if(number <= 1)
            {
                return 1L;       
            }
            return number * RecursiveFactorial(number - 1);
        }

        public long IterativeFactorial(int number)
        {
            long result = 1L;
            for (long i = number; i > 1; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
