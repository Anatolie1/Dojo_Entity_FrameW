using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public String StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
    }
}
