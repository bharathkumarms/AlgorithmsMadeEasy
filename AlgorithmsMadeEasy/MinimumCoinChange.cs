using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class MinimumCoinChange
    {
        public void MinimumCoinChangeDP()
        {
            var total = System.Console.ReadLine().Trim();
            var iTotal = Int32.Parse(total);

            var input = System.Console.ReadLine();
            var subInput = input.Substring(1, input.Length - 2);
            string[] cInput = subInput.Split(',');
            int[] iInput = Array.ConvertAll(cInput, int.Parse);

            int[] arr1 = new int[iTotal + 1];
            int[] arr2 = new int[iTotal + 1];

            for (int i = 0; i < iTotal + 1; i++)
            {

                if (i == 0)
                {
                    arr1[i] = 0;
                }
                else
                {
                    arr1[i] = Int32.MaxValue - 1;
                }
                arr2[i] = -1;
                //System.Console.WriteLine(iInput[i]);   
            }

            for (int j = 0; j < iInput.Length; j++)
            {
                for (int k = 1; k < iTotal + 1; k++)
                {
                    if (k >= iInput[j])
                    {
                        int firstMin = arr1[k];
                        int temp = k - iInput[j];
                        int secondMin = 1 + arr1[temp];

                        if (firstMin > secondMin)
                        {
                            arr1[k] = secondMin;
                            arr2[k] = j;
                        }
                    }
                }
            }

            int index = iTotal;

            Dictionary<int, int> output = new Dictionary<int, int>();

            for (int l = 0; l < iInput.Length; l++)
            {
                output.Add(iInput[l], 0);
            }

            while (index > 0)
            {
                int getIndex = arr2[index];
                if (output.ContainsKey(iInput[getIndex]))
                {
                    int value = output[iInput[getIndex]];
                    output[iInput[getIndex]] = value + 1;
                }

                index -= iInput[getIndex];
            }

            foreach (var pair in output.OrderBy(v => v.Value))
            {
                System.Console.WriteLine("Rupee {0} coin {1}", pair.Key, pair.Value);
            }

            //System.Console.ReadLine();
        }
    }
}
