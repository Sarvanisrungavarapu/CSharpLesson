using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }   
        
        public override string ToString()
        {
            return $"ID:{this.Id}; Name:{Title} {FirstName}, {LastName},\n" +
                   $" Address:{Address}, City:{City}, State:{Region}, \n" +
                   $" Phone:{Phone}, Country:{Country},Zip:{PostalCode}";
        }
    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            Person firstperson = new Person();
            firstperson.Id = 1;
            firstperson.FirstName = "Sarvani";
            firstperson.LastName= "Srungavarapu";
            firstperson.Address = "KPHB";
            firstperson.City = "Hyderabad";
            firstperson.Country = "India";
            firstperson.Phone = 8367367398L;
            firstperson.PostalCode = "500075";
            firstperson.Region = "In";
            firstperson.Title = "Miss";
            string value=firstperson.ToString();
            Console.WriteLine(value);
        }
    }
}

//TestPerson.TestOne();