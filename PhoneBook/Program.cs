using System;
using System.IO; 

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PhoneBook[] pb = new PhoneBook[4];

            pb[0] = new PhoneBook("Edgar", "Danielyan", '/', 0214511111); 
            pb[1] = new PhoneBook("Hovhannes" , "Shitikyan" , ':' , 01254);
            pb[2] = new PhoneBook("Artak" , "Hovhannisyan" , ',' , 0988888888);
            pb[3] = new PhoneBook("Nara" , "Hovhannisyan" , '@' , 012546); 


            foreach (var item in pb)
            {
                File.WriteAllText("C:\\Results\\PhoneBook.txt",
                item.name + " " + item.surname + " " + item.separator + " " + item.phoneNumber);
                string read = File.ReadAllText("C:\\Results\\PhoneBook.txt");
                Console.WriteLine(read); 
            }

            Console.WriteLine("\n");

            int count = 0;

            Console.WriteLine("Validations:\n");  
            for (int i = 0; i < pb.Length; i++) 
            {
                Console.Write("line " + i + ":"); 
                for (int j = pb[i].phoneNumber; j != 0; j /= 10) 
                {
                    count++; 
                }
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Quantity: " + count); 
                Console.ForegroundColor = ConsoleColor.White; 

                if((pb[i].separator != ':' || pb[i].separator != '-') && count != 9) 
                {
                    Console.WriteLine("Phone number should be with 9 digits. Separator should be `:` or `-`. ");
                } 
                else if(count != 9)  
                {
                    Console.WriteLine("Phone number should be with 9 digits."); 
                }
                else if (pb[i].separator != ':' || pb[i].separator != '-')
                {
                    Console.WriteLine("Separator should be `:` or `-`. ");
                }
                else if((pb[i].separator == ':' || pb[i].separator == '-') && count == 9)
                {
                    Console.WriteLine("There is no problem!"); 
                }
                Console.WriteLine(); 

                count = 0;

                Console.WriteLine(); 
            } 
        }
    }
}
