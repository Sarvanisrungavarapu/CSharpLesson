using Firstone.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            Console.WriteLine(int.MaxValue);
            long l1 = int.MaxValue + 1000L;
            Console.WriteLine(l1);
            bool flag = true;
            Console.WriteLine(flag);        
         }
        public static void TestMethod()
        {
            Console.WriteLine("Test");
        }
    }
}

// ValueTypeLesson.TestValueTpes();//
//ValueTypeLesson.TestMethod();//
//these 2 lines should use in program.cs//
