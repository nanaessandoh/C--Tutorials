using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{

    // Enforcement of Policy
    // Can be inplemented using Array or LinkedList
    // Stack LIFO/FILO
    // Queue FIFO/LILO
    // Stack Methods - Push, Pop, Peek (Get copy of data on the top)
    // Queue Method - Enqueue (Put dta aat end of queue), Dequeue (Remove data from begining of queue), Peek
    class StacksNQueues
    {

        public static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            myStack.Push(4);
            myStack.Push(7);
            myStack.Push(9);
            myStack.Push(7);
            myStack.Push(3);

            int topOfStack = myStack.Pop();
            Console.WriteLine($"Pop Value = {topOfStack}");
            Console.WriteLine("------- Stack ------------");
            foreach (var x in myStack)
            {
                Console.WriteLine(x);
            }

            myQueue.Enqueue(3);
            myQueue.Enqueue(9);
            myQueue.Enqueue(2);
            myQueue.Enqueue(1);
            myQueue.Enqueue(8);
            myQueue.Enqueue(5);

            int firstOutOfQueue = myQueue.Dequeue();
            Console.WriteLine($"Dequeue Value = {firstOutOfQueue}");
            Console.WriteLine("------- Queue ------------");
            foreach (var x in myQueue)
            {
                Console.WriteLine(x);
            }



        }
    }
}
