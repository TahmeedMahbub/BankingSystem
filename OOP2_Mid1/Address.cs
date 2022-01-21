using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid1
{
    class Address
    {
       
        private string dob, address;

        public Address(string address, string dob)
        {
            this.address=address;
            this.dob = dob;
           // this.sc = sc;
           
        }

       
        
        public string Dob
        {
            set { this.dob = value; }
            get { return this.dob; }
        }
        public string Adress
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void PrintAddress()
        {
            Console.WriteLine("Date of Birth: ", this.dob);
            Console.WriteLine("Address: ", this.address);
        }

    }
}