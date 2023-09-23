using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.Day1
{
    internal class Statement
    {
        public static void Testone()
        {
            Console.WriteLine("Enter your age");
            string ageAsString=Console.ReadLine();
            int age=int.Parse(ageAsString);
           if(age<18)
            {
                Console.WriteLine("Sorry You cann't drive");
            }
            else
            {
                Console.WriteLine("Yes! you can drive");
            }
        }
        public static bool IsNumeric(string Pvalue)
        {
            bool result = false;
            if(Pvalue == null)
            {
                Console.WriteLine("Invalid String!!! Value is null.........");
                result = false;
            }
            char[] data = Pvalue.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not a NUMBER!!!");
                    return false;
                }
            }
            result = true;
            return result;
        }
    }
}

//Statement.Testone();//
