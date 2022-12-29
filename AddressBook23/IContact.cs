﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public interface IContact
    {
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum, string bookname);
        public void ViewContact(string name, string BookName);
        public void EditContact(string name, string BookName);
        public void DeleteContact(string name, string BookName);
        public void AddAddressBook(string BookName);

    }
}