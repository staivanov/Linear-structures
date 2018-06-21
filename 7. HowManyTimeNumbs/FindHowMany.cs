using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimeNumbs
{
    class FindHowMany
    {
        //Write program who find how many time number in [0-1000] is matched.
        //  array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        //2 -> 2 times
        //3 -> 4 times
        //4 -> 3 times

        static void Main(string[] args)
        {
            List<int> myNumbs = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (var number in myNumbs)
            {
                int count = 1;

                if (result.ContainsKey(number))
                {
                    count = result[number] + 1;
                }
                result[number] = count;            
            }

            foreach (var item in result)
            {
                Console.WriteLine("number {0} -> {1} matched", item.Key, item.Value);
            }

        }
    }
}
