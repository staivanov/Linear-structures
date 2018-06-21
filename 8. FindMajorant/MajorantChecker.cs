using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMajorant
{
    class MajorantChecker
    {

        static void Main(string[] args)
        {
            //Majorant of array is N elements who value is N/2 + 1 matched. Write program for array of numbers and majorant finder. Print majorand or print "The majorant does not exist!".
            //Example {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
            int[] numbs = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int majorantCounter = (numbs.Length / 2) + 1;
            int numbsLen = numbs.Length;
            int counter = 1;
            int maxSequence = 1;
            int majorantNumber = 0;
            Array.Sort(numbs);

            for (int i = 1; i < numbsLen; i++)
            {
                if (numbs[i - 1] == numbs[i])
                {
                    counter++;
                }
                else
                {
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        majorantNumber = numbs[i - 1];
                    }
                    counter = 1;
                }
            }

            if (majorantCounter <= maxSequence)
            {
                Console.WriteLine("Majorant is {0} ", majorantNumber);
            }
            else
            {
                Console.WriteLine("The majorant does not exist!");
            }

        }
    }
}
