using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class PlusOne
    {
        public static int[] MySolution(int[] digits)
        {
            if(digits.Length == 0)
                return new int[] {1};

            var result = new List<int>(digits);
            result.Reverse();

            int i = 0;
            result[0] += 1;
            while (result[i] == 10)
            {
                if (i + 1 >= result.Count) 
                    result.Add(0);

                result[i] = 0;
                result[i+1] += 1;
                i++;
            }
            result.Reverse();
            return result.ToArray();
        }

        // Not mine!
        public static int[] BetterSolution(int[] digits)
        {
            for(int i = digits.Length-1; i>= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}
