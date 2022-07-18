using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConcepts.Mathematics
{
    /// <summary>
    /// Euclidian Algorithm for finding the greatest common divider (GDC) or HCF (highest common factor), given two natural numbers (a and b)
    /// </summary>
    public class GreatestCommonDivider
    {
        // https://www.youtube.com/watch?v=yHwneN6zJmU&ab_channel=NesoAcademy
        public static int FindGDC(int a, int b)
        {
            if (a < b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            return (b == 0) ? a : FindGDC(b, a % b);
        }
    }
}
