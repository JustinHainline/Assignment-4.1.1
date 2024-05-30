using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._1
{
    public class AddressBook
    {
        private Dictionary<string, Person> contacts = new Dictionary<string, Person>();

        public void AddContact(string key, Person person)
        {
            contacts[key] = person;
        }

        public bool DeleteContact(string key)
        {
            return contacts.Remove(key);
        }

        public Person GetContact(string key)
        {
            return contacts.TryGetValue(key, out var person) ? person : null;
        }

        public void DisplayAllContacts()
        {
            foreach (var kvp in contacts)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"  First Name: {kvp.Value.FirstName}");
                Console.WriteLine($"  Last Name: {kvp.Value.LastName}");
                Console.WriteLine($"  Mobile Phone: {kvp.Value.MobilePhone}");
                Console.WriteLine($"  Work Phone: {kvp.Value.WorkPhone}");
                Console.WriteLine($"  Address: {kvp.Value.Address}");
                Console.WriteLine();
            }
        }
    }
}
