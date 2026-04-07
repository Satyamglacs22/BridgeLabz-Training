using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class ContactsUtility : IContact
    {
        // ===== AddressBook Level =====
        // Key = AddressBook Name, Value = List of Contacts
        private Dictionary<string, List<Contacts>> addressBooks =
            new Dictionary<string, List<Contacts>>(StringComparer.OrdinalIgnoreCase);

        // Selected Address Book
        private List<Contacts> contactList = null;
        private string selectedBookName = null;

        // ================= ADDRESS BOOK =================

        public void CreateAddressBooks()
        {
            Console.WriteLine("How many Address Books do you want to create?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                AddAddressBook();
            }
        }

        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name");
            string name = Console.ReadLine().Trim();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists");
                return;
            }

            addressBooks[name] = new List<Contacts>();
            Console.WriteLine("Address Book Created Successfully");
        }

        public bool SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name");
            string name = Console.ReadLine().Trim();

            if (addressBooks.ContainsKey(name))
            {
                selectedBookName = name;
                contactList = addressBooks[name];
                Console.WriteLine("Address Book Selected Successfully");
                return true;
            }

            Console.WriteLine("Address Book Not Found");
            return false;
        }

        private bool IsAddressBookSelected()
        {
            if (contactList == null)
            {
                Console.WriteLine("Please select an Address Book first");
                return false;
            }
            return true;
        }

        // ================= CONTACT OPERATIONS =================

        public void AddSingleContact()
        {
            if (!IsAddressBookSelected()) return;

            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine().Trim();

            // Duplicate Check
            foreach (Contacts c in contactList)
            {
                if (c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact Already Exists in this Address Book!");
                    return;
                }
            }

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine().Trim();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine().Trim();

            Console.WriteLine("Enter State");
            string state = Console.ReadLine().Trim();

            Console.WriteLine("Enter ZIP Code");
            string zip = Console.ReadLine().Trim();

            Console.WriteLine("Enter Phone Number");
            string phone = Console.ReadLine().Trim();

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine().Trim();

            contactList.Add(new Contacts(
                firstName, lastName, address, city, state, zip, phone, email
            ));

            Console.WriteLine("Contact Added Successfully");
        }

        public void AddMultipleContact()
        {
            if (!IsAddressBookSelected()) return;

            Console.WriteLine("Enter Number of Contacts");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                AddSingleContact();
            }
        }

        public void UpdateContact()
        {
            if (!IsAddressBookSelected()) return;

            Console.WriteLine("Enter First Name to Update");
            string fName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Last Name to Update");
            string lName = Console.ReadLine().Trim();

            foreach (Contacts c in contactList)
            {
                if (c.FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    c.LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter New City");
                    c.City = Console.ReadLine().Trim();

                    Console.WriteLine("Enter New Phone Number");
                    c.PhoneNumber = Console.ReadLine().Trim();

                    Console.WriteLine("Contact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        public void DeleteContact()
        {
            if (!IsAddressBookSelected()) return;

            Console.WriteLine("Enter First Name to Delete");
            string fName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Last Name to Delete");
            string lName = Console.ReadLine().Trim();

            Contacts contactToRemove = null;

            foreach (Contacts c in contactList)
            {
                if (c.FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    c.LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    contactToRemove = c;
                    break;
                }
            }

            if (contactToRemove != null)
            {
                contactList.Remove(contactToRemove);
                Console.WriteLine("Contact Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }

        // ================= UC8 =================
        // Search Person by City or State across Multiple Address Books

        public void SearchPersonByCityOrStateForMultipleAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books Available");
                return;
            }

            Console.WriteLine("Search By:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter search value");
            string value = Console.ReadLine().Trim();

            bool found = false;

            foreach (var book in addressBooks)
            {
                foreach (Contacts c in book.Value)
                {
                    if ((choice == 1 && c.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                        (choice == 2 && c.State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                    {
                        PrintContactWithBookName(c, book.Key);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found for given City/State");
            }
        }

        // ================= UC9 =================
        // View + Count in Selected Address Book

        public void SearchPersonByCityOrState()
        {
            if (!IsAddressBookSelected()) return;

            Console.WriteLine("View & Count By:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter City/State value");
            string value = Console.ReadLine().Trim();

            int count = 0;

            foreach (Contacts c in contactList)
            {
                if ((choice == 1 && c.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                    (choice == 2 && c.State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                {
                    PrintContact(c);
                    count++;
                }
            }

            Console.WriteLine($"Total persons found : {count}");
        }

        // ================= SORT =================

        public void SortContactsByName()
        {
            if (!IsAddressBookSelected()) return;

            contactList.Sort((c1, c2) =>
                string.Compare(
                    c1.FirstName + c1.LastName,
                    c2.FirstName + c2.LastName,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Contacts Sorted Successfully");
        }

        // ================= PRINT =================

        private void PrintContactWithBookName(Contacts c, string bookName)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Address Book : {bookName}");
            PrintContact(c);
        }

        private void PrintContact(Contacts c)
        {
            Console.WriteLine($"Name  : {c.FirstName} {c.LastName}");
            Console.WriteLine($"City  : {c.City}");
            Console.WriteLine($"State : {c.State}");
            Console.WriteLine($"Phone : {c.PhoneNumber}");
            Console.WriteLine($"Email : {c.Email}");
            Console.WriteLine($"Zip   : {c.Zip}");
            Console.WriteLine("----------------------------------");
        }
    }
}
