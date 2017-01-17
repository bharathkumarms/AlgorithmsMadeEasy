using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class SelectionSort
    {
        public void SelectionSortMethod()
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            for (int i = 0; i < iInput.Length; i++)
            {
                int minIndex = 0;
                bool flagChanged = false;
                for (int j = i; j < iInput.Length - 1; j++)
                {
                    if (iInput[j] > iInput[j + 1])
                    {
                        minIndex = j + 1;
                        flagChanged = true;
                    }
                }
                if (flagChanged)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[minIndex];
                    iInput[minIndex] = temp;
                }
            }
        }
    }
}
