using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestEqualNumbers
{
    class MethodForLogestEqNumbs
    {
        //Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. Write a program to test whether the method works correctly.

        public static void LongestEqualNumbsSequance(List<int> sequence)
        {
            sequence.Sort();
            int count = 1;
            int bigestSequence = 0;
            int number = 0;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i - 1] == sequence[i])
                {
                    count++;
                }
                else
                {
                    if (count > bigestSequence)
                    {
                        bigestSequence = count;
                        number = sequence[i - 1];
                    }
                    count = 1;
                }
            }

            Console.WriteLine("Occurtence: " + bigestSequence);
            Console.WriteLine("Most occurrence number is " + number);
        }

        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 99, 5, 5, 12, 3, 33, 33, 33, 51, 99, 12 };
            LongestEqualNumbsSequance(sequence);
        }
    }
}
