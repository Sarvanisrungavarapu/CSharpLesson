using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
    //abstart class program
namespace Firstone.DayThree
{
    internal abstract class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("");
        }
        public void start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }
    //End of class
    internal class Car:Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
   /* Class VehicleTester
    {
        public static void TestOne()
        {
        //Vehicle tester=newVehicle();
        Vehicle tester = new Car();
        tester.start();
        }
     }*/
}
