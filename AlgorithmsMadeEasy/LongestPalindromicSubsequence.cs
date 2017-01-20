using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class LongestPalindromicSubsequence
    {
        public void LongestPalindromicSubsequenceMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');

            int[,] matrix = new int[sInput.Length, sInput.Length];

            int len = sInput.Length;
            int lenCount = 1;

            while (lenCount <= len)
            {
                if (lenCount == 1)
                {
                    for (int i = 0; i < len; i++)
                    {
                        matrix[i, i] = 1;
                    }
                }
                else if (lenCount == 2)
                {
                    int i = 0;
                    int j = 1;
                    int endIndex = len;

                    while (j < endIndex)
                    {
                        if (sInput[i] != sInput[j])
                        {
                            matrix[i, j] = 1;
                        }
                        else
                        {
                            matrix[i, j] = 2;
                        }
                        i++;
                        j++;
                    }
                }
                else
                {
                    int temp = lenCount - 1;

                    int i = 0;
                    int j = temp - 1;
                    int k = i + 1;
                    int l = temp;
                    int endIndex = len;

                    while (l < endIndex)
                    {
                        if (sInput[i].Equals(sInput[l]))
                        {
                            int tempLeft = i + 1;
                            int tempRight = l - 1;
                            int c = matrix[tempLeft, tempRight] + 2;
                            matrix[i, l] = c;
                        }
                        else
                        {
                            int a = matrix[i, j];
                            int b = matrix[k, l];
                            if (a > b)
                            {
                                matrix[i, l] = a;
                            }
                            else
                            {
                                matrix[i, l] = b;
                            }
                        }
                        i++;
                        j++;
                        k++;
                        l++;
                    }
                }

                lenCount++;
            }

            Console.Write(matrix[0, len - 1]);
            Console.ReadLine();
        }
    }
}

/*
 * Sample Input
a g b d b a
*/