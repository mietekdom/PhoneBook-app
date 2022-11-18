using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneDict
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
            }
        }
    }
}
