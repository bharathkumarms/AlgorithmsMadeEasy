using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    //In Progress
    class OptimalStrategyGamePickFromEndsOfArray
    {
        public void OptimalStrategyGamePickFromEndsOfArrayMethod()
        {
            string inputArray = Console.ReadLine();
            string[] sInputArray = inputArray.Split(' ');
            int[] iInputArray = Array.ConvertAll(sInputArray, int.Parse);

            int length = iInputArray.Length;
            int[,][,] adjacencyMatrix = new int[length,length][,];
            int distance = 1;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        adjacencyMatrix[i, j] = new int[1, 2];
                        adjacencyMatrix[i, j][0, 0] = iInputArray[i];
                        adjacencyMatrix[i, j][0, 1] = 0;
                    }
                }
            }

            while (distance < length)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i < j && (i + distance) == j)
                        {
                            int val1 = iInputArray[i] + adjacencyMatrix[i + 1, j][0, 1];
                            int val2 = iInputArray[j] + adjacencyMatrix[i, j - 1][0, 1];
                            int max = val1 > val2 ? val1 : val2;

                            int leftOver = 0;

                            adjacencyMatrix[i, j] = new int[1, 2];

                            if (val1 > val2)
                            {
                                adjacencyMatrix[i, j][0, 0] = val1;
                                adjacencyMatrix[i, j][0, 1] = leftOver;
                                //adjacencyMatrix[i, j][0, 0] = max;
                                //adjacencyMatrix[i, j][0, 1] = adjacencyMatrix[i+1, j][0, 1];
                            }
                            else
                            {
                                adjacencyMatrix[i, j][0, 0] = val2;
                                adjacencyMatrix[i, j][0, 1] = leftOver;
                                //adjacencyMatrix[i, j][0, 0] = max;
                                //adjacencyMatrix[i, j][0, 1] = adjacencyMatrix[i, j-1][0, 1];
                            }
                        }
                    }
                }
                distance++;
            }
        }
    }
}

/*
Sample Input
3 9 1 2
*/