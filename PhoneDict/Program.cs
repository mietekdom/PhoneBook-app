using System;

namespace PhoneDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Phone Book app");

            Console.WriteLine("1 - add contact");
            Console.WriteLine("2 - display contact by number");
            Console.WriteLine("3 - display all contacts");
            Console.WriteLine("4 - search contact");
            Console.WriteLine("To exit insert x");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation, please write number between 1 to 4");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
            

        }

    }
}
