using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class PhoneBook
    {
        public List<Contact> Contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DisplayContactByNumber(string number)
        {
            var searchByNumber = Contacts.FirstOrDefault(c => c.Number == number);
            Console.WriteLine(searchByNumber.Name);
        }

        public void DisplayContactByPhrase(string phrase)
        {
            var searchByPhrase = Contacts.Where(c => c.Name.Contains(phrase)).ToList();
           foreach(var con in searchByPhrase)
            {
                Console.WriteLine(con.Name);
                Console.WriteLine(con.Number);
            }
        }

        public void DeleteContactByName(string name)
        {
            var searchContact = Contacts.FirstOrDefault(c => c.Name==name);
            
            Contacts.Remove(searchContact);
            

        }
    }
}
