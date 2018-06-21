using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintRowBack
{
    class RowBack
    {
        // White program where read N numbers from console and print the in back row. Use Stack<int>.
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            while (true)
            {
                try
                {
                    myStack.Push(int.Parse(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("Let me check");
                    break;
                }
            }

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());
        }
    }
}
