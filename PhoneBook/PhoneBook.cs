using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class PhoneBook
    {
        public string name { get; set; }

        public string surname { get; set; }

        public char separator { get; set; }

        public int phoneNumber { get; set; } 

        public PhoneBook()
        {

        }

        public PhoneBook(string name, string surname, char separator, int phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.separator = separator;
            this.phoneNumber = phoneNumber; 
        }
        
    }
}
