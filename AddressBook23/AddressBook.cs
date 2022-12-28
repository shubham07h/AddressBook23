using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    internal class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Email;
        public int Zip;
        public long PhoneNum;
        public AddressBook(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNum = phoneNum;
        }
        public void DisplayContacts()
        {
            Console.WriteLine("Name {0} {1}", FirstName, LastName);
            Console.WriteLine("Address : {0}", Address);
            Console.WriteLine("City :{0}", City);
            Console.WriteLine("State : {0}", State);
            Console.WriteLine("Email :{0}", Email);
            Console.WriteLine("Zip :{0}", Zip);
            Console.WriteLine("Phone :{0}", PhoneNum);
        }
    }
}