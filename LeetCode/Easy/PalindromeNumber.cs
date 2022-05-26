using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class PalindromeNumber
    {
        public static bool MySolution(int x)
        {
            if (x == 0) return false;
            
            var numberString = x.ToString();
            StringBuilder sbReverse = new();
            var reverseNumberString = numberString.Reverse();

            foreach (char digit in reverseNumberString)
                sbReverse.Append(digit);

            return numberString == sbReverse.ToString();
        }

        public static bool SolutionWithoutConverting(int x)
        {
            if (x == 0) return false;
            
            int reverse = 0;
            for (int i = x; i >= 1; i /= 10)
                reverse = (reverse * 10) + (i % 10);
            
            return reverse == x;
        }

    }
}
