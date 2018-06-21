using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveAllNegativeNumbs
{
    class RemoveNegNumbs
    {
        //Write a program who remove all negative numbers in sequence 
        //{ 19, -10, 12, -6, -3, 34, -2, 5 }; -> {19, 12, 34, 5};
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 19, -10, 12, -6, -3, 34, -2, 5 };
            List<int> positiveNumbs = new List<int>();

            for (int index = 0; index < sequence.Count(); index++)
            {
                if (sequence[index] > 0)
                    positiveNumbs.Add(sequence[index]);
            }

            foreach (var item in positiveNumbs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
