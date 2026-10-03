using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTrackThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            int LoopCount = 0;

            while (LoopCount <= 2)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);

                LoopCount++;

                Thread.Sleep(500);
            }

        }
        public static void Thread2()
        {

            int LoopCount = 0;

            while (LoopCount <= 5)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);

                LoopCount++;

                Thread.Sleep(1500);

            }
        }
    }
}
