using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class CuttingRod
    {
        public void CuttingRodMethod()
        {

            var sellingLength = System.Console.ReadLine();
            int iSellingLength = int.Parse(sellingLength);

            var lengthsAvailable = System.Console.ReadLine();
            string[] slengthsAvailable = lengthsAvailable.Split(' ');
            int[] iLenghtsAvailable = Array.ConvertAll(slengthsAvailable, int.Parse);

            var costOfLengths = System.Console.ReadLine();
            string[] sCostOfLengths = costOfLengths.Split(' ');
            int[] iCostOfLengths = Array.ConvertAll(sCostOfLengths, int.Parse);

            int[,] matrix = new int[iCostOfLengths.Length, iSellingLength + 1];

            for (int i = 0; i < iLenghtsAvailable.Length; i++)
            {
                int currentLength = iLenghtsAvailable[i];
                int currentCost = iCostOfLengths[i];
                for (int j = 0; j < iSellingLength + 1; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 0;
                        continue;
                    }
                    if (i == 0)
                    {
                        int val = j / currentLength;
                        matrix[i, j] = val;
                    }
                    else
                    {
                        if (j < currentLength)
                        {
                            matrix[i, j] = matrix[i - 1, j];
                        }
                        else
                        {
                            int val1 = matrix[i - 1, j];
                            int val2 = matrix[i, j - currentLength] + currentCost;
                            if (val1 > val2)
                            {
                                matrix[i, j] = val1;
                            }
                            else
                            {
                                matrix[i, j] = val2;
                            }
                        }
                    }

                }
            }
            System.Console.WriteLine(matrix[iCostOfLengths.Length - 1, iSellingLength]);
            System.Console.ReadLine();
        }
    }
}
