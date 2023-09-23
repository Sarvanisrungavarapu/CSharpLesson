using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DaySix
{
    internal class ParameterDemo
    {
        //by ref Parameters
        public static void ByRefMethod(int v1, ref int v2)
        {
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//5, 10
            v1 = v1 + 100;
            v2 = v1 * 2000;
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//105, 210000 
        }
        public static void TestByRefMethod()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 10
            ByRefMethod(x, ref y);
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 210000
        }
    }
}
