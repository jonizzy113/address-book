using System;
using System.Collections.Generic;

namespace Address_Book
{
    class AddressBook
    {
        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public void AddContact(Contact contactObject)
        {
            try {
            addressBook.Add(contactObject.Email, contactObject);
            Console.Write($"{contactObject.Email} has been added successfully to the book. ");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{contactObject.Email} was already added. ");
            }
        }

        public Contact GetByEmail(string email)
        {
            Contact contactReturn = addressBook[email];
            return contactReturn;
        }
    }
}