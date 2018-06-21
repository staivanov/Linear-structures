using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumbs
{
    class RemoveOddMatched
    {
        //Write program who remove all numbers even matched.
        //array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> result = new List<int>();
            int myIntLen = myInts.Count;
            int counter = 0;

            for (int i = 0; i < myIntLen; i++)
            {
                counter = 0;

                for (int j = 1; j < myIntLen; j++)
                {
                    if (myInts[i] == myInts[j])
                        counter++;
                }

                if ((counter % 2) == 0 && (counter > 0))
                    result.Add(myInts[i]);
            }

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

        }
    }
}
