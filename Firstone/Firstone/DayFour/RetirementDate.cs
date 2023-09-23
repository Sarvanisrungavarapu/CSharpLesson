//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Firstone.DayFour
{
    internal class RetirementDate
    {
        public static void FindRetirementDate()
        {
            Console.WriteLine("What is your Date Of Birth (yyyy/mm/dd)");
            string strdob = string.Empty;
            try
            {
                strdob = $"{Console.ReadLine()}";
                    DateTime dob=DateTime.Parse(strdob);
                    DateTime nextMonthDate4=dob.AddYears(60).AddMonths(1);

            }catch (Exception) { }
        }
    }
    }
