using Firstone.DaySeven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lesson1.Day7
{
    internal class Threaddemo
    {
        public static void Demothread()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("isAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public static void DemoA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainThreadID=" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTask();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA b1 = new ServiceA();
            Thread t1 = new Thread(b1.DoTask);//delegate
            t1.Start();
            Console.WriteLine("----------End Of DemoB------------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA b1 = new ServiceA();
            Thread t1 = new Thread(b1.DoTask);//delegate
            Console.WriteLine(t1.ManagedThreadId + "T1 State " + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "State After Start " + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + "T1 State After Sleep " + t1.ThreadState);
            Console.WriteLine("----------End Of DemoB------------");
        }
        public static void DemoC()
        {
            Thread thread = Thread.CurrentThread;   
            int id = thread.ManagedThreadId;
            Console.WriteLine("MainTh Id: " + id);
            ServiceA a1= new ServiceA();
            ThreadStart ts= a1.DoTask;
            Thread t1 = new Thread(ts);
            Thread t2= new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(2000);
            //if (t1.IsAlive) t1.Abort(); //threads.Abort is obsolte last year 2022
            t2.Join(7000);
            //if (t1.IsAlive) t1.Abort();
            Console.WriteLine("----------End Of DemoB------------");
        }
    }
}