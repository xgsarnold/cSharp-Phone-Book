using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Models;

namespace PhoneBook.Data
{
    public class ContactRepository
    {
        private static Contact[] _contacts = new Contact[]
            {
                new Contact()
                {
                    Id = 1,
                    LastName = "Arnold",
                    FirstName = "Charlea",
                    PhoneNumber = "630-803-2573"
                },

                new Contact()
                {
                    Id = 2,
                    LastName = "Arnold",
                    FirstName = "Scott",
                    PhoneNumber = "630-347-7910"
                },

                new Contact()
                {
                    Id = 3,
                    LastName = "Arnold",
                    FirstName = "Michael",
                    PhoneNumber = "630-803-2573"
                }
            };

        public Contact[] GetContacts()
        {
            return _contacts;
        }

        public Contact GetContact(int id)
        {
            Contact contactToReturn = null;

            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    contactToReturn = contact;

                    break;
                }
            }

            return contactToReturn;
        }
    }
}