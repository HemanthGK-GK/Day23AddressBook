using System;
using System.Collections.Generic;
using System.Text;

namespace UC1AddressBook
{
    class Details
    {
        public string Fname, Lname, address, city, zipcode, state, Phnum, email;
        public void AddInfo()
        {

            Console.Write("Enter First Name: ");
            Fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            Lname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            address = Console.ReadLine();

            Console.Write("Enter City name: ");
            city = Console.ReadLine();

            Console.Write("Enter State name: ");
            state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            Phnum = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            email = Console.ReadLine();

            Console.WriteLine("\nDetails of the Person are given below: ");
            Console.WriteLine("\nFirst Name: " + Fname);
            Console.WriteLine("\nLast Name: " + Lname);
            Console.WriteLine("\nAddress: " + address);
            Console.WriteLine("\nCity: " + city);
            Console.WriteLine("\nState: " + state);
            Console.WriteLine("\nZip Code: " + zipcode);
            Console.WriteLine("\nPhone Number: " + Phnum);
            Console.WriteLine("\nEmail ID: " + email);

        }
    }
}
