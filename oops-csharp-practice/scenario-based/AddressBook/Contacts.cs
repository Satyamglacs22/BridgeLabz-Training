using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Contacts
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string zip;
        private string phoneNumber;
        private string email;

        public string FirstName
        {
            get
            {
                return firstName;

            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;

            }
            set
            {
                lastName = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

    }
}
