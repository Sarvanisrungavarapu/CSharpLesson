using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayEight
{
    class StreamsLesson
    {
        //char Streams
        public static void Testone()
        {
            char ch;
            Console.WriteLine("Press a key followed by ENTER: ");
            int x=Console.Read();
            ch=(char)x; //get a char
            Console.WriteLine("\n" + x + "Your key is: " + ch);
        }
        public static void TestTwo()
        {
            char ch=' ';
            Console.WriteLine("Press a key followed by ENTER: ");
            while (ch != 'q')
            {              
                ch = (char)Console.Read();
                Console.WriteLine("Your key is: " + ch);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" " + str);
        }
        public static void TestNullableTypes()
        {
            int? x = 8;
            //x = null;
            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else 
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
