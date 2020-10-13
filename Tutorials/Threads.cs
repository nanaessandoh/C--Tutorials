using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tutorials
{
    public class ThreadedWorker
    {
        int ID;
        Thread t;

        public ThreadedWorker(int _ID)
        {
            this.ID = _ID;
            t = new Thread(new ThreadStart(doWork));
            t.Start();
        }
        void doWork()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"doWork {ID} is Runnig");
            }
            Console.WriteLine($"Thread {ID} is Done");
        }
    }
    public class ThreadsTest
    {

        static void Main1(string[] args)
        {
            for(int i = 0; i<4; i++)
            {
                var tr = new ThreadedWorker(i);
            }

        }
    }
}
