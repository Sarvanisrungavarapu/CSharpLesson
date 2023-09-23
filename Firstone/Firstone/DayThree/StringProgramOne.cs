 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayThree
{
    internal class StringProgramOne
    {
        public static void Demo1()
        {
            String firstString = "Hello";
            char[] data = { 'H', 'E', 'L', 'L', 'O' };
            String secondString=new string(data);
            Console.WriteLine(firstString+ " "+ secondString);
            String thirdString = String.Empty;
           // int x = 0;
        }
        public static void Demo2()
        {
            String s1 = "Tom And Jerry Are friends";
            Console.WriteLine("Length " + s1.Length);
            Char[] data=s1.ToCharArray();
            foreach(char c in data)
            {
                Console.WriteLine(c);
            }
        }

    }
}
