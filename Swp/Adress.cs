using System;
using System.Collections.Generic;
using System.Text;

namespace Swp
{
    public class Address
    {
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public Address(String a1, String a2, String a3)
        {
            this.Address1 = a1;
            this.Address2 = a2;
            this.Address3 = a3;

        }
            
    }
}
