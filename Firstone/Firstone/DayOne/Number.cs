using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.Day1
{
    internal class Number
    {
       public static void Main(string[] args)
        {
            int rows = 9;
            for (int i = 1; i <= rows; i++)
            {

                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write("  ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


