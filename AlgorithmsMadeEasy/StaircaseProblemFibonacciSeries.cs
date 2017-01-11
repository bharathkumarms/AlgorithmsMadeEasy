using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class StaircaseProblemFibonacciSeries
    {
        private static int longestStep;
        private static int iTotalSteps;

        public void StaircaseProblemFibonacciSeriesMethod()
        {
            var n = System.Console.ReadLine();
            longestStep = int.Parse(n);//This would be 2

            var totalSteps = System.Console.ReadLine();
            iTotalSteps = int.Parse(totalSteps);

            int output = SolveStaircaseProblem(iTotalSteps);
            System.Console.WriteLine(output);
            System.Console.ReadLine();
        }

        public static int SolveStaircaseProblem(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }

            return SolveStaircaseProblem(n - 1) + SolveStaircaseProblem(n - 2);
        }
    }
}
