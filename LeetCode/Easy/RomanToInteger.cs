using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RomanToInteger
    {
        /// <summary>
        /// Runtime: 70ms
        /// </summary>
        internal static int MySolution(string s)
        {
            int result = 0;
            var romans = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000,
            };

            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i];
                var next = s.ElementAtOrDefault(i+1);

                if (romans.ContainsKey(next))
                {
                    if (romans[curr] < romans[next])
                    {
                        result -= (romans[curr]);
                        continue;
                    }
                }
                result += romans[curr];
            }

            return result;
        }

        /// <summary>
        /// Runtime: 64 ms
        /// </summary>
        internal static int OtherSolution(string s) 
        {
            int result = 0;
            var romans = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
     
            s = s.Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");

            foreach (char algarism in s)
            {
                result += romans[algarism];
            }

            return result;
        }

    }
}
