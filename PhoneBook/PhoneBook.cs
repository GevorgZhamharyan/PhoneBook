using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class PhoneBook
    {
        public string name;

        public string surname;

        public char separator;

        public int phoneNumber; 

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
