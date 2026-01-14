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
                Console.WriteLine("Enter 2 to Update Existing Contact");
                Console.WriteLine("Enter 3 to Delete Contact");
                Console.WriteLine("Enter 4 to Add Multiple Contact");
                Console.WriteLine("Enter 5 to Exit");
               
                Console.WriteLine("Enter Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cu.AddSingleContact();
                        break;

                    case 2:
                        cu.UpdateContact();
                        break;

                    case 3:
                        cu.DeleteContact();
                        break;
                    case 4:
                        cu.AddMultipleContact();
                        break;

                    case 5:
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
