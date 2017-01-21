using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class KMPSubstringSearch
    {
        public void KMPSubstringSearchMethod()
        {
            string text = System.Console.ReadLine();
            char[] sText = text.ToCharArray();

            string pattern = System.Console.ReadLine();
            char[] sPattern = pattern.ToCharArray();

            int forwardPointer = 1;
            int backwardPointer = 0;

            int[] tempStorage = new int[sPattern.Length];
            tempStorage[0] = 0;

            while (forwardPointer < sPattern.Length)
            {
                if (sPattern[forwardPointer].Equals(sPattern[backwardPointer]))
                {
                    tempStorage[forwardPointer] = backwardPointer + 1;
                    forwardPointer++;
                    backwardPointer++;
                }
                else
                {
                    if (backwardPointer == 0)
                    {
                        tempStorage[forwardPointer] = 0;
                        forwardPointer++;
                    }
                    else
                    {
                        int temp = tempStorage[backwardPointer];
                        backwardPointer = temp;
                    }

                }
            }

            int pointer = 0;
            int successPoints = sPattern.Length;
            bool success = false;
            for (int i = 0; i < sText.Length; i++)
            {
                if (sText[i].Equals(sPattern[pointer]))
                {
                    pointer++;
                }
                else
                {
                    if (pointer != 0)
                    {
                        int tempPointer = pointer - 1;
                        pointer = tempStorage[tempPointer];
                        i--;
                    }
                }

                if (successPoints == pointer)
                {
                    success = true;
                }
            }

            if (success)
            {
                System.Console.WriteLine("TRUE");
            }
            else
            {
                System.Console.WriteLine("FALSE");
            }
            System.Console.Read();
        }
    }
}

/*
 * Sample Input
abxabcabcaby
abcaby 
*/
