using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class ContactsUtility:IContact
    {

        private List<Contacts> contact = new List<Contacts>();
        

        public void AddSingleContact()
        {
            Console.WriteLine("Enter the Number Of Contacts You Want to Add");
           

            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter FirstName");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter LastName");
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

                Contacts contacts = new Contacts (firstName, lastName, address, city, zip, phoneNumber, email);
                contact.Add(contacts);

                Console.WriteLine("Contact Added Successfully");

            }
        }
    }
}
