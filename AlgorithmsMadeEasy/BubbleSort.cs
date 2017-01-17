using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class BubbleSort
    {
        public void BubbleSortMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            for (int i = 0; i < iInput.Length; i++)
            {
                for (int j = 0; j < iInput.Length - 1; j++)
                {
                    if (iInput[j] > iInput[j + 1])
                    {
                        int temp = iInput[j];
                        iInput[j] = iInput[j + 1];
                        iInput[j + 1] = temp;
                    }
                }
            }

            for (int k = 0; k < iInput.Length; k++)
            {
                Console.Write(iInput[k] + " ");
            }
            Console.Read();
        }
    }
}

/*
 * Sample Input
6 5 3 2 8
*/