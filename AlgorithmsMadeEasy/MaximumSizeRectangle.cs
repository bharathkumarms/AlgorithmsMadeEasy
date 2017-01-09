using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    using System.Xml.Serialization;

    class MaximumSizeRectangle
    {
        public void MaximumSizeRectangleMethod()
        {
            var size = System.Console.ReadLine();
            string[] sSize = size.Split(' ');
            int rows = int.Parse(sSize[0]);
            int columns = int.Parse(sSize[1]);

            int[,] matrix = new int[rows, columns];

            int[] currentArray = new int[columns];

            for (int i = 0; i < rows; i++)
            {
                var input = System.Console.ReadLine();
                string[] sInput = input.Split(' ');
                int[] iInput = Array.ConvertAll(sInput, int.Parse);

                for (int j = 0; j < columns; j++)
                {
                    if (i == 0)
                    {
                        currentArray[j] = iInput[j];
                    }
                    matrix[i, j] = iInput[j];
                }
            }

            int maxArea = 0;
            int continuousCount = 0;

            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < columns; l++)
                {
                    if (k == 0)
                    {
                        if (matrix[k, l] == 1)
                        {
                            continuousCount++;
                        }
                        else
                        {
                            continuousCount = 0;
                        }
                        maxArea = continuousCount;
                    }
                    else
                    {
                        if (matrix[k, l] == 0)
                        {
                            currentArray[l] = 0;
                        }
                        else
                        {
                            currentArray[l] += matrix[k, l];
                        }
                    }
                }

                int currentMax = 0;

                List<int> temp = new List<int>();
                for (int x = 0; x < columns; x++)
                {
                    if (currentArray[x] > 0)
                    {
                        temp.Add(currentArray[x]);
                    }
                    else
                    {
                        int min = int.MaxValue;
                        for (int z = 0; z < temp.Count; z++)
                        {
                            if (temp[z] < min)
                            {
                                min = temp[z];
                            }
                        }
                        currentMax = min * temp.Count;

                        if (currentMax > maxArea)
                        {
                            maxArea = currentMax;
                        }
                        temp.Clear();
                    }
                }
                int min1 = int.MaxValue;
                for (int z = 0; z < temp.Count; z++)
                {
                    if (temp[z] < min1)
                    {
                        min1 = temp[z];
                    }
                }
                currentMax = min1 * temp.Count;

                if (currentMax > maxArea)
                {
                    maxArea = currentMax;
                }
                temp.Clear();
            }

            System.Console.ReadLine();
        }
    }
}
