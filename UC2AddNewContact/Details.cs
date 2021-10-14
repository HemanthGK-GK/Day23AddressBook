using System;
using System.Collections.Generic;
using System.Text;

namespace UC2AddNewContact
{
    class Details
    {
        public string Fname, Lname, address, city, zipcode, state, Phnum, email;
        public static List<Details> people = new List<Details>();
        public void AddInfo()
        {
            Details obj = new Details();
            Console.Write("Enter First Name: ");
            obj.Fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            obj.Lname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            obj.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            obj.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            obj.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            obj.zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            obj.Phnum = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            obj.email = Console.ReadLine();

            people.Add(obj);
            Display(obj);
        }
        public void Display(Details obj)
        {
            Console.WriteLine("\nDetails of the Person are given below: ");
            Console.WriteLine("\nFirst Name: " + obj.Fname);
            Console.WriteLine("\nLast Name: " + obj.Lname);
            Console.WriteLine("\nAddress: " + obj.address);
            Console.WriteLine("\nCity: " + obj.city);
            Console.WriteLine("\nState: " + obj.state);
            Console.WriteLine("\nZip Code: " + obj.zipcode);
            Console.WriteLine("\nPhone Number: " + obj.Phnum);
            Console.WriteLine("\nEmail ID: " + obj.email);

        }

        public void ListContact()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("\nYour address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("\nHere are the current people in your address book:\n");
                foreach (var person in people)
                {
                    Console.Write(" " + person);
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }

        public void choice()
        {
            Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
            switch (Console.ReadLine())
            {
                case "1":

                    AddInfo();
                    ListContact();
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }
        }
    }
}
