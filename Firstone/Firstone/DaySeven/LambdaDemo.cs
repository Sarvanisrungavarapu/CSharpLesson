using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DaySeven
{
    internal class LambdaDemo
    {
        public static void DemoA()
        {
            Func<int, int> foo = x => x;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        public static void DemoASam()
        {
            Func<int, int> foo = x => x / 2;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        public static void DemoB() //without parameters
        {
            Func<int> foo = () => 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1, v2);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            Func<int, double> foo = x => /*(double)*/ x / 2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {
            Func<double, int> foo = x => (int)x / 2;
            int v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }
        public static void Echo(Func<string> foo)
        {
            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");
        }
        static double DoTrans(Func<int, int, double> foo)
        {
            return foo(50, 5);
        }

    }
}
