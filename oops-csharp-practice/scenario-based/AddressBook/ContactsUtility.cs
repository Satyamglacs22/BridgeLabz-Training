using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AddressBook
{
    internal class ContactsUtility : IContact
    {
        // ===== AddressBook level (ARRAY instead of LIST) =====
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
            string name = Console.ReadLine();

            for (int i = 0; i < addressBookCount; i++)
            {
                if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists");
                    return;
                }
            }

            addressBookNames[addressBookCount] = name;
            addressBooks[addressBookCount] = new Contacts[100]; // max 100 contacts
            addressBookCount++;

            Console.WriteLine("Address Book Created Successfully");
        }

        public bool SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name");
            string name = Console.ReadLine();

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
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter ZIP Code");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

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

            // ===== ADD CONTACT (ONLY ONCE) =====
            contactList[contactCount++] = new Contacts(
                firstName, lastName, address, city, zip, phoneNumber, email
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

            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available");
                return;
            }

            Console.WriteLine("Enter First Name to Update");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name to Update");
            string lName = Console.ReadLine();

            for (int i = 0; i < contactCount; i++)
            {
                if (contactList[i].FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter New City");
                    contactList[i].City = Console.ReadLine();

                    Console.WriteLine("Enter New Phone Number");
                    contactList[i].PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        public void DeleteContact()
        {
            if (!IsAddressBookSelected()) return;

            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available");
                return;
            }

            Console.WriteLine("Enter First Name to Delete");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name to Delete");
            string lName = Console.ReadLine();

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
