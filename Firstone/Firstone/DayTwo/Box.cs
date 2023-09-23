using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayTwo
{
    internal class Box
    {
        public static int height;
        public int width;
        public const string type = "Wooden";
        public int GetHeight() { return height;  }
    }
    internal class Testbox
    {
        public static void TestOne()
        {
            Box.height = 100;
            //Box.width = 200;
            Box firstBox = new Box();   
            Box secondBox = new Box();
            firstBox.width = 12345;
            secondBox.width = 98765;

            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box= {secondBox.width}, {secondBox.GetHeight()}");
            Console.WriteLine(Box.type);
            //Box,type="Glass";
            Box.height = 2310;
            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box= {secondBox.width}, {secondBox.GetHeight()}");
        }
    }
}
//Testbox.TestOne();