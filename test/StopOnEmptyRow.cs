using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyRowStop
{
    class StopOnEmptyRow
    {
        //Write a program that reads from the console a sequence of positive integer numbers. The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. Keep the sequence in List<int>.

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

            int sum = myInts.Sum();
            double average = myInts.Average();

            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Average is {0}", average);

        }
    }
}
