using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================\nPress 1 to Create AddressBook and add Contact. \nPress 2 to Exit Adress Book Application.\n=================================");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBookMain();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        addressBook.StoreContact();
                        break;
                    case "2":
                        addressBook.DisplayAllContact();
                        break;
                    case "3":
                        addressBook.EditContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        addressBook.DuplicateChecker();
                        break;
                    case "6":
                        addressBook.SearchPerson();
                        break;
                    case "7":
                        addressBook.FindCityState();
                        break;
                    case "8":
                        addressBook.FindNumOfPerson();
                        break;
                    default:
                        Console.WriteLine("=====\n!!Choose valid operation!!\n=====");
                        break;

                }
                Console.WriteLine("=================================\nChoose the operation::\n3.View Saved Contacts.\n4.Edit Existing Contact.\n5.Delete Existing Contact.\n6.Add Another Contact.\n7.Search Person Name on Basis of City or State.\n8.Find City and State of a Particular Person.\n9.Find Number of Person found in a City or State.\n...Press 2 to EXIT the Adress Book Application.\n=================================");
                userInput = Console.ReadLine();
            }
        }
    }
    
}
