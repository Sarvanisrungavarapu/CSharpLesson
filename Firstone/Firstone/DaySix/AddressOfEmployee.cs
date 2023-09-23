using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Firstone.DaySix.AddressOfEmployee;

namespace Firstone.DaySix
{
    internal class AddressOfEmployee
    {
        public class Address
        {
            public string Address1;
            public string Address2;
            private readonly Emp e1;

            internal Address(Emp outerEmp)
            {
                if (outerEmp == null)
                    throw new NullReferenceException("Outer Emp is Null!!");
                e1 = outerEmp;
            }
            public override string ToString()
            {
                return Address1 + "," + Address2 + "of" + e1;
            }
        }

    }
}