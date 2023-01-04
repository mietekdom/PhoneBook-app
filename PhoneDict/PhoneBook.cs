using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneDict
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
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
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
            DisplayContactDetails(Contacts);
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacys = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList(); //jesli w nazwie zawiera jakies wartości z frazy szukanej
            {
                DisplayContactDetails(matchingContacys);
            }
        }
    }
}
