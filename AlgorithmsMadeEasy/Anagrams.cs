using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class Anagrams
    {
        public void AnagramMethod()
        {
            //input
            string[] input = { "dog", "cat", "bull", "ullb" };

            string[] sortedOutput = new string[input.Length];

            int count = 0;

            //sort
            foreach (var i in input)
            {
                var currentInput = i.ToCharArray();
                Array.Sort(currentInput);
                sortedOutput[count] = new string(currentInput);
                count++;
            }

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            count = 0;

            //bucketize
            foreach (var entry in sortedOutput)
            {
                if (output.ContainsKey(entry))
                {
                    var temp = output[entry];
                    temp.Add(input[count]);
                }
                else
                {
                    List<string> temp = new List<string>();
                    temp.Add(input[count]);
                    output.Add(entry, temp);
                }
                count++;
            }

            //print
            foreach (var o in output)
            {
                foreach (var v in o.Value)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
