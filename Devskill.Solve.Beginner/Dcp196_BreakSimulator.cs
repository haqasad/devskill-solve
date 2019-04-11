using System;
using System.Collections.Generic;
using System.Text;

namespace Devskill.Solve.Beginner
{
    public class Dcp196_BreakSimulator
    {
        public void Solution()
        {
            var finalVelocity = 0.0;
            var input1 = Console.ReadLine();
            int numOfTestCases = Convert.ToInt32(input1);

            for (int i = 0; i < numOfTestCases; i++)
            {
                var input2 = Console.ReadLine();
                var numbers = input2.Split(' ');

                var initialVelocity = Convert.ToDouble(numbers[0]);
                var time = Convert.ToDouble(numbers[1]);

                var deceleration = (finalVelocity - initialVelocity) / time;
                string formattedResult = $"{deceleration:F2}";
                Console.WriteLine(formattedResult);
            }
        }
    }
}
