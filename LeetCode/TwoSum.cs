using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        // Cut a loop, bish!
        public int[] TwoSumSolution(int[] nums, int target)
        {
            var possibleNumbers = nums.Where(number => number <= target)
                .ToArray();

            var resultIndexes = new List<int>();

            for (int i = 0; i < possibleNumbers.Length; i++)
            {
                if (possibleNumbers[i] > target)
                    continue;
                for (int j = i+1; i < possibleNumbers.Length; j++)
                {
                    if (possibleNumbers[i] + possibleNumbers[j] == target)
                    {
                        resultIndexes.Add(i);
                        resultIndexes.Add(j);
                        break;
                    }

                }
            }

            return resultIndexes.ToArray();
        }
        //TODO
        public void TwoSumOptimalSolution(int[] nums, int target)
        {
            // n1 + n2 = target | target - n1 = n2
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
            }
        }
    }
}
