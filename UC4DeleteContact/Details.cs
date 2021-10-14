using System;
using System.Collections.Generic;
using System.Text;

namespace UC4DeleteContact
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
        public void RemoveInfo()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove:");
            string firstname = Console.ReadLine();
            //UC4_DeleteContact findperson = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
            Details findperson = people.Find(x => x.Fname.ToLower() == firstname.ToLower());
            if (findperson == null)
            {
                Console.WriteLine("That person could not be found");
            }

            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            Display(findperson);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                people.Remove(findperson);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
            ListContact();
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("OKK. Press any key to continue.");
            }

        }

        public void choice()
        {
            Console.WriteLine("Press 1 :Adding New Contact");
            
            Console.WriteLine("Press 2 :Removing Contact");

            switch (Console.ReadLine())
            {
                case "1":

                    AddInfo();
                    ListContact();
                    break;
                
                case "2":
                    RemoveInfo();
                    ListContact();
                    break;


                default:
                    Console.WriteLine("The choice you made is not valid, please try again");
                    break;
            }
        }
    }
}
