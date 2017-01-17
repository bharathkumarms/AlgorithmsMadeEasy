using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class InsertionSort
    {
        public void InsertionSortMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            int value = 0;

            for (int i = 1; i < iInput.Length; i++)
            {
                value = iInput[i];

                int sortedCount = i - 1;

                while (sortedCount >= 0 && iInput[sortedCount] > value)
                {
                    iInput[sortedCount + 1] = iInput[sortedCount];
                    sortedCount--;
                }
                iInput[sortedCount + 1] = value;
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