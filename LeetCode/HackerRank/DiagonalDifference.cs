using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank
{
    /// <summary>
    /// <a href="https://www.hackerrank.com/challenges/one-week-preparation-kit-diagonal-difference/">Original question</a>
    /// </summary>
    public class DiagonalDifference
    {
        public static void Start()
        {
            List<List<int>> inputLst = new List<List<int>>();
            {
                inputLst.Add(new List<int>() { 1, 2, 3 });
                inputLst.Add(new List<int>() { 4, 5, 6 });
                inputLst.Add(new List<int>() { 9, 8, 9 });
            }

            int diagonalDifferenceFromList = GetDiagonalDifferenceFromBidemensionalList(inputLst);
            Console.WriteLine(diagonalDifferenceFromList);

            int[,] inputArr = new int[3, 3]
            {
               { 1, 2, 3 },
               { 4, 5, 6 },
               { 9, 8, 9 },
            };

            int diagonalDifferenceFromArr = GetDiagonalDifferenceFromBidemensionalArray(inputArr);
            Console.WriteLine(diagonalDifferenceFromArr);

        }

        private static int GetDiagonalDifferenceFromBidemensionalArray(int[,] arr)
        {
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;

            int dimensionSize = arr.GetLength(0);

            for (int line = 0; line < dimensionSize; line++)
            {
                int colLeft = line;
                int colRight = (dimensionSize - 1) - line;

                leftDiagonalSum += arr[line, colLeft];
                rightDiagonalSum += arr[line, colRight];
            }

            int diagonalDifference = Math.Abs(leftDiagonalSum - rightDiagonalSum);

            return diagonalDifference;

        }

        private static int GetDiagonalDifferenceFromBidemensionalList(List<List<int>> lst)
        {
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;
            for (int line = 0; line < lst.Count; line++)
            {
                int colLeft = line;
                int colRight = (lst.Count - 1) - line;

                leftDiagonalSum += lst[line][colLeft];
                rightDiagonalSum += lst[line][colRight];

            }

            int diagonalDifference = Math.Abs(leftDiagonalSum - rightDiagonalSum);

            return diagonalDifference;
        }
    }
}
