namespace Assignment_4._1._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            var addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. View list of contacts");
                Console.WriteLine("3. Delete a contact");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Quit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add a new contact
                        // Read input for FirstName, LastName, MobilePhone, WorkPhone, and Address
                        // Create a Person object and add it to the address book
                        break;
                    case "2":
                        addressBook.DisplayAllContacts();
                        break;
                    case "3":
                        // Delete a contact by name
                        break;
                    case "4":
                        // Search by name
                        // Display details of the found contact
                        break;
                    case "5":
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }



    }
       
}