using System;
using System.Collections.Generic;
using System.Text;

namespace UC6UniqueAddress
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
        public void UpdateInfo()
        {
            Console.WriteLine("Enter the First Name of the Person U want to update");
            string firstname = Console.ReadLine();
            Details person = people.Find(x => x.Fname.ToLower() == firstname.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person U entered is not found");
            }

            Console.WriteLine("Are you sure you want to edit the person details from your address book? Enter --> (Y/N)");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("Press 1 if u want to edit the LastName");
                Console.WriteLine("Press 2 if u want to edit the Address");
                Console.WriteLine("Press 3 if u want to edit the City");
                Console.WriteLine("Press 4 if u want to edit the State");
                Console.WriteLine("Press 5 if u want to edit the Zip Code");
                Console.WriteLine("Press 6 if u want to edit the Phone Number");
                Console.WriteLine("Press 7 if u want to edit the Email Id");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter New LastName; ");
                        person.Lname = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("Last Name: " + person.Lname);
                        break;
                    case 2:
                        Console.WriteLine("Enter New Address; ");
                        person.address = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("Address: " + person.address);
                        break;
                    case 3:
                        Console.WriteLine("Enter New City: ");
                        person.city = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("City: " + person.city);
                        break;
                    case 4:
                        Console.WriteLine("Enter New State: ");
                        person.state = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("MobileNumber: " + person.state);
                        break;
                    case 5:
                        Console.WriteLine("Enter New ZipCode: ");
                        person.zipcode = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("ZipCode: " + person.zipcode);
                        break;
                    case 6:
                        Console.WriteLine("Enter New PhoneNumber: ");
                        person.Phnum = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("PhoneNumber: " + person.Phnum);
                        break;
                    case 7:
                        Console.WriteLine("Enter New Email ID: ");
                        person.email = Console.ReadLine();
                        people.Add(person);
                        Console.WriteLine("Email Id: " + person.email);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("OKK. Press any key to continue.");
            }
            ListContact();

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

        public void AddUnique()
        {
            Console.Write("How many contacts want to add :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                while (i <= num)
                {
                    Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
                    switch (Console.ReadLine())
                    {
                        case "1":

                            for (int j = 0; j < num; j++)
                            {
                                Console.Write("Enter the First Name: ");
                                string fname = Console.ReadLine();
                                if (people[j].Fname.Equals(fname))
                                {
                                    Console.WriteLine("Name already exists\n");
                                    Console.ReadKey();
                                    Console.WriteLine("\nEnter a New name and Add the details");
                                    AddInfo();
                                    ListContact();
                                }
                                else
                                {
                                    AddInfo();
                                    ListContact();
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("The choice you made is not valid, please try again");
                            break;
                    }
                    i++;
                    break;
                }

            }
            
        
         }
        public void choice()
        {
            Console.WriteLine("Press 1 :Adding New Contact");
            Console.WriteLine("Press 2 :Editing old Contact");
            Console.WriteLine("Press 3 :Removing Contact");


            switch (Console.ReadLine())
            {
                case "1":

                    AddInfo();
                    ListContact();
                    break;
                case "2":
                    UpdateInfo();
                    break;
                case "3":
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
