using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayTwo
{
    internal static class Movie
    {
        static Movie()
        {
            Console.WriteLine("Static Constructor...");
        }
        //  public Movie() { }
        public static int DataA;
        // int dataB;
        public static void FirstMethod() { }
        //public void SecondMethod() { }
    }
    public class MovieTester
    {
        public static void TestOne()
        {
            //Movie m1 = new Movie();
            Movie.DataA = 1;
            Movie.FirstMethod();
        }
    }
}
