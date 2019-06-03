using System;

namespace Address_Book
{
    class Contact {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}
        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }
        public Contact () {
            FirstName = FirstName;
            LastName = LastName;
            Email = Email;
            Address = Address;
        }
    }
}