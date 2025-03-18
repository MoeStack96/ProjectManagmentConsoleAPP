using ProjectManagementConsoleApp;

while (true)
{
    Console.WriteLine("Welcome! \n");
    Console.WriteLine("1. List all contacts");
    Console.WriteLine("2. Add contact");
    Console.WriteLine("3. QUIT!");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            // Add Project & Custumer
            break;

        case "2":
            // Update Project & Custumer
            break;
        case "3":
            // Delete Project & Custumer
            break;
        default:
            Console.WriteLine();
            break;
    }
}




