using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.Day1
{
    internal class Calculator
    {
        public static int Add(int p1, int p2)
        {
            return p1 + p2;
        }
        public static int Subtract(int p1, int p2)
        {
            return p1-p2;
        }
        public static int Multiply(int p1, int p2)
        {
            return p1*p2;
        }
        public static int Divide(int p1, int p2)
        {
            return p1/p2;
        }
    }
}
/*Console.WriteLine("Enter the value of first parameter");
string x=Console.ReadLine();
Console.WriteLine("Enter the value of second parameter");
string y=Console.ReadLine();

int firstvalue = int.Parse(x);
int secondvalue = int.Parse(y);

int addresult = Calculator.Add(firstvalue, secondvalue);
Console.WriteLine(addresult);
int Subtractresult = Calculator.Subtract(firstvalue, secondvalue);
Console.WriteLine(Subtractresult);
int Multiplyresult = Calculator.Multiply(firstvalue, secondvalue);
Console.WriteLine(Multiplyresult);
int Divideresult = Calculator.Divide(firstvalue, secondvalue);
Console.WriteLine(Divideresult);*/ /*program.cs*/