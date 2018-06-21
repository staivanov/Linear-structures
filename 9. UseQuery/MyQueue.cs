using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseQuery
{
    class MyQueue
    {
        //S1 = N;
        //S2 = S1 + 1;
        //S3 = 2*S1 + 1;
        //S4 = S1 + 2;
        //S5 = S2 + 1;
        //S6 = 2*S2 + 1;
        //S7 = S2 + 2;
        // Use class Queue<T>, where given N print on console first 50 numbers in sequence 
        //Example: N = 2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
        static void Main(string[] args)
        {
            int n = 2;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(n + 2);
            }
        }
    }
}
