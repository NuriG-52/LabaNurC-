using System;
using System.Collections.Generic;
using System.Text;

namespace Swp
{
  
    public class BdExpection : System.Exception
    {
        public Int16 code;
        public BdExpection(Int16 code)
        {
            this.code = code;
        }
    }

    public class Person

        {
            public String Surname;

            private DateTime bd;
            public String Firstname { get; set; }
            public string Pass { get; set; }
            public DateTime BDate
            {
                get { return this.bd; }
                set
                {
                    if (value < DateTime.Now) this.bd = value;
                    else throw new BdExpection(1);
                }
            }
        public Address address;

            public Person()
            {
                this.Surname = null;
                this.Firstname = null;
                this.Pass = null;
            }
            public Person(string s, string f, string p, DateTime d)
            {
                this.Surname = s;
                this.Firstname = f;
                this.Pass = p;
                this.BDate = d;
            }
        }
    } 
