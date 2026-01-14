using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactsMenu
    {
        ContactsUtility cu = new ContactsUtility();

        public void ShowMenu()
        {
            bool found = false;

            while (!found)
            {
                Console.WriteLine("Enter 1 to Add Single Contact");
                Console.WriteLine("Enter 2 to Exit");
                Console.WriteLine("Enter Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cu.AddSingleContact();
                        break;

                    case 2:
                        found = true;
                        Console.WriteLine("Exiting Address Book...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
