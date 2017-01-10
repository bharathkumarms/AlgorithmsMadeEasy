using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class WeightedJobScheduling
    {
        public void WeightedJobSchedulingMethod()
        {
            var jobCount = System.Console.ReadLine().Trim();
            int iJobCount = int.Parse(jobCount);

            int[,] jobDetails = new int[iJobCount, 2];
            int[] costDetails = new int[iJobCount];
            int[] tempArray = new int[iJobCount];

            for (int i = 0; i < iJobCount; i++)
            {
                var value = System.Console.ReadLine();
                string[] sValue = value.Split(' ');
                int[] iValue = Array.ConvertAll(sValue, int.Parse);

                jobDetails[i, 0] = iValue[0];
                jobDetails[i, 1] = iValue[1];
                costDetails[i] = iValue[2];
                tempArray[i] = iValue[2];
            }

            int forwardPointer = 1;
            int backwardPointer = 0;

            while (forwardPointer < iJobCount)
            {
                if (jobDetails[backwardPointer, 1] > jobDetails[forwardPointer, 0])
                {
                    forwardPointer++;
                    backwardPointer = 0;
                }
                else
                {
                    tempArray[forwardPointer] = costDetails[forwardPointer] + tempArray[backwardPointer];
                    backwardPointer++;
                }
            }

            int maxjob = tempArray[0];

            for (int i = 1; i < tempArray.Length; i++)
            {
                if (tempArray[i] > maxjob)
                {
                    maxjob = tempArray[i];
                }
            }

            System.Console.WriteLine(maxjob);
            System.Console.ReadLine();
        }
    }
}

/*
 * Input Details:
6
1 3 5
2 5 6
4 6 5
6 7 4
5 8 11
7 9 2
*/

/*
 * Note:
The job end time is already sorted by non decreasing order.
*/