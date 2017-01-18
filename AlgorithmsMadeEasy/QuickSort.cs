using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class QuickSort
    {
        public void QuickSortMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            QuickSortNow(iInput, 0, iInput.Length - 1);

            for (int i = 0; i < iInput.Length; i++)
            {
                Console.Write(iInput[i] + " ");
            }

            Console.ReadLine();
        }

        public static void QuickSortNow(int[] iInput, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(iInput, start, end);
                QuickSortNow(iInput, start, pivot - 1);
                QuickSortNow(iInput, pivot + 1, end);
            }
        }

        public static int Partition(int[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] <= pivot)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }
    }
}

/*
 * Sample Input
6 5 3 2 8
*/