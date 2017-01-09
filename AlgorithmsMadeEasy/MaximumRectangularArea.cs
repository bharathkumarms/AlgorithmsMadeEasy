using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class MaximumRectangularArea
    {
        public void MaximumRectangularAreaMethod()
        {

            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            Stack<int> myStack = new Stack<int>();

            int top = 0;
            int area = 0;
            int maxArea = -1;
            int iTemp = 0;

            for (int i = 0; i < iInput.Length; i++)
            {
                iTemp = i;
                if (myStack.Count == 0)
                {
                    myStack.Push(i);
                }
                else
                {
                    //int peekIndex = myStack.Peek();
                    //int peekValue = iInput[peekIndex];

                    if (iInput[myStack.Peek()] <= iInput[i])
                    {
                        myStack.Push(i);
                    }
                    else
                    {
                        while (myStack.Count > 0 && iInput[myStack.Peek()] > iInput[i])
                        {
                            //top = myStack.Count - 1;

                            top = myStack.Pop();
                            int value = iInput[top];

                            //Start Calculate Value
                            int actualValue;
                            if (myStack.Count > 0)
                            {
                                actualValue = value * (i - myStack.Peek() - 1);
                                area = actualValue;
                            }
                            else
                            {
                                actualValue = value * i;
                                area = actualValue;
                            }

                            //End Calculate Value

                            if (area > maxArea)
                            {
                                maxArea = area;
                            }
                        }
                        myStack.Push(i);
                    }
                }
            }

            iTemp++;

            while (myStack.Count > 0)
            {
                top = myStack.Pop();
                int value = iInput[top];

                //Start Calculate Value
                int actualValue;
                if (myStack.Count > 0)
                {
                    actualValue = value * (iTemp - myStack.Peek() - 1);
                    area = actualValue;
                }
                else
                {
                    actualValue = value * iTemp;
                    area = actualValue;
                }

                //End Calculate Value

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }
            System.Console.WriteLine(maxArea);
            System.Console.ReadLine();
        }
    }
}
