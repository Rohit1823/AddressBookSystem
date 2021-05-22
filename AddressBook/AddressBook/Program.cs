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
                    default:
                        Console.WriteLine("=====\n!!Choose valid operation!!\n=====");
                        break;

                }
                Console.WriteLine("=====\nChoose the operation::\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Search Person via City.\n6.Exit Adress Book Application.\n=====");
                userInput = Console.ReadLine();
            }
        }
    }
    
}
