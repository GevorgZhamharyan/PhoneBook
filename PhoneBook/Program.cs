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
            pb[1] = new PhoneBook("Hovhannes" , "Shitikyan" , '*' , 01254); 
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



                /* Console.Write("Please choose criteria: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // case 1: --> name
                // case 2: --> surname
                // case 3: --> phoneNumberCode 


                foreach (var item in pb)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(item.name);
                            break;

                        case 2:
                            Console.WriteLine(item.surname);
                            break;

                        case 3:
                            Console.WriteLine(item.phoneNumber.ToString().Substring(0,3)); 
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong Input Value!!!Please try again...");
                            Console.ForegroundColor = ConsoleColor.White;
                            break; 
                    }
                } */  

            }

        }
    }
}
