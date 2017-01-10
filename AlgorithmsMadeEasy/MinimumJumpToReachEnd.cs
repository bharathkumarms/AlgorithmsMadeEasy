using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class MinimumJumpToReachEnd
    {
        public void MinimumJumpToReachEndMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            int[] countArray = new int[iInput.Length];
            int[] jumpFrom = new int[iInput.Length];

            int forwardPointer = 1;
            int backwardPointer = 0;

            countArray[0] = 0;
            jumpFrom[0] = 0;

            while (forwardPointer < iInput.Length)
            {
                while (forwardPointer > backwardPointer)
                {
                    if (iInput[backwardPointer] + backwardPointer >= forwardPointer)
                    {
                        int val1 = countArray[forwardPointer];
                        int val2 = countArray[backwardPointer] + 1;

                        if (val1 <= 0)
                        {
                            countArray[forwardPointer] = val2;
                            jumpFrom[forwardPointer] = backwardPointer;
                        }
                        else
                        {
                            if (val1 > val2)
                            {
                                countArray[forwardPointer] = val2;
                                jumpFrom[forwardPointer] = backwardPointer;
                            }
                        }
                        backwardPointer++;
                    }
                    else
                    {
                        backwardPointer++;
                    }
                }
                forwardPointer++;
                backwardPointer = 0;
            }

            System.Console.WriteLine(countArray[iInput.Length - 1]);
            System.Console.ReadLine();
        }
    }
}

/*
 * Sample Input
2 3 1 1 2 4 2 0 1 1
*/