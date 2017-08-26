using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class Contact
    {
        public Contact(string lastName, string firstName, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
    }
}