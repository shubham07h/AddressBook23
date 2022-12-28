using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address BOOK Program");
            AddressBook ab = new AddressBook("shubham", "hjdhjd", "abs", "delhi", "delhi", "shubham@gmail.com", 400023, 933387412);
            ab.DisplayContacts();
        }
    }
}