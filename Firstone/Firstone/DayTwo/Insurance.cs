using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayTwo
{
    internal class Insurance
    {
        public int Sno { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Nominee1 { get; set; }  =string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }
        public long aadharcard { get; set; }
        public string DOB { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Sno:{this.Sno}; Name:{FirstName}.{LastName},\n" +
                   $" Address:{Address}, City:{City}, NomineeName:{Nominee1}, \n" +
                   $" Phone:{Phone}, Country:{Country}, Zip:{PostalCode}" +
                   $" aadharno:{aadharcard}, DOB:{DOB}";
        }
    }
    internal class TestInsurance
    {
        public static void TestIns()
        {
           Insurance Insurancedperson = new Insurance();
            Insurancedperson.Sno = 23;
            Insurancedperson.FirstName = "Sarvani";
            Insurancedperson.LastName = "Srungavarapu";
            Insurancedperson.Address = "KPHB Colony";
            Insurancedperson.City = "Hyderabad";
            Insurancedperson.Country = "India";
            Insurancedperson.Phone = 8367367398L;
            Insurancedperson.aadharcard = 997019423389L;
            Insurancedperson.DOB = "23/10/2001";
            Insurancedperson.PostalCode = "500075";
            Insurancedperson.Nominee1 = "Sriram";
            
            string value = Insurancedperson.ToString();
        Console.WriteLine(value);
        }
}
}

//TestInsurance.TestIns();