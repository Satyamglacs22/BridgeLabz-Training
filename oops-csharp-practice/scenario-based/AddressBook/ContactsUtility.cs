using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class ContactsUtility : IContact
    {
        private List<Contacts> contactList = new List<Contacts>();

        public void AddSingleContact()
        {
           

            
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

                Contacts contact = new Contacts(
                    firstName,
                    lastName,
                    address,
                    city,
                    zip,
                    phoneNumber,
                    email
                );

                contactList.Add(contact);
                Console.WriteLine("Contact Added Successfully\n");
            }
        

        public void UpdateContact()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("No contacts available. Please add contacts first.");
                return;
            }

            Console.WriteLine("Enter First Name of Contact to Update");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name of Contact to Update");
            string lName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter New Address");
                    contactList[i].Address = Console.ReadLine();

                    Console.WriteLine("Enter New City");
                    contactList[i].City = Console.ReadLine();

                    Console.WriteLine("Enter New ZIP");
                    contactList[i].Zip = Console.ReadLine();

                    Console.WriteLine("Enter New Phone Number");
                    contactList[i].PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter New Email");
                    contactList[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact Not Found");
            }
        }
        public void DeleteContact()


        {

            if (contactList.Count == 0)
            {
                Console.WriteLine("No contacts available. Please add contacts first.");
                return;
            }
            Console.WriteLine("Enter the Contact Name that You Want to Delete");
            Console.WriteLine("Enter the First Name");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name of Contact to Update");
            string lName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                    contactList[i].LastName.Equals(lName, StringComparison.OrdinalIgnoreCase))
                {
                    contactList.Remove(contactList[i]);

                    Console.WriteLine("Contact Deleted Successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact Not Found");
            }

        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter the Number Of Contacts You Want to Add");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
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

                Contacts contact = new Contacts(
                    firstName,
                    lastName,
                    address,
                    city,
                    zip,
                    phoneNumber,
                    email
                );

                contactList.Add(contact);
                Console.WriteLine("Contact Added Successfully\n");
            }

        }
    }
}
