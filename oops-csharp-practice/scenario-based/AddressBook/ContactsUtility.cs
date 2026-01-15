using System;

namespace AddressBook
{
    internal class ContactsUtility : IContact
    {
        // ===== AddressBook Level =====
        private Contacts[][] addressBooks;
        private string[] addressBookNames;
        private int addressBookCount = 0;

        // Selected AddressBook
        private Contacts[] contactList = null;
        private int contactCount = 0;

        // ================= ADDRESS BOOK =================

        public void CreateAddressBooks()
        {
            Console.WriteLine("How many Address Books do you want to create?");
            int count = int.Parse(Console.ReadLine());

            addressBooks = new Contacts[count][];
            addressBookNames = new string[count];

            for (int i = 0; i < count; i++)
            {
                AddAddressBook();
            }
        }

        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name");
            string name = Console.ReadLine().Trim();

            for (int i = 0; i < addressBookCount; i++)
            {
                if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists");
                    return;
                }
            }

            addressBookNames[addressBookCount] = name;
            addressBooks[addressBookCount] = new Contacts[100];
            addressBookCount++;

            Console.WriteLine("Address Book Created Successfully");
        }

        public bool SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name");
            string name = Console.ReadLine().Trim();

            for (int i = 0; i < addressBookCount; i++)
            {
                if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    contactList = addressBooks[i];
                    contactCount = GetContactCount(contactList);
                    Console.WriteLine("Address Book Selected Successfully");
                    return true;
                }
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

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine().Trim();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine().Trim();

            Console.WriteLine("Enter State");
            string state = Console.ReadLine().Trim();

            Console.WriteLine("Enter ZIP Code");
            string zip = Console.ReadLine().Trim();

            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine().Trim();

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine().Trim();

            // ===== DUPLICATE CHECK =====
            for (int i = 0; i < contactCount; i++)
            {
                if (contactList[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact Already Exists in this Address Book!");
                    return;
                }
            }

            contactList[contactCount++] = new Contacts(
                firstName, lastName, address, city, state, zip, phoneNumber, email
            );

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

            for (int i = 0; i < contactCount; i++)
            {
                if (contactList[i].FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter New City");
                    contactList[i].City = Console.ReadLine().Trim();

                    Console.WriteLine("Enter New Phone Number");
                    contactList[i].PhoneNumber = Console.ReadLine().Trim();

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

            for (int i = 0; i < contactCount; i++)
            {
                if (contactList[i].FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < contactCount - 1; j++)
                    {
                        contactList[j] = contactList[j + 1];
                    }

                    contactList[--contactCount] = null;
                    Console.WriteLine("Contact Deleted Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        // ================= UC8 =================
        // Search Person by City or State across Multiple Address Books

        public void SearchPersonByCityOrStateForMultipleAddressBook()
        {
            if (addressBookCount == 0)
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

            for (int i = 0; i < addressBookCount; i++)
            {
                Contacts[] contacts = addressBooks[i];

                for (int j = 0; j < contacts.Length; j++)
                {
                    if (contacts[j] == null)
                        continue;

                    if (choice == 1 &&
                        contacts[j].City.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        PrintContactWithBookName(contacts[j], addressBookNames[i]);
                        found = true;
                    }
                    else if (choice == 2 &&
                        contacts[j].State.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        PrintContactWithBookName(contacts[j], addressBookNames[i]);
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
        // Search Person by City or State 


        // ================= UC9 =================
        // View + Count Persons by City or State in Selected Address Book

        public void SearchPersonByCityOrState()
        {
            if (!IsAddressBookSelected())
                return;

            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available in selected Address Book");
                return;
            }

            Console.WriteLine("View & Count By:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter City/State value");
            string value = Console.ReadLine().Trim();

            int count = 0;

            Console.WriteLine("\n--- Matching Contacts ---");

            for (int i = 0; i < contactCount; i++)
            {
                if (choice == 1 &&
                    contactList[i].City.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    PrintContact(contactList[i]);
                    count++;
                }
                else if (choice == 2 &&
                    contactList[i].State.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    PrintContact(contactList[i]);
                    count++;
                }
            }

            Console.WriteLine("----------------------------------");
            if (choice == 1)
                Console.WriteLine($"Total persons from City '{value}' : {count}");
            else
                Console.WriteLine($"Total persons from State '{value}' : {count}");

            if (count == 0)
            {
                Console.WriteLine("No matching contacts found.");
            }
        }
        // ================= SORT (ALTERNATE WAY) =================
        // Sort entries alphabetically by Person's Name
        // PURE ARRAY + BUBBLE SORT

        public void SortContactsByName()
        {
            if (!IsAddressBookSelected())
                return;

            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available to sort");
                return;
            }

            // Bubble Sort on array
            for (int i = 0; i < contactCount - 1; i++)
            {
                for (int j = 0; j < contactCount - i - 1; j++)
                {
                    string name1 = contactList[j].FirstName + " " + contactList[j].LastName;
                    string name2 = contactList[j + 1].FirstName + " " + contactList[j + 1].LastName;

                    if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap
                        Contacts temp = contactList[j];
                        contactList[j] = contactList[j + 1];
                        contactList[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n--- Contacts Sorted Alphabetically by Name ---");

            for (int i = 0; i < contactCount; i++)
            {
                Console.WriteLine(contactList[i].ToString());
                Console.WriteLine("----------------------------------");
            }
        }




        private void PrintContactWithBookName(Contacts c, string bookName)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Address Book : {bookName}");
            Console.WriteLine($"Name         : {c.FirstName} {c.LastName}");
            Console.WriteLine($"City         : {c.City}");
            Console.WriteLine($"State        : {c.State}");
            Console.WriteLine($"Phone        : {c.PhoneNumber}");
            Console.WriteLine($"Email        : {c.Email}");
            Console.WriteLine($"Zip Code     : {c.Zip}");
        }

        // For UC9
        private void PrintContact(Contacts c)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Name         : {c.FirstName} {c.LastName}");
            Console.WriteLine($"City         : {c.City}");
            Console.WriteLine($"State        : {c.State}");
            Console.WriteLine($"Phone        : {c.PhoneNumber}");
            Console.WriteLine($"Email        : {c.Email}");
            Console.WriteLine($"Zip Code     : {c.Zip}");
        }



        // ================= HELPER =================

        private int GetContactCount(Contacts[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                    count++;
            }
            return count;
        }
    }
}
