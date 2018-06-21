using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceNumbers
{
    class SequenceNumbsStop
    {
        // Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

        static void Main(string[] args)
        {
            List<int> myInts = new List<int>();

            while (true)
            {
                try
                {
                    myInts.Add(int.Parse(Console.ReadLine()));
                }
                catch (Exception)
                {

                    Console.WriteLine("Result: ");
                    break;
                }
            }

            myInts.Sort();

            foreach (var item in myInts)
            {
                Console.WriteLine(item);
            }

        }
    }
}
