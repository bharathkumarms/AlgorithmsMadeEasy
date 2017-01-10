using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class MinimumCostPathInMatrix
    {
        public void MinimumCostPathInMatrixmethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int row = int.Parse(sInput[0]);
            int column = int.Parse(sInput[1]);

            int[,] inputMatrix = new int[row, column];
            int[,] outputMatrix = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                var subInput = System.Console.ReadLine();
                string[] sSubInput = subInput.Split(' ');
                int[] iSubInput = Array.ConvertAll(sSubInput, int.Parse);

                for (int j = 0; j < iSubInput.Length; j++)
                {
                    inputMatrix[i, j] = iSubInput[j];
                }
            }

            for (int k = 0; k < row; k++)
            {
                for (int l = 0; l < column; l++)
                {
                    if (k == 0 && l == 0)
                    {
                        outputMatrix[k, l] = inputMatrix[k, l];
                        continue;
                    }
                    if (k == 0)
                    {
                        outputMatrix[k, l] = outputMatrix[k, l - 1] + inputMatrix[k, l];
                        continue;
                    }

                    if (l == 0)
                    {
                        outputMatrix[k, l] = outputMatrix[k - 1, l] + inputMatrix[k, l];
                        continue;
                    }

                    int val1 = outputMatrix[k - 1, l];
                    int val2 = outputMatrix[k, l - 1];

                    if (val1 < val2)
                    {
                        outputMatrix[k, l] = inputMatrix[k, l] + val1;
                    }
                    else
                    {
                        outputMatrix[k, l] = inputMatrix[k, l] + val2;
                    }
                }
            }

            System.Console.WriteLine(outputMatrix[row - 1, column - 1]);
            System.Console.ReadLine();
        }
    }
}

/*
 * Sample Input
3 4
1 3 5 8
4 2 1 7
4 3 2 3
*/