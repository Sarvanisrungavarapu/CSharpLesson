using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayTwo
{
    internal class Demo1
    {
        //Glocal Variables Declaration
        int x = 231; //declaring the values inside the class is known as global or member or class or field variables.
        static int y = 123;
        public static void secondMethod()
        {
            //LocalVariables
            int y = 2000;
            //Console.WriteLine(x);   Non static variable cannot be accessed here in mwethod
            Console.WriteLine(y); //Local Variable
            Console.WriteLine(Demo1.y); //Global static variable
        }
    }
    internal class Demo2
    {
    }
    namespace Firstone.DayTwo
    {
        internal class Demo1
        {
        }
        internal class Demo2
        {
        }
    }
}

//Demo1.FirstMethod();

//Demo1.secondmethod(); wrong not a static method

//create an object for class demo1
//Demo1 demo1 = new Demo1();

//calling non static method of Demo1 using 