using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayThree
{
    internal class Box   //parent class
    { 
        public int Height;
        public int Length;
        public int Width;
        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        { 
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height},Length:{Length},Width:{Width}";
        }
    }
    internal class WoodenBox : Box      //Child class inheritance
    {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x) :base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x, int y) : base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }
        public override string ToString() 
        {
            return "Tom And Jerry";
        }
    }   
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(1); 
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            string output = box.ToString();
            Console.WriteLine(output);
            //Box.Area = 10; // we cannot initialize in parent class as it is used for child class.
            //Box.Move();
        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Width = 50;
            box.Length = 200;
            box.Open();
            box.Close();
            string output = box.ToString();
            Console.WriteLine(output);
            box.Area = 10;
            box.Move();
        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 100;
            box.Width = 50;
            box.Length = 200;
            box.Open();
            box.Close();
            string output = box.ToString();   //overide(Tom And Jerry)
            Console.WriteLine(output);
            //Box.Area = 10;
            //Box.Move();
        }
    }
}
