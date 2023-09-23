using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DaySeven
{
    class ServiceA
    {
        int x = 0;
        public void DoTask()
        {
            Monitor.Enter(this);
            Thread t1=Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTask");
            Console.WriteLine("\t Thread ID: " + id);
            //int x = 0;
           
            try
            {
                for (int icount = 0; icount < 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount=" + icount);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
