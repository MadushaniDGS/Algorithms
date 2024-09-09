using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28355
{
    public class BinarySearch
    {
        public int RecursiveBinarySearch(int[] inputs, int target, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }

            int mid = (start + end) / 2;
            if (inputs[mid] == target)
            {
                return mid;
            }
            else if (inputs[mid] > target)
            {
                return RecursiveBinarySearch(inputs, target, start, mid - 1);

            }
            else
            {
                return RecursiveBinarySearch(inputs, target, mid + 1, end);

            }

        }

        public int IterativeBinarySearch(int[] inputs, int target)
        {
           int start = 0;
            int end = inputs.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target == inputs[mid])
                {
                    return mid;
                }
                else if (target < inputs[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;

        }
    }
}
