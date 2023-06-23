using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Datastructure
{
    internal class FindHighestValue
    {
        public int FindTheLargestValue(int[] arr)
        {
            var length = arr.Length;
            var max = arr[0];

            for (int i = 1; i < length; i++)
            {
                var temp = arr[i];

                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }
    }
}
