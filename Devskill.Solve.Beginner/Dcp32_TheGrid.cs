using System;
using System.Collections.Generic;
using System.Text;

namespace Devskill.Solve.Beginner
{
    public class Dcp32_TheGrid
    {
        public void Solution()
        {
            int iNumOfTestCases = 31;

            while (iNumOfTestCases > 30)
            {
                var numOfTestCases = Console.ReadLine();
                iNumOfTestCases = Convert.ToInt32(numOfTestCases);

                if (iNumOfTestCases == 0)
                {
                    iNumOfTestCases = 31;
                }
            }

            for (int i = 0; i < iNumOfTestCases; i++)
            {
                var sInput = Console.ReadLine();
                Console.Write("Case " + (i + 1) + ": ");
                var sPoints = sInput.Split(' ');

                int[] points = new int[4];
                for (int j = 0; j < sPoints.Length; j++)
                {
                    points[j] = Convert.ToInt32(sPoints[j]);
                }

                try
                {
                    int leastDistance = (Math.Abs(points[0] - points[2]) + Math.Abs(points[1] - points[3]));
                    Console.WriteLine(leastDistance);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Cannot calculate leastDistance");
                }
            }
        }
    }
}
