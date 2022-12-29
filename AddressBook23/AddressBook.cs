using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Email;
        public int Zip;
        public long PhoneNum;
        public AddressBook[] ContactArray;
        public int Contact = 0;
        public AddressBook()
        {
            this.ContactArray = new AddressBook[5];
        }
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
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum)
        {
            ContactArray[this.Contact] = new AddressBook(firstName, lastName, address, city, state, email, zip, phoneNum);
            Contact++;
            Program program = new Program();
            program.DisplayContacts(ContactArray, Contact);

        }
        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("Enter First Name to Edit");
            string FirstName = Console.ReadLine();
            while (ContactArray[i].FirstName != FirstName)
            {
                i++;
            }
            Console.WriteLine("Enter Field ToBE Modify\n1.FirstNmae\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Email\n8.PhoneNUmber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the MOdifed Value");
                    string FName = Console.ReadLine();
                    ContactArray[i].FirstName = FName;
                    break;
                case 2:
                    Console.WriteLine("Enter the MOdifed Value");
                    string LName = Console.ReadLine();
                    ContactArray[i].LastName = LName;
                    break;
                case 3:
                    Console.WriteLine("Enter the MOdifed Value");
                    string Add = Console.ReadLine();
                    ContactArray[i].Address = Add;
                    break;
                case 4:
                    Console.WriteLine("Enter the MOdifed Value");
                    string city = Console.ReadLine();
                    ContactArray[i].City = city;
                    break;
                case 5:
                    Console.WriteLine("Enter the MOdifed Value");
                    string StateN = Console.ReadLine();
                    ContactArray[i].State = StateN;
                    break;
                case 6:
                    Console.WriteLine("Enter the MOdifed Value");
                    int ZipN = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].Zip = ZipN;
                    break;
                case 7:
                    Console.WriteLine("Enter the MOdifed Value");
                    string MailID = Console.ReadLine();
                    ContactArray[i].Email = MailID;
                    break;
                case 8:
                    Console.WriteLine("Enter the MOdifed Value");
                    long PhnNum = Convert.ToInt64(Console.ReadLine());
                    ContactArray[i].PhoneNum = PhnNum;
                    break;


            }
            Program pr = new Program();
            pr.DisplayContacts(ContactArray, Contact);
        }

    }
}