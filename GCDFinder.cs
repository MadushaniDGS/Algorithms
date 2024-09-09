using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28355
{
    public class GCDFinder
    {
        public int RecursiveGCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return RecursiveGCD(num2, num1 % num2);
        }
        public int IterationGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            return num1;
        }
            
    }
    
}
