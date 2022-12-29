﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookDay23
{
    public class AddressBook : IContact
    {

        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum, string BookName)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LasTName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Zip = zip;
            contact.Email = email;
            contact.PhoneNum = phoneNum;
            addressBookDictionary[BookName].addressBook.Add(contact.FirstName, contact);
            Console.WriteLine("Added Succesfully");

        }
        public void ViewContact(string name, string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[BookName].addressBook)
            {
                if (item.Key.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("FirstName;" + item.Value.FirstName);
                    Console.WriteLine("LastName;" + item.Value.LasTName);
                    Console.WriteLine("Address;" + item.Value.Address);
                    Console.WriteLine("City;" + item.Value.City);
                    Console.WriteLine("State;" + item.Value.State);
                    Console.WriteLine("Zip;" + item.Value.Zip);
                    Console.WriteLine("Email;" + item.Value.Email);
                    Console.WriteLine("PhoneNum;" + item.Value.PhoneNum);
                }
            }
        }
        public void ViewContact(string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[BookName].addressBook)
            {
                Console.WriteLine("FirstName;" + item.Value.FirstName);
                Console.WriteLine("LastName;" + item.Value.LasTName);
                Console.WriteLine("Address;" + item.Value.Address);
                Console.WriteLine("City;" + item.Value.City);
                Console.WriteLine("State;" + item.Value.State);
                Console.WriteLine("Zip;" + item.Value.Zip);
                Console.WriteLine("Email;" + item.Value.Email);
                Console.WriteLine("PhoneNum;" + item.Value.PhoneNum);

            }

        }
        public void EditContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[bookName].addressBook)
            {
                if (item.Key.Equals(name))
                {


                    Console.WriteLine("Enter Field ToBE Modify\n1.FirstNmae\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Email\n8.PhoneNUmber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the MOdifed Value");
                            string FName = Console.ReadLine();
                            item.Value.FirstName = FName;
                            break;
                        case 2:
                            Console.WriteLine("Enter the MOdifed Value");
                            string LName = Console.ReadLine();
                            item.Value.LasTName = LName;
                            break;
                        case 3:
                            Console.WriteLine("Enter the MOdifed Value");
                            string Add = Console.ReadLine();
                            item.Value.Address = Add;
                            break;
                        case 4:
                            Console.WriteLine("Enter the MOdifed Value");
                            string city = Console.ReadLine();
                            item.Value.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter the MOdifed Value");
                            string StateN = Console.ReadLine();
                            item.Value.State = StateN;
                            break;
                        case 6:
                            Console.WriteLine("Enter the MOdifed Value");
                            int ZipN = Convert.ToInt32(Console.ReadLine());
                            item.Value.Zip = ZipN;
                            break;
                        case 7:
                            Console.WriteLine("Enter the MOdifed Value");
                            string MailID = Console.ReadLine();
                            item.Value.Email = MailID;
                            break;
                        case 8:
                            Console.WriteLine("Enter the MOdifed Value");
                            long PhnNum = Convert.ToInt64(Console.ReadLine());
                            item.Value.PhoneNum = PhnNum;
                            break;


                    }
                    Console.WriteLine("Edited Successfully");
                }
            }
        }
        public void DeleteContact(string name, string BookName)
        {
            if (addressBookDictionary[BookName].addressBook.ContainsKey(name))
            {
                addressBookDictionary[BookName].addressBook.Remove(name);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Not found Try Again");
            }
        }
        public void AddAddressBook(string BookName)
        {
            AddressBook book = new AddressBook();
            addressBookDictionary.Add(BookName, book);
            Console.WriteLine("AddressBook Created");
        }
        public Dictionary<string, AddressBook> GetaddressBook()
        {
            return addressBookDictionary;
        }


    }
}