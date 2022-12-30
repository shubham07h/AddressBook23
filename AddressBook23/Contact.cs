using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LasTName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public long PhoneNum { get; set; }
        public Contact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum)
        {
            FirstName = firstName;
            LasTName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNum = phoneNum;
        }
        public override bool Equals(object? obj)
        {
            Contact contact = obj as Contact;
            if (contact == null)
            {
                return false;
            }
            else
            {
                return FirstName.Equals(contact.FirstName) && LasTName.Equals(contact.LasTName);
            }
        }
        public override string ToString()
        {
            return "FirstName : " + FirstName + "\nLast Name : " + LasTName + "\nCity: " + City +
                "\nState :" + State + "\nZip :" + Zip + "\nEmail :" + Email + "\nPhone Number :" + PhoneNum;
        }


    }
}