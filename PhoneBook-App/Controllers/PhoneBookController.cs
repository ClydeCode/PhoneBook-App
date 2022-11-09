using Microsoft.Data.SqlClient;

internal class PhoneBookController
{
    readonly Database Database = new();
    readonly TableVisualisationEngine TVEngine = new();
    internal void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Show contacts");
        Console.WriteLine("2. Add contact");
        Console.WriteLine("3. Delete contact");
        Console.WriteLine("4. Update contact");
        Console.WriteLine("5. Exit");
    }

    internal void Navigate(int Option)
    {
        switch (Option)
        {
            case 1:
                ShowContacts();
                break;
            case 2:
                AddContact();
                break;
            case 3:
                DeleteContact();
                break;
            case 4:
                UpdateContact();    
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Wrong Option!");
                break;
        }
    }

    private void ShowContacts()
    {
        TVEngine.Add(Database.ReadAll());
        Console.Clear();
        TVEngine.Print();
        TVEngine.Clear();
    }

    private void AddContact()
    {
        string Name = GetUserInput.GetString("Name");
        string PhoneNumber = GetUserInput.GetString("Phone Number");

        try
        {
            Database.Add(new ContactClass { Name = Name, PhoneNumber = PhoneNumber });

            Console.WriteLine("\nOperation was successful!");
        }
        catch (InvalidOperationException) { Console.WriteLine("\nERROR: Operation was unsuccessful!"); }
    }

    private void DeleteContact()
    {
        int Id = GetUserInput.GetInt("ID");

        Database.Delete(Id);
    }

    private void UpdateContact()
    {
        throw new NotImplementedException();
    }


}

