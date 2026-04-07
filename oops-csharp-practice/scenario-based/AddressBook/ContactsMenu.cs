using System;

namespace AddressBook
{
    public class ContactsMenu
    {
        ContactsUtility cu = new ContactsUtility();

        // ================= MAIN MENU =================
        public void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
                Console.WriteLine("1. Create Address Books");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Search Person by City/State (UC8)");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cu.CreateAddressBooks();
                        break;

                    case 2:
                        if (cu.SelectAddressBook())
                        {
                            ShowContactMenu();
                        }
                        break;

                    case 3:
                        
                        cu.SearchPersonByCityOrStateForMultipleAddressBook();
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting Address Book System...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        // ================= CONTACT MENU =================
        private void ShowContactMenu()
        {
            bool back = false;

            while (!back)
            {
                Console.WriteLine("\n----- CONTACT OPERATIONS (Selected Address Book) -----");
                Console.WriteLine("1. Add Single Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Add Multiple Contacts");
                Console.WriteLine("5. View & Count by City/State (UC9)");
                Console.WriteLine("6. Sort Contacts Alphabetically by Name");
                Console.WriteLine("7. Back to Address Book Menu");
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
                        
                        cu.SearchPersonByCityOrState();
                        break;

                    case 6:
                        
                        cu.SortContactsByName();
                        break;

                    case 7:
                        back = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
