using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KalAddressBook.Models
{
    internal static class ContactManager
    {
        public static void GetAllContacts(ObservableCollection<Contact> contacts)
        {
            var allContacts = getContacts();
            contacts.Clear();
            allContacts.ForEach(contact => contacts.Add(contact));
        }

        public static void GetContactsByCategory(ObservableCollection<Contact> contacts,ContactCategory category)

        {
            var allContacts = getContacts();
            contacts.Clear();
            var filteredContacts = allContacts.Where(contact => contact.Category == category).ToList();
            filteredContacts.ForEach(contact => contacts.Add(contact));
        }
    
        private static List<Contact> getContacts()
        {
            var contacts = new List<Contact>();
            contacts.Add(new Contact("Ana",ContactCategory.A,"9893309708","8221 waverlylane"));
            contacts.Add(new Contact("Apple", ContactCategory.A, "9893309708", "8221 waverlylane"));
            contacts.Add(new Contact("Anisha", ContactCategory.A, "9893309708", "8221 waverlylane"));
            contacts.Add(new Contact("Bob", ContactCategory.B, "9893309708", "8221 waverlylane"));
            contacts.Add(new Contact("Bider", ContactCategory.B, "9893309708", "8221 waverlylane"));
            contacts.Add(new Contact("Brian", ContactCategory.B, "9893309708", "8221 waverlylane"));

            return contacts;
        }
    }
}
